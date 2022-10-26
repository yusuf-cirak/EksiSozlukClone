using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Domain.Entities;

public class Entry:Entity
{
    public Guid WriterId { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

    public virtual Writer Writer { get; set; }

    public virtual ICollection<EntryComment> EntryComments { get; set; }
    public virtual ICollection<EntryVote> EntryVotes { get; set; }
    public virtual ICollection<EntryFavorite> EntryFavorites { get; set; }
}