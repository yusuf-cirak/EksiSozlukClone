using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class EntryCommentVoteConfiguration : BaseConfiguration<EntryCommentVote>
{
    public override void Configure(EntityTypeBuilder<EntryCommentVote> builder)
    {
        base.Configure(builder);

        builder.Property(ecv => ecv.WriterId).HasColumnName("WriterId");
        
        builder.Property(ecv => ecv.EntryCommentId).HasColumnName("EntryCommentId");

        builder.Property(ecv => ecv.VoteType).HasColumnName("VoteType");


        builder.HasOne(ecv => ecv.EntryComment).WithMany(ec => ec.EntryCommentVotes)
            .HasForeignKey(ecv => ecv.EntryCommentId);

        builder.HasOne(ecv => ecv.Writer).WithMany(w => w.EntryCommentVotes).HasForeignKey(ecv => ecv.WriterId).OnDelete(DeleteBehavior.Restrict);

    }
}