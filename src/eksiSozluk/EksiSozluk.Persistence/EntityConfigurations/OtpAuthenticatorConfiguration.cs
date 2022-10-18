using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class OtpAuthenticatorConfiguration : BaseConfiguration<OtpAuthenticator>
{
    public override void Configure(EntityTypeBuilder<OtpAuthenticator> builder)
    {
        base.Configure(builder);

        builder.ToTable("OtpAuthenticators");

        builder.Property(oa => oa.UserId).HasColumnName("UserId");

        builder.Property(oa => oa.SecretKey).HasColumnName("SecretKey");

        builder.Property(oa => oa.IsVerified).HasColumnName("IsVerified");

        builder.HasOne(oa => oa.User).WithOne().HasForeignKey<OtpAuthenticator>(oa => oa.UserId);
    }
}