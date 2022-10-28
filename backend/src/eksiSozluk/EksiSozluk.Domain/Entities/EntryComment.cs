﻿using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Domain.Entities;

public class EntryComment:Entity
{
    public Guid WriterId { get; set; }
    public Guid EntryId { get; set; }
    public string Content { get; set; }
    public virtual Entry Entry { get; set; }
    public virtual Writer Writer { get; set; }

    public virtual ICollection<EntryCommentVote> EntryCommentVotes { get; set; }
    public virtual ICollection<EntryCommentFavorite> EntryCommentFavorites { get; set; }
}