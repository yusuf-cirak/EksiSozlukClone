using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EntryFavoritesConfiguration : BaseConfiguration<EntryFavorite>
{
    public override void Configure(EntityTypeBuilder<EntryFavorite> builder)
    {
        base.Configure(builder);

        builder.Property(ef => ef.WriterId).HasColumnName("WriterId");
        builder.Property(ef => ef.EntryId).HasColumnName("EntryId");

        builder.HasOne(ef => ef.Entry).WithMany(e => e.EntryFavorites).HasForeignKey(ef => ef.EntryId);

        builder.HasOne(ef => ef.Writer).WithMany(w => w.EntryFavorites).HasForeignKey(ef => ef.WriterId).OnDelete(DeleteBehavior.Restrict);
    }
}