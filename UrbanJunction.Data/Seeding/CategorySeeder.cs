namespace UrbanJunction.Data.Seeding
{
    using UrbanJunction.Data.Models;
    using static UrbanJunction.Data.Seeding.Constants.Constants;

    public static class CategorySeeder
    {
        public static IEnumerable<Category> SeedCategories()
        {
            IEnumerable<Category> categories = new List<Category>()
            {
                new Category(CategoryConstants.CottageId, CategoryConstants.CottageName),
                new Category(CategoryConstants.SingleFamilyId, CategoryConstants.SingleFamilyName),
                new Category(CategoryConstants.DuplexId, CategoryConstants.DuplexName),
            };

            return categories;
        }
    }
}
