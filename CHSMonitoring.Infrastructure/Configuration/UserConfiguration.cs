using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

/// <summary>
/// Конфигурация пользователя
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    /// <summary>
    /// Конфигурация аттрибутов пользователя
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users", "admin");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.UserName)
            .IsRequired();

        builder.Property(x => x.EmailAddress)
            .IsRequired();
        
        builder.HasIndex(x => x.EmailAddress)
            .IsUnique();

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