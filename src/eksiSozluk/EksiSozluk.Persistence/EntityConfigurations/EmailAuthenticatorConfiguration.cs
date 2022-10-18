using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EmailAuthenticatorConfiguration : BaseConfiguration<EmailAuthenticator>
{
    public override void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        base.Configure(builder);

        builder.ToTable("EmailAuthenticators");

        builder.Property(ea => ea.UserId).HasColumnName("UserId");
        
        builder.Property(ea => ea.ActivationKey).HasColumnName("ActivationKey").HasColumnName("ActivationKey")
            .IsRequired(false);

        builder.Property(ea => ea.IsVerified).HasColumnName("IsVerified");

        builder.HasOne(ea => ea.User).WithOne().HasForeignKey<EmailAuthenticator>(ea => ea.UserId);
    }
}