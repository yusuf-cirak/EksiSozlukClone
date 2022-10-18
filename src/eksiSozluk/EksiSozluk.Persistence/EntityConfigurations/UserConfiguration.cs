using Core.Security.Entities;
using Core.Security.Enums;
using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class UserConfiguration:BaseConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("Users");

        builder.Property(u => u.UserName).HasColumnName("UserName");

        builder.Property(u => u.Email).HasColumnName("Email");

        builder.Property(u => u.PasswordSalt).HasColumnName("PasswordSalt");

        builder.Property(u => u.PasswordHash).HasColumnName("PasswordHash");

        builder.Property(u => u.Status).HasColumnName("Status");

        builder.Property(u => u.AuthenticatorType).HasColumnName("AuthenticatorType");


        builder.HasMany(u => u.UserOperationClaims).WithOne(uop => uop.User).HasForeignKey(uop => uop.UserId);

        builder.HasMany(u => u.RefreshTokens).WithOne(rt => rt.User).HasForeignKey(rt => rt.UserId);
    }
}