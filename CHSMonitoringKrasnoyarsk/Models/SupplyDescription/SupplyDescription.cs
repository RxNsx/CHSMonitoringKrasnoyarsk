namespace CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

/// <summary>
/// Описание адресов с отключением
/// </summary>
public class SupplyDescription
{
    public Organization Organization { get; private set; }
    public List<Address> AddressList { get; private set; }
    public string Description { get; private set; }
    public DateInfo DateInfo { get; private set; }
    
    private SupplyDescription(Organization organization, List<Address> addressList, string description, DateInfo dateInfo)
    {
        Organization = organization;
        AddressList = addressList;
        Description = description;
        DateInfo = dateInfo;
    }
    
    public static SupplyDescription Create(Organization organization, List<Address> addressList, string description, DateInfo dateInfo)
    {
        return new SupplyDescription(organization, addressList, description, dateInfo);
    }
}