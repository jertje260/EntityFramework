using System;
using System.Collections.Generic;
using System.Text;
using Data.SecondLibraryConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class SecondLibraryContext : Context
    {
        public SecondLibraryContext(DbContextOptions<SecondLibraryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());


            // this is a EF 2.2 feature, should apply all configurations in a single assembly
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(Context)));
        }
    }
}
