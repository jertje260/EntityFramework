using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("ConnectionString") ?? "";

            var builder = new DbContextOptionsBuilder<DbContext>();

            builder
                .UseSqlServer(
                    connectionString,
                    opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(120).TotalSeconds));

            var context = new Context(builder.Options);

            context.Database.EnsureCreated();
            context.Database.Migrate();
        }
    }
}
