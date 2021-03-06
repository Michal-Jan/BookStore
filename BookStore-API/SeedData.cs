using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore_API
{
    public static class SeedData
    {
        public async static Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }

        private async static Task SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@bookstore.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin@bookstore.com",
                    Email = "admin@bookstore.com"
                };
                var result = await userManager.CreateAsync(user, "P@ssword0");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }

            if (await userManager.FindByEmailAsync("customer1@customer.org") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "customer1@customer.org",
                    Email = "customer1@customer.org"
                };
                var result = await userManager.CreateAsync(user, "P@ssword0");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }

            if (await userManager.FindByEmailAsync("customer2@customer.org") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "customer2@customer.org",
                    Email = "customer2@customer.org"
                };
                var result = await userManager.CreateAsync(user, "P@ssword0");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
        }

        private async static Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Administrator"))
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };

                var result = await roleManager.CreateAsync(role);
            }

            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole
                {
                    Name = "Customer"
                };

                var result = await roleManager.CreateAsync(role);
            }
        }
    }
}