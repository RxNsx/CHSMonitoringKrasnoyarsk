namespace CHSMonitoring.Infrastructure.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Enum)]
public class EnumGuidAttribute : Attribute
{
    private Guid _value { get; set; }

    public EnumGuidAttribute(string guidString)
    {
        _value = new Guid(guidString);
    }
}