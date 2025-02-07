namespace CHSMonitoring.Infrastructure.Attributes;

public class HouseNumbersAttribute : Attribute
{
    public string[] Value { get; private set; }

    public HouseNumbersAttribute(string[] value)
    {
        Value = value;
    }
}