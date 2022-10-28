using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;

namespace EksiSozluk.Persistence.Repositories;

public sealed class EmailAuthenticatorRepository:EfRepositoryBase<EmailAuthenticator,BaseDbContext>,IEmailAuthenticatorRepository
{
    public EmailAuthenticatorRepository(BaseDbContext context) : base(context)
    {
    }
}