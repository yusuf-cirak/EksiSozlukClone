using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EntryCommentConfiguration : BaseConfiguration<EntryComment>
{
    public override void Configure(EntityTypeBuilder<EntryComment> builder)
    {
        base.Configure(builder);

        builder.ToTable("EntryComments");

        builder.Property(ec => ec.WriterId).HasColumnName("WriterId");
        
        builder.Property(ec => ec.EntryId).HasColumnName("EntryId");

        builder.Property(ec => ec.Content).HasColumnName("Content");

        builder.HasOne(ec => ec.Entry).WithMany(e => e.EntryComments).HasForeignKey(ec => ec.EntryId);

        builder.HasOne(ec => ec.Writer).WithMany(w => w.EntryComments).HasForeignKey(ec => ec.WriterId).OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(ec => ec.EntryCommentVotes).WithOne(ec => ec.EntryComment)
            .HasForeignKey(ec => ec.EntryCommentId);

        builder.HasMany(ec => ec.EntryCommentFavorites).WithOne(ecf => ecf.EntryComment)
            .HasForeignKey(ec => ec.EntryCommentId);
        
    }
}