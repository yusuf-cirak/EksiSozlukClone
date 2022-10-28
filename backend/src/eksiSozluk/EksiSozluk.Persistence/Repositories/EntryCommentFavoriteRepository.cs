using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EntryCommentFavoriteRepository : EfRepositoryBase<EntryCommentFavorite, BaseDbContext>, IEntryCommentFavoriteRepository
{
    public EntryCommentFavoriteRepository(BaseDbContext context) : base(context)
    {
    }
}