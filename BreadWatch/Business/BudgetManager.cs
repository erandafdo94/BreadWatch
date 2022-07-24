using AutoMapper;
using BreadWatch.Business.Interfaces;
using BreadWatch.Dto;
using BreadWatch.Entities;
using BreadWatch.Repo.Interfaces;

namespace BreadWatch.Business
{
    public class BudgetManager : IBudgetManager
    {
        private readonly IBudgetRepo _budgetRepo;
        private readonly IMapper _mapper;

        public BudgetManager(IBudgetRepo budgetRepo,
            IMapper mapper)
        {
            _budgetRepo = budgetRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="budget"></param>
        public async Task AddNewBudget(BudgetDto budget)
        {
           // var bud = _mapper.Map<Budgets>(budget);

            Budgets budgetForRepo = new Budgets
            {
                BudgetName = budget.BudgetName,
                CategoryId = budget.CategoryId,
             //   UserId = ,
                //Amount = budget.Amount
            };

           // bud.Category.Name = "Dating";
            await _budgetRepo.AddNewBudget(budgetForRepo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        //public List<BudgetDto> GetBudgetsForUser(int userId)
        //{
        //    var budgetList = _budgetRepo.GetBudgetsForUser(userId);
        //    List <BudgetDto> budgetDtoList = new List <BudgetDto>();

        //    foreach (var item in budgetList)
        //    {
        //        BudgetDto budNew = new BudgetDto
        //        {
        //            BudgetName = item.BudgetName,
        //            CategoryId = item.CategoryId,
        //            Amount = item.Amount
        //        };

        //        budgetDtoList.Add(budNew);
        //    }

        //    return budgetDtoList;
        //}

    }
}
