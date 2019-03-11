using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configurations
{
    internal class LibraryConfiguration : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.LibraryBooks).WithOne(c=> c.Library).HasForeignKey(c=> c.LibraryId);
        }
    }
}
