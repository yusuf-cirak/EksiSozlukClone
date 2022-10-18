using System.Reflection;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EksiSozluk.Persistence.Contexts;

public sealed class BaseDbContext:DbContext
{
    protected IConfiguration Configuration { get; }

    // Security
    public DbSet<User> Users { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }
    public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }

    public DbSet<Entry> Entries { get; set; }
    public DbSet<EntryVote> EntryVotes { get; set; }
    public DbSet<EntryFavorite> EntryFavorites { get; set; }
    
    public DbSet<EntryComment> EntryComments { get; set; }
    public DbSet<EntryCommentFavorite> EntryCommentFavorites { get; set; }
    public DbSet<EntryCommentVote> EntryCommentVotes { get; set; }

    public BaseDbContext(DbContextOptions options,IConfiguration configuration):base(options)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {

        var datas = ChangeTracker.Entries<Entity>();
        foreach (var data in datas)
        {
            _ = data.State switch //
            {
                EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                EntityState.Modified => data.Entity.CreatedDate = DateTime.UtcNow,
                _ => DateTime.UtcNow //
            };
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}