using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BreadWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpGet("getbudgetsforuser/{userId}")]
        public List<BudgetDto> GetBudgetsForUser(string userId)
        {
            var userGuid = new Guid("2A3FF16C-031D-40E3-2B35-08DA6DB67E4B");
            return _budgetManager.GetBudgetsForUser(userGuid);
        }
    }
}
