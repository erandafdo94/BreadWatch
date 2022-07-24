using BreadWatch.Data.Entities;
using BreadWatch.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BreadWatch.Data
{
    public class BreadContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public BreadContext(DbContextOptions<BreadContext> options) : base(options)
        {
            
        }

        public DbSet<Category> bread_Category { get; set; }
        public DbSet<Transactions> bread_Transactions { get; set; }
        public DbSet<Budgets> bread_Budgets { get; set; }
        public DbSet<Accounts> bread_Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          //  SeedData.Initialize(builder);
            base.OnModelCreating(builder);

            builder.Entity<ApplicationRole>()
               .HasData(
                   new ApplicationRole { Id = Guid.NewGuid(), Name = "User", NormalizedName = "USER" },
                   new ApplicationRole { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" }
               );

            builder.Entity<Budgets>(entity =>
            {
                entity.HasOne(c => c.Category)
                    .WithMany(b => b.Budgets)
                    .HasForeignKey(cat => cat.CategoryId);
            });

            builder.Entity<Transactions>(entity =>
            {
                entity.HasOne(c => c.User)
                    .WithMany(b => b.Transactions)
                    .HasForeignKey(cat => cat.UserGuid);
            });

            builder.Entity<Accounts>(entity =>
            {
                entity.HasOne(c => c.User)
                    .WithMany(b => b.Accounts)
                    .HasForeignKey(cat => cat.UserGuid);
            });
        }
    }
}
