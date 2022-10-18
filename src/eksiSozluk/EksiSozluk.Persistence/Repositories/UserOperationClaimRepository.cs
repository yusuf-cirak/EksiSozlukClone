using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class UserOperationClaimRepository:EfRepositoryBase<UserOperationClaim,BaseDbContext>,IUserOperationClaimRepository
{
    public UserOperationClaimRepository(BaseDbContext context) : base(context)
    {
    }
}