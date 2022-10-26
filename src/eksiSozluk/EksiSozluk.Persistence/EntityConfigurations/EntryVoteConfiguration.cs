using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EntryVoteConfiguration : BaseConfiguration<EntryVote>
{
    public override void Configure(EntityTypeBuilder<EntryVote> builder)
    {
        base.Configure(builder);

        builder.Property(ev => ev.EntryId).HasColumnName("EntryId");
        
        builder.Property(ev => ev.WriterId).HasColumnName("WriterId");

        builder.Property(ev => ev.IsUpVote).HasColumnName("IsUpVote");

        builder.HasOne(ev => ev.Entry).WithMany(e => e.EntryVotes).HasForeignKey(ev => ev.EntryId);

        builder.HasOne(ev => ev.Writer).WithMany(w => w.EntryVotes).HasForeignKey(ev => ev.WriterId).OnDelete(DeleteBehavior.Restrict);
    }
}