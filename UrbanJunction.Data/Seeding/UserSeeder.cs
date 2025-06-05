namespace UrbanJunction.Data.Seeding
{
    using Microsoft.AspNetCore.Identity;
    using static UrbanJunction.Data.Seeding.Constants.Constants;

    public class UserSeeder
    {
        public static IEnumerable<IdentityUser> SeedUsers()
        {
            List<IdentityUser> users = new List<IdentityUser>()
            {
                new IdentityUser()
                {
                    Id = UserConstants.AgentId,
                    UserName = UserConstants.AgentEmail,
                    NormalizedUserName = UserConstants.AgentEmail.ToUpper(),
                    Email = UserConstants.AgentEmail,
                    NormalizedEmail = UserConstants.AgentEmail.ToUpper(),
                    ConcurrencyStamp = UserConstants.AgentConcurrencyStamp,
                },
                new IdentityUser()
                {
                    Id = UserConstants.GuestId,
                    UserName = UserConstants.GuestEmail,
                    NormalizedUserName = UserConstants.GuestEmail.ToUpper(),
                    Email = UserConstants.GuestEmail,
                    NormalizedEmail = UserConstants.GuestEmail.ToUpper(),
                    ConcurrencyStamp = UserConstants.GuestConcurrencyStamp,
                }
            };

            var hasher = new PasswordHasher<IdentityUser>();

            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, UserConstants.Password);
            }

            return users;
        }

    }
}
