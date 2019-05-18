using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Data
{
    internal class SecondLibraryContextFactory : IDesignTimeDbContextFactory<SecondLibraryContext>
    {
        public SecondLibraryContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SecondLibraryContext>();

            builder.UseSqlServer("Second_Library");

            return new SecondLibraryContext(builder.Options);
        }
    }
}
