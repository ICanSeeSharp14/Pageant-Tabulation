using Tabulation_System.Core.Models;

namespace Tabulation_System.Core.Repositories
{
    public interface IJudgeRepository : IRepository<User>
    {
        bool JudgeAlreadyExist(string firstName, string lastName);
        bool JudgeAlreadyExist(string firstName, string lastName, int judgeId);

    }
}