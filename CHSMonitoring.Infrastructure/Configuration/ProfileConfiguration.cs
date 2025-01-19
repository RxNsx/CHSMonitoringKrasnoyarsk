using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация профиля
/// </summary>
public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable("profiles","admin");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Street)
            .HasMaxLength(150);

        builder.Property(x => x.HouseNumber)
            .HasMaxLength(30);
        
        builder.Property(x => x.UserId)
            .IsRequired();
    }
}