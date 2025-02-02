using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

public class StreetConfiguration : IEntityTypeConfiguration<Street>
{
    public void Configure(EntityTypeBuilder<Street> builder)
    {
        builder.ToTable("streets", "dictionaries");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(150);

        builder.Property(x => x.Description)
            .HasMaxLength(150)
            .HasDefaultValue(string.Empty);
        
        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<Street> builder)
    {
        var streetEnums = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => new Street
            {
                Id = x.GetGuidValue(),
                Name = x.GetDescriptionValue(),
            })
            .ToList();
        
        builder.HasData(streetEnums);
    }
}