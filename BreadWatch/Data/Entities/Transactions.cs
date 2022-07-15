namespace BreadWatch.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool Income { get; set; }
        public bool Expense { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
