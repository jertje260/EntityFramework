using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.FirstLibraryConfigurations
{
    internal class BookConfiguration : BaseBookConfiguration
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

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
