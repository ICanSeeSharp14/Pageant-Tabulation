using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tabulation_System.Core.Models;
using Tabulation_System.Core.Repositories;

namespace Tabulation_System.Persistence.Repositories
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(ApplicationDbContext context) 
            : base(context)
        {
               
        }

        public bool Login(string username, string password)
        {
            return DatabaseContext.Users
                       .Count(u => u.Username == username && 
                                   u.Password == password) == 1;
        }



        public User CheckLoginUser(string username, string password)
        {
            return
                DatabaseContext.Users.SingleOrDefault(u => u.Username == username &&
                                                           u.Password == password);
              
        }

        public bool UserNameAlreadyUsed(string userName)
        {
            return DatabaseContext.Users
                       .Count(u => u.Username == userName) == 1;
        }

        public bool UserNameAlreadyUsed(string userName, int id)
        {
            return DatabaseContext.Users
                       .Count(u => u.Username == userName && u.Id != id) == 1;
        }


        public ApplicationDbContext DatabaseContext
        {
            get { return Context; }
        }
    }
}
