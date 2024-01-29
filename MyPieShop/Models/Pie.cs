namespace MyPieShop.Models
{
    public class Pie
    {
        internal bool InStock;
        internal bool IsPieOfTheWeek;

        public int PieId { get; set; } // added Id
        public string Name { get; set; } = string.Empty; // added Name
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AlleryInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheweek{ get; set; }
        public bool InStack { get; set; }
        public int CategoryId{ get; set; }
        public Category Category { get; set; } = default!;
    }
}
