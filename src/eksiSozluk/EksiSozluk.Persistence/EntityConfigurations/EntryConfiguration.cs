using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EntryConfiguration : BaseConfiguration<Entry>
{
    public override void Configure(EntityTypeBuilder<Entry> builder)
    {
        base.Configure(builder);

        builder.ToTable("Entries");


        builder.Property(e => e.WriterId).HasColumnName("WriterId");
        
        builder.Property(e => e.Subject).HasColumnName("Subject");
        
        builder.Property(e => e.Content).HasColumnName("Content");

        builder.HasOne(e => e.Writer).WithMany(w => w.Entries).HasForeignKey(e => e.WriterId).OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.EntryComments).WithOne(ec => ec.Entry).HasForeignKey(e => e.EntryId);

        builder.HasMany(e => e.EntryVotes).WithOne(ev => ev.Entry).HasForeignKey(ev => ev.EntryId);

        builder.HasMany(ef => ef.EntryFavorites).WithOne(ef => ef.Entry).HasForeignKey(ef => ef.EntryId);
    }
}