namespace UrbanJunction.Data.Configuration
{
    using UrbanJunction.Data.Seeding;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            IEnumerable<IdentityUser> users = UserSeeder.SeedUsers();

            builder.HasData(users);
        }
    }
}
