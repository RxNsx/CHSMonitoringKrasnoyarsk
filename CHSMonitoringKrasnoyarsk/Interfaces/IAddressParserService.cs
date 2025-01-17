using CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

namespace CHSMonitoringKrasnoyarsk.Interfaces;

public interface IAddressParserService
{
    List<Address> ParseAddresses(List<string> addresses);
}