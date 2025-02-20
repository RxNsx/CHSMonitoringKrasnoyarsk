namespace CHSMonitoring.Infrastructure.Attributes;

/// <summary>
/// Аттрибут для хранения Id в виде Guid
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Enum)]
public class EnumGuidAttribute : Attribute
{
    public Guid GuidValue { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="guidString"></param>
    public EnumGuidAttribute(string guidString)
    {
        GuidValue = new Guid(guidString);
    }
}