namespace MyPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // added catagory Id 
        public string CategoryName { get; set; } = string.Empty;// added catagory name
        public string? Description { get; set; } // added catagory Description 
        public List<Pie>? Pies { get; set; }
    }
}
