using CHSMonitoringKrasnoyarsk.Models;
using CHSMonitoringKrasnoyarsk.Models.SupplyMessageDescription;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Interfaces;

/// <summary>
/// Интерфейс для разбора данных из td элементов
/// </summary>
public interface ITdContentParserService
{
    /// <summary>
    /// Получение словаря с границами по индексам
    /// </summary>
    /// <param name="supplyTypeIndexes"></param>
    /// <returns></returns>
    Dictionary<string, List<int>> AddTheEndOfSupplyInfo(Dictionary<string, List<int>> supplyTypeIndexes);

    /// <summary>
    /// Получение конечных вариантов парсинга в удобном виде для сохранения в БД
    /// </summary>
    /// <param name="districtValues">Словарь полученных данных по каждому району через td</param>
    Dictionary<string, List<SupplyMessageDescription>> GetSupplyAlarmDescriptions(Dictionary<string, List<TableDescription>> districtValues);

    /// <summary>
    /// Получение данных по активным районам из td
    /// </summary>
    /// <param name="tableDescriptions">Список данных td из парсинга</param>
    /// <returns></returns>
    List<List<TableDescription>> GetDistrictsDataFromTableDescriptions(List<TableDescription> tableDescriptions);

    /// <summary>
    /// Переформатирование полученного списка в словарь
    /// </summary>
    /// <param name="tableDescriptions">Список данных td из парсинга</param>
    /// <returns></returns>
    Dictionary<string, List<TableDescription>> RestrictionTableDescriptionToDict(List<List<TableDescription>> tableDescriptions);

    /// <summary>
    /// Убирает запись Запланированное на завтра
    /// </summary>
    /// <param name="tableDescriptions">Список данных td из парсинга</param>
    /// <returns></returns>
    List<List<TableDescription>> RemovePlannedTableDescription(List<List<TableDescription>> tableDescriptions);
}