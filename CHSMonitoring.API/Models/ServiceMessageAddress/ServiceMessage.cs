namespace CHSMonitoring.API.Models.ServiceMessageAddress;

/// <summary>
/// Описание адресов с отключением
/// </summary>
public sealed class ServiceMessage
{
    /// <summary>
    /// Организация обслуживающая отключение
    /// </summary>
    public Organization Organization { get; private set; }
    /// <summary>
    /// Список адресов обслуживания
    /// </summary>
    public List<Address> AddressList { get; private set; }
    /// <summary>
    /// Дополнительное описание события
    /// </summary>
    public string Description { get; private set; }
    /// <summary>
    /// Информация по интервалу разрешения ситуации
    /// </summary>
    public DateInfo DateInfo { get; private set; }
    /// <summary>
    /// Дата создания сообщения обслуживания
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public ServiceMessage()
    {
        CreatedDate = DateTime.UtcNow;
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