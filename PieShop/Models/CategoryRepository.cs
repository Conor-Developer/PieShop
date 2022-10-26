namespace PieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly PieShopDbContext _pieShopDbContext;
        public CategoryRepository(PieShopDbContext pieShopDbContext)
        {
            _pieShopDbContext = pieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _pieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
