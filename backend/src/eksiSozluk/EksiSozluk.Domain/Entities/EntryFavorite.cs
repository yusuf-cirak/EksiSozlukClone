using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Domain.Entities;

public class EntryFavorite:Entity
{
    public Guid EntryId { get; set; }
    public Guid WriterId { get; set; }
    public virtual Entry Entry { get; set; }
    public virtual Writer Writer { get; set; }
}