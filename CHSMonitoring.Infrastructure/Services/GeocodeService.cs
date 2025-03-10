﻿using System.Net;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.YandexMapApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Сервис получения геоданных
/// </summary>
public class GeocodeService : IGeocodeService
{
    private readonly IServiceAddressRepository _serviceAddressRepository;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;
    private readonly ILogger<GeocodeService> _logger;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="serviceAddressRepository"></param>
    /// <param name="configuration"></param>
    /// <param name="httpClientFactory"></param>
    /// <param name="logger"></param>
    public GeocodeService(IServiceAddressRepository serviceAddressRepository, IConfiguration configuration, IHttpClientFactory httpClientFactory, ILogger<GeocodeService> logger)
    {
        _serviceAddressRepository = serviceAddressRepository;
        _configuration = configuration;
        _httpClientFactory = httpClientFactory;
        _logger = logger;
    }

    public async Task<List<(string StreetName, string Latitude, string LongTitude, string ServiceTypeName)>> GetServiceAddressGeoDataAsync(string districtId, CancellationToken cancellationToken)
    {
        List<ServiceAddress> serviceAddresses = new();
        if (districtId.Trim().Equals("all", StringComparison.InvariantCultureIgnoreCase))
        {
            serviceAddresses = await _serviceAddressRepository.GetLatestServiceAddressAsync(cancellationToken)
                .ConfigureAwait(false);
            
            _logger.LogInformation($" Count in Service {serviceAddresses.Count}");
            return await GetServiceAddressGeoLocationsAsync(serviceAddresses).ConfigureAwait(false);
        }
        
        serviceAddresses = await _serviceAddressRepository.GetLatestServiceAddressByDistrictAsync(Guid.Parse(districtId), cancellationToken).ConfigureAwait(false);
        _logger.LogInformation($" Count in Service not all {serviceAddresses.Count}");
        return await GetServiceAddressGeoLocationsAsync(serviceAddresses).ConfigureAwait(false);
    }

    /// <summary>
    /// Получить информацию из YandexApi для получения геолокации адресов отключений
    /// </summary>
    /// <param name="serviceAddresses"></param>
    /// <returns></returns>
    private async Task<List<(string streetName, string latitude, string longtitude, string serviceTypeName)>> GetServiceAddressGeoLocationsAsync(List<ServiceAddress> serviceAddresses)
    {
        //TODO: Изменить потом для рабочего варианта
        serviceAddresses = serviceAddresses.Take(15).ToList();

        var httpClient = new HttpClient();
        var apiKey = _configuration["YandexMapKey"] ?? _configuration["YandexMapsApi:Key"];
        var city = "Красноярск";
        var lang = "ru-RU";
        var format = "json";
        
        List<(string streetName, string latitude, string longtitude, string serviceTypeName)> streetCoordinates = new();
        foreach (var serviceAddress in serviceAddresses)
        {
            var searchAddress = $"{serviceAddress.Street.Name}";
            var searchHouseNunmber = $"{serviceAddress.HouseNumber}";
            var request = $"https://geocode-maps.yandex.ru/1.x/?apikey={apiKey}&geocode={city}+{searchAddress},+{searchHouseNunmber}&lang={lang}&format={format}";
            _logger.LogInformation($"Отправленный запрос {request}");    
            
            var result = await httpClient
                .GetAsync(request)
                .ConfigureAwait(false);
            if (result.StatusCode != HttpStatusCode.OK)
            {
                _logger.LogError($"Ответ от YandexApi: {result.StatusCode}");
            }
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                var myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
                
                //TODO: Может быть некорректный ответ (Автокоррекция Яндекса)
                var point = myDeserializedClass.response.GeoObjectCollection.featureMember
                    .Select(x => x.GeoObject.Point)
                    .FirstOrDefault();
                
                if (point is null)
                {
                    _logger.LogError($"Отсутствует координаты");
                    continue;
                }
                    
                var correctPositionCoordinates = point.pos.Split(" ").Reverse().ToList();
                if (!correctPositionCoordinates.Any() || correctPositionCoordinates.Count != 2)
                {
                    continue;
                }

                var latitude = correctPositionCoordinates[0];
                var longtitude = correctPositionCoordinates[^1];
                _logger.LogInformation($"Полученные координаты: {latitude}, {longtitude}");

                var serviceTypeName = CommonData.ServiceTypesData
                    .FirstOrDefault(x => x.Id == serviceAddress.ServiceTypeId)
                    .ServiceTypeName;
                var address = $"{serviceAddress.Street.Name} {serviceAddress.HouseNumber}";
                streetCoordinates.Add((address, latitude, longtitude, serviceTypeName));
            }
        }
        
        return streetCoordinates;
    }
}