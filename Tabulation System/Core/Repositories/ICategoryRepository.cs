using Tabulation_System.Core.Models;

namespace Tabulation_System.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        bool CategoryAlreadyExist(string categoryName, int eventId);
        bool CategoryAlreadyExist(string categoryName, int eventId, int id);

        double GetTotalPercentage(int id);

        int GetTotalCategories(int id);
    }
}