using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BreadWatch.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager expenseManager;

        public CategoryController(ICategoryManager expenseManager)
        {
            this.expenseManager = expenseManager;
        }

        
        [HttpGet("GetExpenseCategories")]
        public List<ExpenseCategoryDto> GetExpenseCategories()
        {
            return expenseManager.GetExpenseCategories();
        }
    }
}
