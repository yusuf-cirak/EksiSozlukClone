using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class OperationClaimConfiguration:BaseConfiguration<OperationClaim>
{
    public override void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        base.Configure(builder);

        builder.ToTable("OperationClaims");

        builder.Property(o => o.Name).HasColumnName("Name");
    }
}