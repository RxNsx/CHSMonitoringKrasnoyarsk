namespace CHSMonitoring.Infrastructure.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Enum)]
public class EnumGuidAttribute : Attribute
{
    public Guid GuidValue { get; private set; }

    public EnumGuidAttribute(string guidString)
    {
        GuidValue = new Guid(guidString);
    }
}