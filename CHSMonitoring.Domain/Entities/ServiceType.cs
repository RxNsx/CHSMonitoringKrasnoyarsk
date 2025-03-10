﻿using CHSMonitoring.Domain.Abstractions;

namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Тип обслуживания
/// </summary>
public class ServiceType : Entity
{
    /// <summary>
    /// Название типа обслуживания
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Признак только для чтения
    /// </summary>
    public bool IsReadOnly { get; set; }
    
    public List<ServiceAddress> ServiceAddresses { get; set; }
}