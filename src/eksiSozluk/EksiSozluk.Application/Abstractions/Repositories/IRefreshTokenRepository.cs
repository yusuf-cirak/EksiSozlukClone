using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Application.Abstractions.Repositories;

public interface IRefreshTokenRepository:IAsyncRepository<RefreshToken>,IRepository<RefreshToken>
{
    
}