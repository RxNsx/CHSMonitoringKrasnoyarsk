namespace CHSMonitoring.Infrastructure.Attributes;

public class HouseNumbersAttribute : Attribute
{
    public List<string> Value { get; private set; }

    public HouseNumbersAttribute(params string[] value)
    {
        Value = new List<string>(value);
    }
}