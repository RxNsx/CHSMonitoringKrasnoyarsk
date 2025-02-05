using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация адреса обслуживания
/// </summary>
public class ServiceAddressConfiguration : IEntityTypeConfiguration<ServiceAddress>
{
    public void Configure(EntityTypeBuilder<ServiceAddress> builder)
    {
        builder.ToTable("service_addresses", "services");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.StreetId)
            .HasDefaultValue(null)
            .IsRequired(false);
            
        builder.Property(x => x.DistrictId)
            .IsRequired();
    
        builder.Property(x => x.ServiceTypeId)
            .IsRequired();
        
        builder.Property(x => x.StreetName)
            .HasMaxLength(150)
            .HasDefaultValue(string.Empty)
            .IsRequired();
        
        builder.Property(x => x.HouseNumber)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasDefaultValue(string.Empty)
            .IsRequired(false);

        builder.Property(x => x.From)
            .HasConversion(x => x!.Value.ToUniversalTime(), x => DateTime.SpecifyKind(x, DateTimeKind.Utc))
            .IsRequired(false)
            .HasDefaultValue(null);

        builder.Property(x => x.To)
            .HasConversion(x => x!.Value.ToUniversalTime(), x => DateTime.SpecifyKind(x, DateTimeKind.Utc))
            .IsRequired(false)
            .HasDefaultValue(null);
        
        builder.Property(x => x.DateTimeFromString)
            .HasDefaultValue(string.Empty);

        builder.Property(x => x.DateTimeToString)
            .HasDefaultValue(string.Empty);

        builder.Property(x => x.CreatedDate)
            .HasConversion(x => x.ToUniversalTime(), x => DateTime.SpecifyKind(x, DateTimeKind.Utc))
            .IsRequired();

        builder.Property(x => x.IsReadOnly)
            .HasDefaultValue(true);

        builder.HasOne(x => x.District)
            .WithMany(x => x.ServiceAddresses)
            .IsRequired(false);

        builder.HasOne(x => x.Street)
            .WithMany(x => x.ServiceAddresses)
            .IsRequired(false);

        builder.HasOne(x => x.ServiceType)
            .WithMany(x => x.ServiceAddresses)
            .IsRequired(false);
    }
}