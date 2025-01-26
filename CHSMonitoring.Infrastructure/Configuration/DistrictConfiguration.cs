using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация словаря районов
/// </summary>
public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.ToTable("districts", "dictionaries");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<District> builder)
    {
        var districtList = new List<District>()
        {
            new() { Name = "Октябрьский район", Id = Guid.Parse("4d6d7a46-6d26-4e2f-be49-8f6040582049") },
            new() { Name = "Железнодорожный район", Id = Guid.Parse("8e68bf05-fcb5-4a9b-b75d-549a9aeb66b7") },
            new() { Name = "Центральный район", Id = Guid.Parse("3e93400d-d611-45e7-b4fc-fa3473859d11") },
            new() { Name = "Советский район", Id = Guid.Parse("dfbca6ca-a5cc-40a8-a411-f9c6220f563b") },
            new() { Name = "Ленинский район", Id = Guid.Parse("6b64b853-6ba2-407f-96c5-65c16e04ad98") },
            new() { Name = "Кировский район", Id = Guid.Parse("fb3418b0-0aee-4c9c-9b07-362247577ccb") },
            new() { Name = "Свердловский район", Id = Guid.Parse("f15b7e0d-2817-4fd6-813a-57af65304e1f") },
        };

        builder.HasData(districtList);
    }
}