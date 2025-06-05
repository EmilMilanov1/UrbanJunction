namespace UrbanJunction.Data.Configuration
{
    using UrbanJunction.Data.Models;
    using UrbanJunction.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(AgentSeeder.SeedAgents());
        }
    }
}
