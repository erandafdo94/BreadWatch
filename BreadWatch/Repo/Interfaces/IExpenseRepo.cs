using BreadWatch.Entities;

namespace BreadWatch.Repo.Interfaces
{
    public interface IExpenseRepo
    {
        List<Category> GetExpenseCategories();
    }
}
