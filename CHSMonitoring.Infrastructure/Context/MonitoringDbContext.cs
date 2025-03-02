using System.Reflection;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;
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
    
    public virtual DbSet<ProfileType> ProfileTypes { get; set; }
    
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<ServiceAddress> ServiceAddresses { get; set; }
    
    public virtual DbSet<ServiceType> ServiceTypes { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Street> Streets { get; set; }
    
    public virtual DbSet<Subscription> Subscriptions { get; set; }

    /// <summary>
    /// Определение построения моделей
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging(false);
    }
}