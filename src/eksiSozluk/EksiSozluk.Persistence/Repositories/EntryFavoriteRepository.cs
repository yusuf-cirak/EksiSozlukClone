using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EntryFavoriteRepository : EfRepositoryBase<EntryFavorite, BaseDbContext>, IEntryFavoriteRepository
{
    public EntryFavoriteRepository(BaseDbContext context) : base(context)
    {
    }
}