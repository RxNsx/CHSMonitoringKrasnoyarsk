namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Адрес обслуживания
/// </summary>
public class ServiceAddress : Entity
{
    /// <summary>
    /// Название улицы
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Номер дома
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Описание проблемы
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Тип обслуживания (SupplyEnumType)
    /// </summary>
    public string ServiceType { get; set; }
    
    /// <summary>
    /// Дата начала отключения
    /// </summary>
    public DateTime From { get; set; }

    /// <summary>
    /// Дата начала отключения в формате строки (или сообщение об отключении)
    /// </summary>
    public string DateTimeFromString { get; set; }
    
    /// <summary>
    /// Дата окончания отключения
    /// </summary>
    public DateTime To { get; set; }
    
    /// <summary>
    /// Дата конца отключения в формате строки (или сообщение об отключении)
    /// </summary>
    public string DateTimeToString { get; set; }

    // /// <summary>
    // /// Конструктор
    // /// </summary>
    // /// <param name="name"></param>
    // /// <param name="number"></param>
    // /// <param name="description"></param>
    // /// <param name="from"></param>
    // /// <param name="dateTimeFromString"></param>
    // /// <param name="to"></param>
    // /// <param name="dateTimeToString"></param>
    // private ServiceAddress(string name, string number, string description, DateTime from, string dateTimeFromString, DateTime to, string dateTimeToString)
    // {
    //     Name = name;
    //     Number = number;
    //     Description = description;
    //     From = from;
    //     DateTimeFromString = dateTimeFromString;
    //     To = to;
    //     DateTimeToString = dateTimeToString;
    // }
    //
    // /// <summary>
    // /// Фабричный метод для создания
    // /// </summary>
    // /// <param name="name"></param>
    // /// <param name="number"></param>
    // /// <param name="description"></param>
    // /// <param name="from"></param>
    // /// <param name="dateTimeFromString"></param>
    // /// <param name="to"></param>
    // /// <param name="dateTimeToString"></param>
    // /// <returns></returns>
    // public static ServiceAddress Create(string name, string number, string description, DateTime from, string dateTimeFromString, DateTime to, string dateTimeToString)
    // {
    //     return new ServiceAddress(name, number, description, from, dateTimeFromString, to, dateTimeToString);
    // }
}