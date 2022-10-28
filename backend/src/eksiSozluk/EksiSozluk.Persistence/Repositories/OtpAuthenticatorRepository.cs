using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class OtpAuthenticatorRepository : EfRepositoryBase<OtpAuthenticator, BaseDbContext>,IOtpAuthenticatorRepository
{
    public OtpAuthenticatorRepository(BaseDbContext context) : base(context)
    {
    }
}