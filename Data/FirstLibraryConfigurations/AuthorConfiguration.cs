using System;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.FirstLibraryConfigurations
{
    internal class AuthorConfiguration : BaseAuthorConfiguration
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder);
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
