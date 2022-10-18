using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;
using EksiSozluk.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EksiSozluk.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("EksiSozlukSqlServer"), sqlOpt =>
            {
                sqlOpt.EnableRetryOnFailure();
            });
        });


        services.AddScoped<IEmailAuthenticatorRepository,EmailAuthenticatorRepository>();
        services.AddScoped<IOperationClaimRepository,OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository,OtpAuthenticatorRepository>();
        services.AddScoped<IRefreshTokenRepository,RefreshTokenRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();

        services.AddScoped<IEntryRepository,EntryRepository>();
        services.AddScoped<IEntryCommentRepository, EntryCommentRepository>();
        services.AddScoped<IEntryCommentFavoriteRepository, EntryCommentFavoriteRepository>();
        services.AddScoped<IEntryCommentVoteRepository,EntryCommentVoteRepository>();
        services.AddScoped<IEntryFavoriteRepository,EntryFavoriteRepository>();
        services.AddScoped<IEntryVoteRepository,EntryVoteRepository>();

        services.AddScoped<IWriterRepository, WriterRepository>();
        
        return services;



        


    }
}