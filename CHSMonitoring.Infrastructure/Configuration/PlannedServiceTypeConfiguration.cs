using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация словаря типов запланированных обслуживаний
/// </summary>
public class PlannedServiceTypeConfiguration : IEntityTypeConfiguration<PlannedServiceType>
{
    public void Configure(EntityTypeBuilder<PlannedServiceType> builder)
    {
        builder.ToTable("planned_service_types", "dictionaries");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(x => x.Description)
            .HasDefaultValue(string.Empty)
            .HasMaxLength(150);
    }
}