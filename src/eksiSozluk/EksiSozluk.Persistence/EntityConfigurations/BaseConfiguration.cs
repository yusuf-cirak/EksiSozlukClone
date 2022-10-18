using System.Globalization;
using Core.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EksiSozluk.Persistence.EntityConfigurations;

public abstract class BaseConfiguration<T>:IEntityTypeConfiguration<T> where T:Entity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("Id");

        builder.Property(e => e.CreatedDate).HasColumnName("CreatedDate");

        builder.Property(e => e.UpdatedDate).HasColumnName("UpdatedDate").HasDefaultValue(DateTime.MinValue.ToString(CultureInfo.CurrentCulture));
    }
}