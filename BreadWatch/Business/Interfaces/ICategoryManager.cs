using BreadWatch.Dto;

namespace BreadWatch.Business.Interfaces
{
    public interface ICategoryManager
    {
        List<ExpenseCategoryDto> GetExpenseCategories();
    }
}
