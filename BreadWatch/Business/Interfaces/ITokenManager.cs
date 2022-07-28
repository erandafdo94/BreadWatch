using BreadWatch.Entities;

namespace BreadWatch.Business.Interfaces
{
    public interface ITokenManager
    {
        Task<string> GenerateTokenAsync(ApplicationUser user);
    }
}
