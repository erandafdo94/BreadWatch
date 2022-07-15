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
        public void AddNewBudget(BudgetDto budget)
        {
           // var bud = _mapper.Map<Budgets>(budget);

            Budgets budgetForRepo = new Budgets
            {
                BudgetName = budget.BudgetName,
                CategoryId = budget.CategoryId,
                UserId = 1,
                Amount = budget.Amount
            };

           // bud.Category.Name = "Dating";
            _budgetRepo.AddNewBudget(budgetForRepo);
        }

        public List<BudgetDto> GetBudgetsForUser(int userId)
        {
            var budgetList = _budgetRepo.GetBudgetsForUser(userId);
            List <BudgetDto> budgetDtoList = new List <BudgetDto>();

            foreach (var item in budgetList)
            {
                BudgetDto budNew = new BudgetDto
                {
                    BudgetName = item.BudgetName,
                    CategoryId = item.CategoryId,
                    Amount = item.Amount
                };

                budgetDtoList.Add(budNew);
            }

            return budgetDtoList;
        }
    }
}
