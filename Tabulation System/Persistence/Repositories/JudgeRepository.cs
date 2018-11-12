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
        public JudgeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
