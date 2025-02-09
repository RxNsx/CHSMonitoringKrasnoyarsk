using System.Collections.Immutable;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;
using HtmlAgilityPack;

namespace CHSMonitoring.Infrastructure.Interfaces.Workers;

/// <summary>
/// Интерфейс для получения данных из Html документа
/// </summary>
public interface IHtmlParserService
{
    public Task<List<ServiceAddress>> GetServiceMessages(HtmlDocument htmlDocument);
}