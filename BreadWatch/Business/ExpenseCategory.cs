using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;

namespace BreadWatch.Business
{
    public class ExpenseCategory : IExpenseManager
    {
        private readonly IExpenseRepo _expenseRepo;

        public ExpenseCategory(IExpenseRepo expenseRepo)
        {
            _expenseRepo = expenseRepo;
        }
        //public List<ExpenseCategoryDto> GetExpenseCategories()
        //{
        //    List<Category> catList = _expenseRepo.GetExpenseCategories();

        //    List<ExpenseCategoryDto> categoryDtoList = new List<ExpenseCategoryDto>();

        //    foreach (var cat in catList)
        //    {
        //        ExpenseCategoryDto catObj = new ExpenseCategoryDto
        //        {
        //            Id = cat.Id,
        //            Name = cat.Name
        //        };
        //        categoryDtoList.Add(catObj);
        //    }

        //    return categoryDtoList;
        //}
    }
}
