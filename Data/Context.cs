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
        public Context() {}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                base.OnConfiguring(options);
                var connectionString = "Some bogus connectionString";

                options
                    .UseSqlServer(
                        connectionString,
                        opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(120).TotalSeconds));
            }
            else
            {
                base.OnConfiguring(options);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new LibraryConfiguration());
            modelBuilder.ApplyConfiguration(new LibraryBookConfiguration());


            // this is a EF 2.2 feature, should apply all configurations in a single assembly
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(Context)));
        }
    }
}
