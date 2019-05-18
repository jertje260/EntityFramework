using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.SecondLibraryConfigurations
{
    internal class BookConfiguration : BaseBookConfiguration
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
        }
    }
}
