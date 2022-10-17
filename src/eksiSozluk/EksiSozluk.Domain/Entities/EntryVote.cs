using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Domain.Enums;

namespace EksiSozluk.Domain.Entities;

public class EntryVote:Entity
{
    public Guid EntryId { get; set; }
    public Guid WriterId { get; set; }
    public VoteType VoteType { get; set; }
    public virtual Entry Entry { get; set; }
    public virtual Writer Writer { get; set; }
}