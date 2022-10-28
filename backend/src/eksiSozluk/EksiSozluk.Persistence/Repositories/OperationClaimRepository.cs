using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class OperationClaimRepository:EfRepositoryBase<OperationClaim,BaseDbContext>,IOperationClaimRepository
{
    public OperationClaimRepository(BaseDbContext context) : base(context)
    {
    }
}