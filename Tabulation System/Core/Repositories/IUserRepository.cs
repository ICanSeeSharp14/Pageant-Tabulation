using System.Collections.Generic;
using System.Threading.Tasks;
using Tabulation_System.Core.Models;

namespace Tabulation_System.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        bool Login(string username, string password);
      
       User CheckLoginUser(string username, string password);

        bool UserNameAlreadyUsed(string userName);

        bool UserNameAlreadyUsed(string userName, int id);
    }

    
}
