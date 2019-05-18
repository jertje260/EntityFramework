using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations.SecondLibrarySeeding
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new[]
            {
                new Book
                {
                    Id = BookIds.BookId2,
                    AuthorId = AuthorIds.Author2,
                    Title = "My Second Book"
                },
            });
        }
    }
}
