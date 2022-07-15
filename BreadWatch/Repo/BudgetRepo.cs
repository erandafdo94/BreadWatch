using BreadWatch.Data;
using BreadWatch.Dto;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;
using System.Linq;

namespace BreadWatch.Repo
{
    public class BudgetRepo : IBudgetRepo
    {
        private readonly BreadContext breadContext;

        public BudgetRepo(BreadContext breadContext)
        {
            this.breadContext = breadContext;
        }
        public void AddNewBudget(Budgets budget)
        {
            try
            {
                breadContext.Add(budget);
                breadContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Budgets> GetBudgetsForUser(int userId)
        {
            IEnumerable<Budgets> newBudgetList = breadContext.Budgets.Where(b => b.UserId == userId);
            return newBudgetList;
        }
    }
}
