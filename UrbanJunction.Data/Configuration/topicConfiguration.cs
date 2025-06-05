namespace UrbanJunction.Data.Configuration
{
    using UrbanJunction.Data.Models;
    using UrbanJunction.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class HouseConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder
                .HasOne(h => h.Category)
                .WithMany(c => c.Topics)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(h => h.Agent)
               .WithMany(a => a.ManagedHouses)
               .HasForeignKey(h => h.AgentId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(HouseSeeder.SeedHouses());
        }
    }
}
