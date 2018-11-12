using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabulation_System.Core.Models;
using Tabulation_System.Core.Repositories;

namespace Tabulation_System.Persistence.Repositories
{
    public class JudgeRepository : Repository<User>, IJudgeRepository
    {
        private readonly ApplicationDbContext _context;
        public JudgeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

   


        public bool JudgeAlreadyExist(string firstName, string lastName)
        {

            return _context.Users
                       .Count(j => j.FirstName == firstName
                                   && j.LastName == lastName) == 1;
        }

        public bool JudgeAlreadyExist(string firstName, string lastName, int judgeId)
        {
            return _context.Users
                       .Count(j => j.FirstName == firstName
                                   && j.LastName == lastName
                                   && j.Id != judgeId) == 1;
        }
    }
}
