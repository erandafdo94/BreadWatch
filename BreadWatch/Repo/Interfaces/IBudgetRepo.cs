using BreadWatch.Dto;
using BreadWatch.Entities;

namespace BreadWatch.Repo.Interfaces
{
    public interface IBudgetRepo
    {
        void AddNewBudget(Budgets budget);
        IEnumerable<Budgets> GetBudgetsForUser(int userId);
    }
}
