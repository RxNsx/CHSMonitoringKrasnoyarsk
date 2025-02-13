using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация пользователя
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users", "admin");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.UserName)
            .IsRequired();
        
        builder.Property(x => x.LoginName)
            .IsRequired();

        builder.Property(x => x.Password)
            .IsRequired();

        builder.Property(x => x.EmailAddress)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(150)
            .IsRequired(false);

        builder.HasMany(x => x.Profiles)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.Roles)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);
    }
}