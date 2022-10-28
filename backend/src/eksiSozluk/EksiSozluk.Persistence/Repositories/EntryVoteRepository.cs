using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EntryVoteRepository : EfRepositoryBase<EntryVote, BaseDbContext>, IEntryVoteRepository
{
    public EntryVoteRepository(BaseDbContext context) : base(context)
    {
    }
}