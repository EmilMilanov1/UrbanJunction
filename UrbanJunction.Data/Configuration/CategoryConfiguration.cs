namespace UrbanJunction.Data.Configuration
{
    using UrbanJunction.Data.Models;
    using UrbanJunction.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CategorySeeder.SeedCategories());
        }
    }
}
