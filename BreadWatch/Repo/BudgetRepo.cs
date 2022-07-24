using BreadWatch.Data;
using BreadWatch.Dto;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;
using System.Linq;

namespace BreadWatch.Repo
{
    public class BudgetRepo : IBudgetRepo
    {
        private readonly BreadContext _breadContext;

        public BudgetRepo(BreadContext breadContext)
        {
            this._breadContext = breadContext;
        }
        public async Task AddNewBudget(Budgets budget)
        {
            try
            {
                 _breadContext.Add(budget);
                 await _breadContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public IEnumerable<Budgets> GetBudgetsForUser(int userId)
        //{
        //   // IEnumerable<Budgets> newBudgetList = _breadContext.Budgets.Where(b => b.UserId == userId);
        //    return newBudgetList;
        //}

       
    }
}
