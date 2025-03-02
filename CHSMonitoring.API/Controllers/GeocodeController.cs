using System.Net;
using CHSMonitoring.Infrastructure.Models.YandexMapApi;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер получения геоданных по адресу
/// </summary>
[Route("/api/[controller]")]
[ApiController()]
public class GeocodeController : ControllerBase
{
    private readonly IConfiguration _configuration;

    /// <summary>
    /// Конструктор
    /// </summary>
    public GeocodeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetAddressGeodata()
    {
        using HttpClient httpClient = new();
        var requestVersion = "https://geocode-maps.yandex.ru/1.x/";
        var apiKey = _configuration["YandexMapKey"];
        var city = "Красноярск";
        var searchAddress = "Крупской";
        var searchHouseNunmber = "44абв";
        var lang = "ru-RU";
        var format = "json";
        var request = $"{requestVersion}?apikey={apiKey}&geocode={city}+{searchAddress},+{searchHouseNunmber}&lang={lang}&format={format}";
        
        var result = await httpClient
            .GetAsync(request)
            .ConfigureAwait(false);
        if (result.StatusCode == HttpStatusCode.OK)
        {
            //TODO: Получить ответ корректный для города
            var response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
        }
        
        return Ok(result);
    }
}