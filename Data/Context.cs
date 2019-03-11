using System;
using System.Reflection;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class Context : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }

        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new LibraryConfiguration());


            // this is a EF 2.2 feature, should apply all configurations in a single assembly
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(Context)));
        }
    }
}
