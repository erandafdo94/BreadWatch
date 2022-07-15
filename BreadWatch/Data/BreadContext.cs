using BreadWatch.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BreadWatch.Data
{
    public class BreadContext : IdentityDbContext
    {
        public BreadContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Budgets> Budgets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                     new IdentityRole { Name = "User", NormalizedName = "USER" },
                     new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" }
                );


            builder.Entity<Budgets>(entity =>
            {
                entity.HasOne(c => c.Category)
                    .WithMany(b => b.Budgets)
                    .HasForeignKey(cat => cat.CategoryId);
            });
        }
    }
}
