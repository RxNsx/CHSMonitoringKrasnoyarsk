using System.Reflection;
using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Context;

/// <summary>
/// Контекст базы данных
/// </summary>
public class MonitoringDbContext : DbContext
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="options"></param>
    public MonitoringDbContext(DbContextOptions<MonitoringDbContext> options) : base(options)
    {
        
    }

    public virtual DbSet<District> Districts { get; set; }
    
    public virtual DbSet<Permission> Permissions { get; set; }
    
    public virtual DbSet<PlannedServiceType> PlannedServiceTypes { get; set; }
    
    public virtual DbSet<Profile> Profiles { get; set; }
    
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<ServiceAddress> ServiceAddresses { get; set; }
    
    public virtual DbSet<ServiceType> ServiceTypes { get; set; }
    
    public virtual DbSet<User> Users { get; set; }

    /// <summary>
    /// Определение построения моделей
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}