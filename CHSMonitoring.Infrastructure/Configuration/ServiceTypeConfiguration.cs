using CHSMonitoring.Domain.Entities;
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

        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<ServiceType> builder)
    {
        var serviceTypes = new List<ServiceType>()
        {
            new() { Name = "Теплоснабжение", Description = string.Empty, Id = Guid.Parse("913164af-4599-434f-8145-72f2bf937566") },
            new() { Name = "Холодное водоснабжение", Description = string.Empty, Id = Guid.Parse("9c5ab80d-64d3-4cf4-81d0-751aa37624f9") },
            new() { Name = "Электроснабжение", Description = string.Empty, Id = Guid.Parse("47e046c3-a591-4f17-ac64-061a337270cf") }
        };
        
        builder.HasData(serviceTypes);
    }
}