using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.LibraryBooks).WithOne(c => c.Book).HasForeignKey(c => c.BookId);

            builder.HasData(new [] {
                new Book{
                    AuthorId = 1,
                    Id = 1,
                    Title = "First Book"
                },
                new Book{
                    AuthorId = 2,
                    Id = 2,
                    Title = "Second Book"
                }
            });
        }
    }
}
