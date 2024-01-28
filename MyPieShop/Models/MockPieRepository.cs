namespace MyPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new
            MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
            new Pie {PieId = 1, Name="Strawberry Pie", Price=15.9M, ShortDescription="Lorem Ipsom", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownies candytootsie roll. Chocolate cake ginger bread tootsie roll....", Category= _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg", InStock = true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypiesmall.jpg"}, new Pie {PieId = 2, Name="Cheese cake", Price=18.95M}
        };
       
        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
