using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace food_ordering_app.Data
{
    public class DBInitializer
    {
        public static async Task CreateRoles(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if(!await roleManager.RoleExistsAsync("ResturantEmployee"))
                    await roleManager.CreateAsync(new IdentityRole("ResturantEmployee"));
                if (!await roleManager.RoleExistsAsync("Customer"))
                    await roleManager.CreateAsync(new IdentityRole("Customer"));
            }
        }
    }
}
