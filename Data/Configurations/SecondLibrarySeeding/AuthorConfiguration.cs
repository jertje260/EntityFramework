using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations.SecondLibrarySeeding
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new[]
                {
                    new Author()
                    {
                        Id = AuthorIds.Author2,
                        Name = "Author2"
                    },
                });
        }
    }
}
