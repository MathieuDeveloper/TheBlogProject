using System.Linq;
using System.Threading.Tasks;
using TheBlogProject.Data;

namespace TheBlogProject.Services
{
    public class DataService
    {
        private readonly ApplicationDbContext _dbContext;

        public DataService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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


        }

       private async Task SeedUsersAsync() 
       {

       }


    }
}
