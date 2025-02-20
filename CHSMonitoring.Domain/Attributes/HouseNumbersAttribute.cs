namespace CHSMonitoring.Infrastructure.Attributes;

/// <summary>
/// Аттрибут для содержания списком номеров домов
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Enum)]
public class HouseNumbersAttribute : Attribute
{
    public List<string> Value { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="value"></param>
    public HouseNumbersAttribute(params string[] value)
    {
        Value = new List<string>(value);
    }
}