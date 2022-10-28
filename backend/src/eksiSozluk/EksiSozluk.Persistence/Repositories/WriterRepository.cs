using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Domain.Entities;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class WriterRepository:EfRepositoryBase<Writer,BaseDbContext>,IWriterRepository
{
    public WriterRepository(BaseDbContext context) : base(context)
    {
    }
}