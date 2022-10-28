using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class RefreshTokenRepository:EfRepositoryBase<RefreshToken,BaseDbContext>,IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context) : base(context)
    {
    }
}