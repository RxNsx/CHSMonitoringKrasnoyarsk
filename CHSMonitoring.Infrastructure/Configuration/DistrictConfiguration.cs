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

        builder.Property(x => x.IsReadOnly)
            .HasDefaultValue(true);
        
        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<District> builder)
    {
        var districtList = new List<District>()
        {
            new() { Name = "Октябрьский район", Id = Guid.Parse("E137A377-6281-4074-BA80-E7460C328354") },
            new() { Name = "Железнодорожный район", Id = Guid.Parse("590B4A73-E859-4FFD-A544-23C5DD012760") },
            new() { Name = "Центральный район", Id = Guid.Parse("07432E9E-C030-4676-9CFE-438D8C76FFCF") },
            new() { Name = "Советский район", Id = Guid.Parse("1439FFC7-FE1E-4EFF-89B9-8ED6EF9DD323") },
            new() { Name = "Ленинский район", Id = Guid.Parse("EC99DB28-33A9-4526-B790-C4EDCB44955F") },
            new() { Name = "Кировский район", Id = Guid.Parse("215A4634-5671-49A3-8563-7B9A8E9DEA10") },
            new() { Name = "Свердловский район", Id = Guid.Parse("224359E3-827D-4C2D-95BE-E496418966E0") },
        };

        builder.HasData(districtList);
    }
}