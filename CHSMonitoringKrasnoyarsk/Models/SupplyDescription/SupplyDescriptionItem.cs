namespace CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

/// <summary>
/// Описание адресов с отключением
/// </summary>
public class SupplyDescriptionItem
{
    public Organization Organization { get; set; }
    public List<TableDescription> AddressList { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    
    private SupplyDescriptionItem(Organization organization, List<TableDescription> addressList, DateTime from, DateTime to)
    {
        Organization = organization;
        AddressList = addressList;
        From = from;
        To = to;
    }
    
    public static SupplyDescriptionItem Create(Organization organization, List<TableDescription> addressList, DateTime from, DateTime to)
    {
        return new SupplyDescriptionItem(organization, addressList, from, to);
    }
}