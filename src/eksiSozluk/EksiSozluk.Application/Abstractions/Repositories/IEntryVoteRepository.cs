﻿using Core.Persistence.Repositories;
using EksiSozluk.Domain.Entities;

namespace EksiSozluk.Application.Abstractions.Repositories;

public interface IEntryVoteRepository:IAsyncRepository<EntryVote>
{
    
}