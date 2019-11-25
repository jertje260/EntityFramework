using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.Books).WithOne(c => c.Author).HasForeignKey(c => c.AuthorId);

            builder.HasData(new Author[] {
                new Author {
                    Id = 1,
                    Name = "author1"
                },
                new Author {
                    Id = 2,
                    Name = "author2"
                }
            });
        }
    }
}
