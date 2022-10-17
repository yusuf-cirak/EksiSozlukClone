using Core.Security.Entities;
using Core.Security.Enums;

namespace EksiSozluk.Domain.Entities;

public class Writer:User
{
    public virtual ICollection<Entry> Entries { get; set; }
    public virtual ICollection<EntryComment> EntryComments { get; set; }

    public virtual ICollection<EntryFavorite> EntryFavorites { get; set; }
    public virtual ICollection<EntryCommentFavorite> EntryCommentFavorites { get; set; }

    public Writer()
    {
        
    }
    
    public Writer(int id, string firstName, string lastName, string email, byte[] passwordSalt, byte[] passwordHash,
        bool status, AuthenticatorType authenticatorType) : this()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
    }
    
    

}