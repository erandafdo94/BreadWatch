using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BreadWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        private readonly IBudgetManager _budgetManager;

        public BudgetsController(IBudgetManager BudgetManager)
        {
            _budgetManager = BudgetManager;
        }

        [HttpPost("addnewbugdet")]
        public async Task AddNewBudget(BudgetDto budgetDto)
        {
           await _budgetManager.AddNewBudget(budgetDto);
        }

        //[HttpGet("getbudgetsforuser/{userId}")]
        //public List<BudgetDto> GetBudgetsForUser(int userId)
        //{
        //    return _budgetManager.GetBudgetsForUser(userId);
        //}

       

    }
}
