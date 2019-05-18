using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data
{
    internal class FirstLibraryContextFactory : IDesignTimeDbContextFactory<FirstLibraryContext>
    {
        public FirstLibraryContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FirstLibraryContext>();

            builder.UseSqlServer("First_Library");

            return new FirstLibraryContext(builder.Options);
        }
    }
}
