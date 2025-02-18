using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация словаря типов профиля
/// </summary>
public class ProfileTypeConfigurations : IEntityTypeConfiguration<ProfileType>
{
    public void Configure(EntityTypeBuilder<ProfileType> builder)
    {
        builder.ToTable("profile_types", "dictionaries");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();
        
        builder.Property(x => x.IsReadOnly)
            .HasDefaultValue(true);
        
        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<ProfileType> builder)
    {
        var profileTypes = Enum.GetValues(typeof(ProfileTypeEnum))
            .Cast<ProfileTypeEnum>()
            .Select(x =>
            {
                return new ProfileType()
                {
                    Id = x.GetGuidValue(),
                    Name = x.GetDescriptionValue(),
                    IsReadOnly = true,
                };
            });

        builder.HasData(profileTypes);
    }
}