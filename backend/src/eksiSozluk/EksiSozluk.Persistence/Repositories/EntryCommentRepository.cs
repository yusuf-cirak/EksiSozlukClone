using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EntryCommentRepository : EfRepositoryBase<EntryComment, BaseDbContext>, IEntryCommentRepository
{
    public EntryCommentRepository(BaseDbContext context) : base(context)
    {
    }
}