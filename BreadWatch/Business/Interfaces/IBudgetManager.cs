using BreadWatch.Dto;

namespace BreadWatch.Business.Interfaces
{
    public interface IBudgetManager
    {
        Task AddNewBudget(BudgetDto budget);
        List<BudgetDto> GetBudgetsForUser(Guid userId);
    }
}
