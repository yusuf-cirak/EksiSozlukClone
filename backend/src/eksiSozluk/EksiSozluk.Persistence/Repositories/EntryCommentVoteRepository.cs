using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EntryCommentVoteRepository : EfRepositoryBase<EntryCommentVote, BaseDbContext>, IEntryCommentVoteRepository
{
    public EntryCommentVoteRepository(BaseDbContext context) : base(context)
    {
    }
}