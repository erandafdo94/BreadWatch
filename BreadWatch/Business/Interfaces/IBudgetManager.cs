using BreadWatch.Dto;

namespace BreadWatch.Business.Interfaces
{
    public interface IBudgetManager
    {
        void AddNewBudget(BudgetDto budget);
        List<BudgetDto> GetBudgetsForUser(int userId);
    }
}
