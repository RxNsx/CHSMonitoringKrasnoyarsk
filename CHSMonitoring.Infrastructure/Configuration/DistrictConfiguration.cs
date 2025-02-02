using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
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
        var districtList = Enum.GetValues(typeof(DistrictEnum))
            .Cast<DistrictEnum>()
            .Select(x => new District
            {
                Id = x.GetGuidValue(),
                Name = x.GetDescriptionValue(),
            })
            .ToList();

        builder.HasData(districtList);
    }
}