using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EntryRepository : EfRepositoryBase<Entry, BaseDbContext>, IEntryRepository
{
    public EntryRepository(BaseDbContext context) : base(context)
    {
    }
}