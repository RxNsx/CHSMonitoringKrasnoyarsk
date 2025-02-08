using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс сервиса получения адреса
/// </summary>
public interface IAddressParserService
{
    /// <summary>
    /// Получить словарь адресов из строки таблицы 005красноярск.рф html документа
    /// </summary>
    /// <param name="addressText"></param>
    /// <returns></returns>
    Dictionary<string, List<string>> GetAddressDictFromAddressText(string addressText);

    /// <summary>
    /// Распарсить номера домов в список адресов отключений
    /// </summary>
    /// <param name="addressDict"></param>
    /// <returns></returns>
    Task<List<Address>> ParseAddressNumbers(Dictionary<string, List<string>> addressDict);
    
    /// <summary>
    /// Получить доп описание отключения, чистый текст без доп описания
    /// </summary>
    /// <param name="plannedDescriptionText"></param>
    /// <returns></returns>
    (string description, string outputText) GetPlannedDescriptionMessage(string plannedDescriptionText);
}