using System.Collections.Immutable;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Models;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Interfaces.Workers;

/// <summary>
/// Интерфейс для разбора данных из td элементов
/// </summary>
public interface ITdContentParserService
{
    /// <summary>
    /// Получение сообщений об отключениях с парсинга веб страницы
    /// </summary>
    /// <param name="tableDescriptions">Данные таблицы с отключениями</param>
    /// <returns></returns>
    Task<List<ServiceAddress>> GetServiceMessages(List<TableDescription> tableDescriptions);
}