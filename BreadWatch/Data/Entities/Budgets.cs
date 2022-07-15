using System.Text.Json.Serialization;

namespace BreadWatch.Entities
{
    public class Budgets
    {
        public int Id { get; set; }
        public string BudgetName { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
    }
}

//grade