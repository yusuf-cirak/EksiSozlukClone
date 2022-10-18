using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;

namespace EksiSozluk.Persistence.EntityConfigurations;

public sealed class WriterConfiguration:BaseConfiguration<Writer>
{
    public override void Configure(EntityTypeBuilder<Writer> builder)
    {
        // base.Configure(builder);
        // If root type has its entity configurations derived types does not need it
        // See User model and UserConfiguration
        builder.ToTable("Writers");

        builder.HasMany(w => w.Entries).WithOne(e => e.Writer).HasForeignKey(e => e.WriterId);
        
        builder.HasMany(w => w.EntryFavorites).WithOne(ef => ef.Writer).HasForeignKey(ef => ef.WriterId);
        
        builder.HasMany(w => w.EntryVotes).WithOne(ev => ev.Writer).HasForeignKey(ev => ev.WriterId);
        
        builder.HasMany(w => w.EntryCommentFavorites).WithOne(ecf => ecf.Writer).HasForeignKey(ecf => ecf.WriterId);
        
        builder.HasMany(w => w.EntryComments).WithOne(ec => ec.Writer).HasForeignKey(ec => ec.WriterId);
        
        builder.HasMany(w => w.EntryCommentVotes).WithOne(ecv => ecv.Writer).HasForeignKey(ecv => ecv.WriterId);
    }
}