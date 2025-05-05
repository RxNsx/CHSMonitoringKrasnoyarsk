using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.ToTable("subscriptions", "admin");

        builder.Property(x => x.UpdateUserTime)
            .IsRequired();

        builder.Property(x => x.StreetId)
            .HasDefaultValue(null)
            .IsRequired(false);
    }
}