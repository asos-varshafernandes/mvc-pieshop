namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Fruit Pies", Description = "All Fruity Pies"},
                new Category { CategoryId = 2, CategoryName = "Cheese Cakes", Description = "Cheesy All The Way"},
                new Category { CategoryId = 3, CategoryName = "Seasonal Pies", Description = "Get in mood for the seasonal pie"},
            };
    }
}
