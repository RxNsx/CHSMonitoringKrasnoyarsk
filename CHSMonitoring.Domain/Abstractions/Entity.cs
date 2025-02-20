namespace CHSMonitoring.Domain.Abstractions;

/// <summary>
/// Абстракция сущности базы данных
/// </summary>
public abstract class Entity
{
    public Guid Id { get; set; }
}