using BethanysPieShop.Models.Entities;

namespace BethanysPieShop.Models.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

    public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    public IEnumerable<Category> AllCategories =>
        _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
}