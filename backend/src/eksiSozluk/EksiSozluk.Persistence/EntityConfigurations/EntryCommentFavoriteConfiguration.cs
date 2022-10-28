using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EntryCommentFavoriteConfiguration : BaseConfiguration<EntryCommentFavorite>
{
    public override void Configure(EntityTypeBuilder<EntryCommentFavorite> builder)
    {
        base.Configure(builder);

        builder.Property(ecf => ecf.WriterId).HasColumnName("WriterId");

        builder.Property(ecf => ecf.EntryCommentId).HasColumnName("EntryCommentId");

        builder.HasOne(ecf => ecf.EntryComment).WithMany(ec => ec.EntryCommentFavorites)
            .HasForeignKey(ecf => ecf.EntryCommentId);

        builder.HasOne(ecf => ecf.Writer).WithMany(w => w.EntryCommentFavorites).HasForeignKey(ecf => ecf.WriterId).OnDelete(DeleteBehavior.Restrict);

    }
}