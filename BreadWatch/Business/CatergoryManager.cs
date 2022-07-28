using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;

namespace BreadWatch.Business
{
    public class CatergoryManager : ICategoryManager
    {
        private readonly ICategoryRepo _expenseRepo;

        public CatergoryManager(ICategoryRepo expenseRepo)
        {
            _expenseRepo = expenseRepo;
        }

        public List<ExpenseCategoryDto> GetExpenseCategories()
        {
            List<Category> catList = _expenseRepo.GetExpenseCategories();

            List<ExpenseCategoryDto> categoryDtoList = new List<ExpenseCategoryDto>();

            foreach (var cat in catList)
            {
                ExpenseCategoryDto catObj = new ExpenseCategoryDto
                {
                    Id = cat.Id,
                    Name = cat.Name
                };
                categoryDtoList.Add(catObj);
            }

            return categoryDtoList;
        }
    }
}
