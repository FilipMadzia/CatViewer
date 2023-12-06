using Microsoft.AspNetCore.Identity;

namespace CatViewer.Data.Seeders;

public class UserSeeder
{
    public static async Task Seed(WebApplication app)
    {
        using(IServiceScope scope = app.Services.CreateScope())
        {
            UserManager<IdentityUser> userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string email = "admin@admin";
            string password = "admin";
            
            if(await userManager.FindByEmailAsync(email) == null)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = "admin@admin",
                    Email = email,
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user, password);
            }
        }
    }
}
