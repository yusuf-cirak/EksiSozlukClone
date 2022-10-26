using Core.Security.Entities;
using Core.Security.Enums;

namespace EksiSozluk.Domain.Entities;

public class Writer:User
{
    public virtual ICollection<Entry> Entries { get; set; }
    public virtual ICollection<EntryComment> EntryComments { get; set; }

    public virtual ICollection<EntryFavorite> EntryFavorites { get; set; }
    
    public virtual ICollection<EntryVote> EntryVotes { get; set; }

    public virtual ICollection<EntryCommentFavorite> EntryCommentFavorites { get; set; }

    public virtual ICollection<EntryCommentVote> EntryCommentVotes { get; set; }

    public Writer()
    {
        
    }
    
    public Writer(Guid id,string userName,string email, byte[] passwordSalt, byte[] passwordHash,
        bool status, AuthenticatorType authenticatorType) : base(id,userName,email,passwordSalt,passwordHash, status, authenticatorType)
    {
        Id = id;
        UserName = userName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
    }
    
    

}