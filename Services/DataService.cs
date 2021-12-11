using Microsoft.AspNetCore.Identity;
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

        public DataService(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
        }


        public async Task ManageDataAsync()
        {
            //1: Seed a few Roles into the system
            await SeedRolesAsync();

            //2: Seed a few users into the system
            await SeedUsersAsync();
        }


        private async Task SeedRolesAsync()
        {
            // if there are alreasy roles in the system, do nothing
            if (_dbContext.Roles.Any()) { return; }

            //otherwise create a few Roles
            foreach (var role in Enum.GetNames(typeof(BlogRole)))
            {
                // I need to use Role Manager to create roles
               await _roleManager.CreateAsync(new IdentityRole(role));
            }

        }

       private async Task SeedUsersAsync() 
       {
            // if there are alreasy users in the system, do nothing
            if(_dbContext.Users.Any()) { return; }


            //step 1  create a new instance of BlogUser
            var adminUser = new BlogUser()
            {
                Email = "jasontwitchell@coderfoundry.com",
                UserName = "jasontwitchell@coderfoundry.com",
                FirstName = "Jason",
                LastName = "Twitchell",
                PhoneNumber = "555-1212",
                EmailConfirmed = true
            };

        }


    }
}
