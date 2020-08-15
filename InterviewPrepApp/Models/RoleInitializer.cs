using InterviewPrepApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models
{
    public class RoleInitializer
    {
        private static readonly List<IdentityRole> Roles = new List<IdentityRole>()
        {
        new IdentityRole { Name = ApplicationRoles.Nicco, NormalizedName = ApplicationRoles.Nicco.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
        new IdentityRole { Name = ApplicationRoles.Admin, NormalizedName = ApplicationRoles.Admin.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
        new IdentityRole { Name = ApplicationRoles.Contributor, NormalizedName = ApplicationRoles.Contributor.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() }
        };

        public static void SeedRoles(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            using (var context = new QuestionsDbContext(serviceProvider.GetRequiredService<DbContextOptions<QuestionsDbContext>>()))
            {
                context.Database.EnsureCreated();
                if (!context.Roles.Any())
                {
                    foreach (IdentityRole role in Roles)
                    {
                        context.Roles.Add(role);
                        context.SaveChanges();
                    }
                    CreateNicco(userManager, config);
                }
            }
        }

        private static void CreateNicco(UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            if(userManager.FindByNameAsync(config["NiccoUserName"]).Result == null)
            {
                ApplicationUser nicco = new ApplicationUser
                {
                    UserName = config["NiccoUserName"],
                };
                IdentityResult created = userManager.CreateAsync(nicco, config["NiccoPassword"]).Result;

                if (created.Succeeded)
                {
                    var first = userManager.AddToRoleAsync(nicco, ApplicationRoles.Nicco).Result;
                    userManager.AddToRoleAsync(nicco, ApplicationRoles.Admin);
                }
            }
        }
    }
}
