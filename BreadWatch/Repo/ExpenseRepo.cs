using BreadWatch.Data;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;

namespace BreadWatch.Repo
{
    public class ExpenseRepo : IExpenseRepo
    {
        private readonly BreadContext _breadContext;

        public ExpenseRepo(BreadContext breadContext)
        {
            _breadContext = breadContext;
        }
        //public List<Category> GetExpenseCategories()
        //{
        //    return _breadContext.Category.ToList();
        //}
    }
}
