namespace CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

/// <summary>
/// Описание адресов с отключением
/// </summary>
public class SupplyDescriptionItem
{
    public Organization Organization { get; set; }
    public List<TableDescription> AddressList { get; set; }
    public string Description { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    
    private SupplyDescriptionItem(Organization organization, List<TableDescription> addressList, string description, DateTime from, DateTime to)
    {
        Organization = organization;
        AddressList = addressList;
        Description = description;
        From = from;
        To = to;
    }
    
    public static SupplyDescriptionItem Create(Organization organization, List<TableDescription> addressList, string description, DateTime from, DateTime to)
    {
        return new SupplyDescriptionItem(organization, addressList, description, from, to);
    }
}