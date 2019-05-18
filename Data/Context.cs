using System;
using System.Reflection;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public abstract class Context : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected Context(DbContextOptions options) : base(options) { }

    }
}
