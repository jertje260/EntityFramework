using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations
{
    internal class BaseAuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public virtual void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.Books).WithOne(c => c.Author).HasForeignKey(c => c.AuthorId);
        }
    }
}
