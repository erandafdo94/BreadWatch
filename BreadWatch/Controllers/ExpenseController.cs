using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BreadWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseManager expenseManager;

        public ExpenseController(IExpenseManager expenseManager)
        {
            this.expenseManager = expenseManager;
        }

        //[HttpGet("GetExpenseCategories")]
        //public List<ExpenseCategoryDto> GetExpenseCategories()
        //{
        //    return expenseManager.GetExpenseCategories();
        //}
    }
}
