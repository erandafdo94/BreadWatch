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

        DbSet<User> Users { get; set; }
        DbSet<Category> Category { get; set; }
        DbSet<Transactions> Transactions { get; set; }
        DbSet<SubCategory> SubCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                     new IdentityRole { Name = "User", NormalizedName = "USER" },
                     new IdentityRole { Name = "Admin", NormalizedName = "Admin" }
                ); 
        }


    }
}
