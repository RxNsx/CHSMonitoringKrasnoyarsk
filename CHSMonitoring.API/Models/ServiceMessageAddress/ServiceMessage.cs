namespace CHSMonitoring.API.Models.ServiceMessageAddress;

/// <summary>
/// Описание адресов с отключением
/// </summary>
public sealed class ServiceMessage
{
    public Organization Organization { get; private set; }
    public List<Address> AddressList { get; private set; }
    public string Description { get; private set; }
    public DateInfo DateInfo { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public ServiceMessage()
    {
        
    }

    /// <summary>
    /// Установить организацию
    /// </summary>
    /// <param name="organization"></param>
    public void SetOrganization(Organization organization) => Organization = organization;
    
    /// <summary>
    /// Установить адреса
    /// </summary>
    /// <param name="addressList"></param>
    public void SetAddressList(List<Address> addressList) => AddressList = addressList;
    
    /// <summary>
    /// Установить дополнительное описание проблемы
    /// </summary>
    /// <param name="description"></param>
    public void SetDescription(string description) => Description = description;
    
    /// <summary>
    /// Установить временные интервалы обслуживания 
    /// </summary>
    /// <param name="dateInfo"></param>
    public void SetDateInfo(DateInfo dateInfo) => DateInfo = dateInfo;
}