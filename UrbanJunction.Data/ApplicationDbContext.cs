using UrbanJunction.Data.Configuration;
using UrbanJunction.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UrbanJunction.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Agent> Agents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Applying configurations
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());

            base.OnModelCreating(builder); // Is needed
        }
    }
}
