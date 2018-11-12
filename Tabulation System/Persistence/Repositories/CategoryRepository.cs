using System.Linq;
using Tabulation_System.Core.Models;
using Tabulation_System.Core.Repositories;

namespace Tabulation_System.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public ApplicationDbContext DbRepository;
      
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            DbRepository = context;
        }

        public bool CategoryAlreadyExist(string categoryName, int eventId)
        {
            return DbRepository.Categories
                       .Count(c => c.CategoryName == categoryName && c.EventId == eventId) == 1;
        }



        public bool CategoryAlreadyExist(string categoryName, int eventId, int id)
        {
            return DbRepository.Categories
                       .Count(c => c.CategoryName == categoryName
                                   && c.EventId == eventId && c.Id != id) == 1;
        }

        public double GetTotalPercentage(int id)
        {
            return DbRepository.Categories.Where(c => c.EventId ==  id).Select(c => c.Percentage)
                .Sum();
        }

        public int GetTotalCategories(int id)
        {
            return DbRepository.Categories.Count(c => c.Id == id);

        }
    }
}
