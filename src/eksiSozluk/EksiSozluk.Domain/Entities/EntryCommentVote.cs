using Core.Persistence.Repositories;
using Core.Security.Entities;
using EksiSozluk.Domain.Enums;

namespace EksiSozluk.Domain.Entities;

public class EntryCommentVote:Entity
{
    public Guid WriterId { get; set; }
    public Guid EntryCommentId { get; set; }
    public virtual EntryComment EntryComment { get; set; }
    public virtual Writer Writer { get; set; }
    public VoteType VoteType { get; set; }
}