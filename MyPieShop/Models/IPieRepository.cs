namespace MyPieShop.Models
{
    public interface IPieRepository
    {
        // declare that the repository should be given 
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek{ get; }
        Pie? GetPieById(int pieId);
    }
}
