using System;
using System.Collections.Generic;
using System.Text;
using Data.Configurations.FirstLibrarySeeding;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class FirstLibraryContext : Context
    {
        public FirstLibraryContext(DbContextOptions<FirstLibraryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());

            base.OnModelCreating(modelBuilder);





            // this is a EF 2.2 feature, should apply all configurations in a single assembly
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(Context)));
        }
    }
}
