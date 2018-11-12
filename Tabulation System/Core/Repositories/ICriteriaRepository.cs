using Tabulation_System.Core.Models;

namespace Tabulation_System.Core.Repositories
{
    public interface ICriteriaRepository : IRepository<Criteria>
    {
        bool CriteriaAlreadyExist(string criteriaName, int categoryId);
        bool CriteriaAlreadyExist(string criteriaName, int categoryId, int criteriaId);
    }
}