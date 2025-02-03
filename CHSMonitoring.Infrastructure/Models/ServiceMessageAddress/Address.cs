namespace CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

/// <summary>
/// Адрес
/// </summary>
public class Address
{
    /// <summary>
    /// Название улицы
    /// </summary>
    public string StreetName { get; private set; }
    
    /// <summary>
    /// Номер дома \ строение
    /// </summary>
    public string Number { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="number"></param>
    private Address(string streetName, string number)
    {
        StreetName = streetName;
        Number = number;
    }

    /// <summary>
    /// Фабричный метод создания информации по адресу отключения
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="number"></param>
    /// <returns></returns>
    public static Address Create(string streetName, string number)
    {
        return new Address(streetName, number);
    }
}