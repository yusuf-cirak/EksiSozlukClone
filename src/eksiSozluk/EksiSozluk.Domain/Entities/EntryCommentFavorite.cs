using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Domain.Entities;

public class EntryCommentFavorite:Entity
{
    public int WriterId { get; set; }
    public int EntryCommentId { get; set; }
    public virtual EntryComment EntryComment { get; set; }
    public virtual Writer Writer { get; set; }
}