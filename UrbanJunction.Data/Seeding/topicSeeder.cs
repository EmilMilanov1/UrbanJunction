namespace UrbanJunction.Data.Seeding
{
    using UrbanJunction.Data.Models;
    using static UrbanJunction.Data.Seeding.Constants.Constants;

    public class HouseSeeder
    {
        public static IEnumerable<Topic> SeedHouses()
        {
            IEnumerable<Topic> topics = new List<Topic>()
            {
                new Topic(HouseConstants.BigHouesMarinaId, HouseConstants.BigHouseMarinaName, HouseConstants.BigHouseMarinaAddress, HouseConstants.BigHouseMarinaDescription, HouseConstants.BigHouseMarinaImageUrl, HouseConstants.BigHouseMarinaPricePerMonth)
                {
                    CategoryId = CategoryConstants.DuplexId,
                    AgentId = Guid.Parse(AgentConstants.Id),
                    RenterId = UserConstants.GuestId,
                },
                new Topic(HouseConstants.FamilyHouseComfortId, HouseConstants.FamilyHouseComfortTitle, HouseConstants.FamilyHouseComfortAddress, HouseConstants.FamilyHouseComfortDescription, HouseConstants.FamilyHouseComfortImageUrl, HouseConstants.FamilyHouseComfortPricePerMonth)
                {
                    CategoryId = CategoryConstants.SingleFamilyId,
                    AgentId = Guid.Parse(AgentConstants.Id),
                },
                new Topic(HouseConstants.GrandHouseId, HouseConstants.GrandHouseTitle, HouseConstants.GrandHouseAddress, HouseConstants.GrandHouseDescription, HouseConstants.GrandHouseImageUrl, HouseConstants.GrandHousePricePerMonth)
                {
                    CategoryId = CategoryConstants.SingleFamilyId,
                    AgentId = Guid.Parse(AgentConstants.Id),
                }
            };

            return topics;
        }
    }
}
