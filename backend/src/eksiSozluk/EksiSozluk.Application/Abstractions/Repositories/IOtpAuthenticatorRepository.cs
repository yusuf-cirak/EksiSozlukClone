﻿using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Application.Abstractions.Repositories;

public interface IOtpAuthenticatorRepository:IAsyncRepository<OtpAuthenticator>
{
    
}