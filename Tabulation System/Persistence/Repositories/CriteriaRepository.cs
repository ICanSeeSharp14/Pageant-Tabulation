using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabulation_System.Core.Models;
using Tabulation_System.Core.Repositories;

namespace Tabulation_System.Persistence.Repositories
{
    public class CriteriaRepository : Repository<Criteria>, ICriteriaRepository
    {
        public CriteriaRepository(ApplicationDbContext context) : base(context)
        {

        }

        public bool CriteriaAlreadyExist(string criteriaName, int categoryId)
        {
            return DatabaseContext.SubCategories
            .Count(c => c.CriteriaName == criteriaName
                                   && c.CategoryId == categoryId) == 1;
        }

        public bool CriteriaAlreadyExist(string criteriaName, int categoryId, int criteriaId)
        {
            return DatabaseContext.SubCategories
                       .Count(c => c.CriteriaName == criteriaName
                                   && c.CategoryId == categoryId && c.Id != criteriaId) == 1;
        }


        public ApplicationDbContext DatabaseContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
