using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations
{
    internal class LibraryBookConfiguration : IEntityTypeConfiguration<LibraryBook>
    {
        public void Configure(EntityTypeBuilder<LibraryBook> builder)
        {
            builder.Property(c => c.Library).IsRequired();
            builder.Property(c => c.Book).IsRequired();
            builder.HasKey(c => new {c.BookId, c.LibraryId});
            builder.HasOne(c => c.Library).WithMany(c => c.LibraryBooks).HasForeignKey(c => c.LibraryId);
            builder.HasOne(c => c.Book).WithMany(c => c.LibraryBooks).HasForeignKey(c => c.BookId);
        }
    }
}
