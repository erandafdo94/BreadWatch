namespace BreadWatch.Entities
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCatName { get; set; }
        public Category Category { get; set; } 
    }
}
