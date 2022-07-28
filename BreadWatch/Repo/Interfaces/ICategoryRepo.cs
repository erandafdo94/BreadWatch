using BreadWatch.Entities;

namespace BreadWatch.Repo.Interfaces
{
    public interface ICategoryRepo
    {
        List<Category> GetExpenseCategories();
    }
}
