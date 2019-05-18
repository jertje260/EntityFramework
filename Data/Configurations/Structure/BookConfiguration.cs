using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations.Structure
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public virtual void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AuthorId).IsRequired();
        }
    }
}
