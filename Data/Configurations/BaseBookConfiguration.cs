using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations
{
    internal class BaseBookConfiguration : IEntityTypeConfiguration<Book>
    {
        public virtual void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AuthorId).IsRequired();
        }
    }
}
