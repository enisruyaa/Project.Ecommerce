using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extentions
{
    public static class UserRoleDataSeedExtensions
    {
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            IdentityRole<int> appRole = new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString() // Bu ifade sisteminizin yen bir Guid yaratmasını sağlar
            };

            modelBuilder.Entity<IdentityRole<int>>().HasData(appRole);

            IdentityRole<int> appRoleDev = new()
            {
                Id = 2,
                Name = "Developer",
                NormalizedName = "",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            modelBuilder.Entity<IdentityRole<int>>().HasData(appRoleDev);

            PasswordHasher<AppUser> passwordHasher = new();

            AppUser user = new()
            {
                Id = 1,
                UserName = "ens123",
                Email = "enisruya@gmail.com",
                NormalizedEmail = "ENISRUYA@GMAIL.COM",
                NormalizedUserName = "ENS123",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null,"ens123")
            };

            modelBuilder.Entity<AppUser>().HasData(user);

            AppUser user2 = new()
            {
                Id = 2,
                UserName = "cgr1234",
                Email = "cagri2@gmail.com",
                NormalizedEmail = "CAGRI2@GMAIL.COM",
                NormalizedUserName = "CGR1234",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "cgr1234")
            };

            modelBuilder.Entity<AppUser>().HasData(user2);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = appRole.Id,
                UserId = user.Id,
            });

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = appRoleDev.Id,
                UserId = user2.Id,
            });
        }
    }
}
