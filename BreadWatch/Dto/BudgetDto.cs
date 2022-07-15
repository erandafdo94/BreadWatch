namespace BreadWatch.Dto
{
    public class BudgetDto
    {
        public int Id { get; set; }
        public string BudgetName { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
