namespace BreadWatch.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool Income { get; set; }
        public bool Expense { get; set; }
        public User user { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
