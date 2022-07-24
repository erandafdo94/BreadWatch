using BreadWatch.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BreadWatch.Data
{
    public static class SeedData
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {

            // Crear ROLES
            modelBuilder.Entity<IdentityRole<Guid>>()
                .HasData(
                    new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "User", NormalizedName = "USER" },
                    new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" }
                );

            // Crear USERS
            List<ApplicationUser> users = new List<ApplicationUser>() {
                new ApplicationUser {
                    Id = Guid.NewGuid(),
                    UserName = "admin1@tajamar365.com",
                    NormalizedUserName = "ADMIN1@TAJAMAR365.COM",
                    Email = "admin1@tajamar365.com",
                    NormalizedEmail = "ADMIN1@TAJAMAR365.COM"
                },
                new ApplicationUser {
                    Id = Guid.NewGuid(),
                    UserName = "coach1@tajamar365.com",
                    NormalizedUserName = "COACH1@TAJAMAR365.COM",
                    Email = "coach1@tajamar365.com",
                    NormalizedEmail = "COACH1@TAJAMAR365.COM"
                },
                new ApplicationUser {
                    Id = Guid.NewGuid(),
                    UserName = "swimmer1@tajamar365.com",
                    NormalizedUserName = "SWIMMER1@TAJAMAR365.COM",
                    Email = "swimmer1@tajamar365.com",
                    NormalizedEmail = "SWIMMER1@TAJAMAR365.COM"
                },
                new ApplicationUser {
                    Id = Guid.NewGuid(),
                    UserName = "visitor1@tajamar365.com",
                    NormalizedUserName = "VISITOR1@TAJAMAR365.COM",
                    Email = "visitor1@tajamar365.com",
                    NormalizedEmail = "VISITOR1@TAJAMAR365.COM"
                }
            };
            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Agregar contraseña a los usuarios
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "$Eranda00");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "$Eranda00");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "$Eranda00");
            users[3].PasswordHash = passwordHasher.HashPassword(users[3], "$Eranda00");
        }
    }
}
