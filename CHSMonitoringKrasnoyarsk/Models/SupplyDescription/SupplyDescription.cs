namespace CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

/// <summary>
/// Описание адресов с отключением
/// </summary>
public class SupplyDescription
{
    public Organization Organization { get; set; }
    public List<Address> AddressList { get; set; }
    public string Description { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    
    private SupplyDescription(Organization organization, List<Address> addressList, string description, DateTime from, DateTime to)
    {
        Organization = organization;
        AddressList = addressList;
        Description = description;
        From = from;
        To = to;
    }
    
    public static SupplyDescription Create(Organization organization, List<Address> addressList, string description, DateTime from, DateTime to)
    {
        return new SupplyDescription(organization, addressList, description, from, to);
    }
}