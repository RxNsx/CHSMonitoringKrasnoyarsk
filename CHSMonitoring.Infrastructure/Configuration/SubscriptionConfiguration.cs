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

        builder.HasOne(x => x.User)
            .WithOne(x => x.Subscription);
        
        builder.HasOne(x => x.User)
            .WithOne(x => x.Subscription)
            .HasForeignKey<Subscription>(x => x.UserId);
    }
}