using BreadWatch.Dto;
using BreadWatch.Entities;

namespace BreadWatch.Repo.Interfaces
{
    public interface IBudgetRepo
    {
        Task AddNewBudget(Budgets budget);
        IEnumerable<Budgets> GetBudgetsForUser(Guid userId);
    }
}
