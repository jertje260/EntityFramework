using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations.FirstLibrarySeeding
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
                        Id = AuthorIds.Author1,
                        Name = "Author1"
                    },
                });
        }
    }
}
