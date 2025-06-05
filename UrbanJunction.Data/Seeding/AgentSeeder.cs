namespace UrbanJunction.Data.Seeding
{
    using UrbanJunction.Data.Models;
    using static UrbanJunction.Data.Seeding.Constants.Constants;

    public class AgentSeeder
    {
        public static IEnumerable<Agent> SeedAgents()
        {
            List<Agent> agents = new List<Agent>()
            {
                new Agent()
                {
                    Id = Guid.Parse(AgentConstants.Id),
                    PhoneNumber = AgentConstants.PhoneNumber,
                    UserId = UserConstants.AgentId
                }
            };

            return agents;
        }
    }
}
