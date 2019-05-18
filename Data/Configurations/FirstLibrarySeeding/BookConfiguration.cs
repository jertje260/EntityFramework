using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations.FirstLibrarySeeding
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new[]
            {
                new Book
                {
                    Id = BookIds.BookId1,
                    AuthorId = AuthorIds.Author1,
                    Title = "My First Book"
                },
            });
        }
    }
}
