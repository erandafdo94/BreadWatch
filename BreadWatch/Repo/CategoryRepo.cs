using BreadWatch.Data;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace BreadWatch.Repo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly BreadContext _breadContext;

        public CategoryRepo(BreadContext breadContext)
        {
            _breadContext = breadContext;
        }

        [AllowAnonymous]
        public List<Category> GetExpenseCategories()
        {
            return _breadContext.bread_Category.ToList();
        }
    }
}
