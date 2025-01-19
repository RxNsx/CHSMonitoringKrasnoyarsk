using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Context;

public class MonitoringDbContext : DbContext
{
    public MonitoringDbContext(DbContextOptions<MonitoringDbContext> options) : base(options)
    {
        
    }

    public virtual DbSet<District> Type { get; set; }
    
    public virtual DbSet<Permission> Permissions { get; set; }
    
    public virtual DbSet<PlannedServiceType> PlannedServiceTypes { get; set; }
    
    public virtual DbSet<Profile> Profiles { get; set; }
    
    public virtual DbSet<Role> Roles { get; set; }
    
    public virtual DbSet<ServiceAddress> ServiceAddresses { get; set; }
    
    public virtual DbSet<ServiceType> ServiceTypes { get; set; }
    
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}