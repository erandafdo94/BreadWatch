using System.Text.Json.Serialization;

namespace BreadWatch.Entities
{
    public class Budgets
    {
        public int Id { get; set; }
        public string BudgetName { get; set; }
        public int CategoryId { get; set; }
        public Guid UserGuid { get; set; }
        public decimal Amount { get; set; }


        public ApplicationUser User { get; set; }
        public Category Category { get; set; }
    }
}
