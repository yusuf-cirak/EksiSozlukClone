using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class UserOperationClaimConfiguration : BaseConfiguration<UserOperationClaim>
{
    public override void Configure(EntityTypeBuilder<UserOperationClaim> builder)
    {
        base.Configure(builder);

        builder.ToTable("UserOperationClaims");

        builder.Property(uop => uop.UserId).HasColumnName("UserId");
        
        builder.Property(uop => uop.OperationClaimId).HasColumnName("OperationClaimId");

        builder.HasOne(uop => uop.User).WithMany(u=>u.UserOperationClaims).HasForeignKey(uop => uop.UserId);
        
        builder.HasOne(uop => uop.OperationClaim).WithOne().HasForeignKey<UserOperationClaim>(uop => uop.OperationClaimId);

    }
}