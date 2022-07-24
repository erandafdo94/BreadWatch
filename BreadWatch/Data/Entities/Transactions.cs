using System.Text.Json.Serialization;

namespace BreadWatch.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool Income { get; set; }
        public bool Expense { get; set; }
        public Guid UserGuid { get; set; }
        public int CategoryId { get; set; }

        public ApplicationUser User { get; set; }
        public Category Category { get; set; }
    }
}
