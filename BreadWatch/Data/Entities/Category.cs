using System.Text.Json.Serialization;

namespace BreadWatch.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Budgets> Budgets { get; set; }
    }
}

