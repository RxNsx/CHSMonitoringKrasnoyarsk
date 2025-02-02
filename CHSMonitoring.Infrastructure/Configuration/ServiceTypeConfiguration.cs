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

        builder.Property(x => x.IsReadOnly)
            .HasDefaultValue(true);

        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<ServiceType> builder)
    {
        var serviceTypes = new List<ServiceType>()
        {
            new() { Name = "Пустой тип снабжения", Description = string.Empty, Id = Guid.Parse("DA945797-A35E-4F41-A63D-520FA11C213A") },
            new() { Name = "Теплоснабжение", Description = string.Empty, Id = Guid.Parse("93139275-C7D9-43F1-ABE3-E71259DF2E50") },
            new() { Name = "Холодное водоснабжение", Description = string.Empty, Id = Guid.Parse("4E96DE1C-1443-4148-8DA6-92BA3A95A828") },
            new() { Name = "Электроснабжение", Description = string.Empty, Id = Guid.Parse("25969C01-7291-458B-8A20-88A2338F62C9") }
        };
        
        builder.HasData(serviceTypes);
    }
}