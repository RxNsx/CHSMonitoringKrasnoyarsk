using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация типа сервиса
/// </summary>
public class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceType>
{
    public void Configure(EntityTypeBuilder<ServiceType> builder)
    {
        builder.ToTable("service_types", "dictionaries");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasDefaultValue(string.Empty)
            .HasMaxLength(150);

        builder.Property(x => x.IsReadOnly)
            .HasDefaultValue(true);

        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<ServiceType> builder)
    {
        var serviceTypes = Enum.GetValues(typeof(ServiceTypeEnum))
            .Cast<ServiceTypeEnum>()
            .Select(x => new ServiceType
            {
                Id = x.GetGuidValue(),
                Name = x.GetDescriptionValue(),
            })
            .ToList();
        
        builder.HasData(serviceTypes);
    }
}