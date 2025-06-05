namespace UrbanJunction.Data.Seeding.Constants
{
    using UrbanJunction.Data.Models;

    public class Constants
    {
        public class UserConstants
        {
            public const string AgentId = "dea12856-c198-4129-b3f3-b893d8395082";
            public const string AgentEmail = "agent@mail.com";
            public const string AgentConcurrencyStamp = "ce29724b-d7ae-4dea-9ec5-946c3b9ea8d5";

            public const string GuestId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e";
            public const string GuestEmail = "guest@mail.com";
            public const string GuestConcurrencyStamp = "61da24bb-a0c0-45c8-9b99-f12636ae5a6f";

            public const string Password = "123456";
        }

        public class AgentConstants
        {
            public const string Id = "44a41a1c-943b-47e2-80e6-47463b6f139b";
            public const string PhoneNumber = "+359888888888";
        }

        public class CategoryConstants
        {
            public const int CottageId = 1;
            public const string CottageName = "Cottage";

            public const int SingleFamilyId = 2;
            public const string SingleFamilyName = "Single-Family";

            public const int DuplexId = 3;
            public const string DuplexName = "Duplex";
        }

        public class HouseConstants
        {
            public const int BigHouesMarinaId = 1;
            public const string BigHouseMarinaName = "Big Topic Marina";
            public const string BigHouseMarinaAddress = "North London, UK (near the border";
            public const string BigHouseMarinaDescription = "A big topic for your whole family. Don't miss to buy a topic with three bedrooms.";
            public const string BigHouseMarinaImageUrl = "https://www.rocketmortgage.com/resources-cmsassets/RocketMortgage.com/Article_Images/Large_Images/TypesOfHomes/types-of-homes-hero.jpg";
            public const decimal BigHouseMarinaPricePerMonth = 2100.00M;

            public const int FamilyHouseComfortId = 2;
            public const string FamilyHouseComfortTitle = "Family Topic Comfort";
            public const string FamilyHouseComfortAddress = "Near the Sea Garden in Burgas, Bulgaria";
            public const string FamilyHouseComfortDescription = "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.";
            public const string FamilyHouseComfortImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1";
            public const decimal FamilyHouseComfortPricePerMonth = 1200.00M;

            public const int GrandHouseId = 3;
            public const string GrandHouseTitle = "Grand Topic";
            public const string GrandHouseAddress = "Boyana Neighbourhood, Sofia, Bulgaria";
            public const string GrandHouseDescription = "This luxurious topic is everything you will need. It is just excellent.";
            public const string GrandHouseImageUrl = "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg";
            public const decimal GrandHousePricePerMonth = 2000.00M;
        }
    }
}
