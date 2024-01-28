namespace MyPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruit pies"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the w,ay"},
                new Category{CategoryId=3, CategoryName="Sesonal pies", Description="Get in the mood for a seasonal pie"}
            };
    } 
}
