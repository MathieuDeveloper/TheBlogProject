using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TheBlogProject.Data;
using TheBlogProject.Enums;
using TheBlogProject.Models;

namespace TheBlogProject.Services
{
    public class DataService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<BlogUser> _userManager;

        public DataService(ApplicationDbContext dbContext,
                           RoleManager<IdentityRole> roleManager,
                           UserManager<BlogUser> userManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public async Task ManageDataAsync()
        {
            //Task: Create the DB from the migrations
            await _dbContext.Database.MigrateAsync();

            //1: Seed a few Roles into the system
            await SeedRolesAsync();

            //2: Seed a few users into the system
            await SeedUsersAsync();
        }


        private async Task SeedRolesAsync()
        {
            // if there are already roles in the system, do nothing
            if (_dbContext.Roles.Any()) { return; }

            // otherwise create a few Roles
            foreach (var role in Enum.GetNames(typeof(BlogRole)))
            {
                // I need to use Role Manager to create roles
               await _roleManager.CreateAsync(new IdentityRole(role));
            }

        }

       private async Task SeedUsersAsync() 
       {
            // if there are already users in the system, do nothing
            if(_dbContext.Users.Any()) { return; }


            //step 1  Create a new instance of BlogUser
            var adminUser = new BlogUser()
            {
                Email = "jacodiabolo@yahoo.fr",
                UserName = "jacodiabolo@yahoo.fr",
                FirstName = "Jaco",
                LastName = "Diabolo",
                DisplayName = "The Professor",
                PhoneNumber = "555-1212",
                EmailConfirmed = true
            };

            //step 2  Use the UserManager to create a new user that is defined by adminUser
            await _userManager.CreateAsync(adminUser, "Abc&123!");

            //step 3 Add this new user to the Administrator role
            await _userManager.AddToRoleAsync(adminUser, BlogRole.Administrator.ToString());

            //step 1 repeat: create the moderator user
            var modUser = new BlogUser()
            {
                Email = "topfermathieu@yahoo.fr",
                UserName = "topfermathieu@yahoo.fr",
                FirstName = "Mathieu",
                LastName = "Topfer",
                DisplayName = "The other Professor",
                PhoneNumber = "555-1313",
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(modUser, "Abc&123!");
            await _userManager.AddToRoleAsync(modUser, BlogRole.Moderator.ToString());

        }


    }
}
