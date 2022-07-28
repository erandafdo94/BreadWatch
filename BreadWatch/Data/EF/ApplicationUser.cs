using BreadWatch.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace BreadWatch.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Accounts> Accounts { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
        public ICollection<Budgets> Budgets { get; set; }
    }
}
