using BreadWatch.Entities;
using System.Text.Json.Serialization;

namespace BreadWatch.Data.Entities
{
    public class Accounts
    {
        public int AccountsId { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public Guid UserGuid { get; set; }
        public ApplicationUser User { get; set; }

    }
}
