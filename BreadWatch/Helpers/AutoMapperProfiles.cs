using AutoMapper;
using BreadWatch.Dto;
using BreadWatch.Entities;

namespace BreadWatch.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Budgets, BudgetDto>().ReverseMap();

        }
    }
}
