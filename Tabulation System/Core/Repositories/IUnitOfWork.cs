using System;
using System.Threading.Tasks;

namespace Tabulation_System.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IJudgeRepository Judges { get; }

        ICandidateRepository Candidates { get; }
        IEventRepository Events { get; }
        ICriteriaRepository Criterias { get; }
        ICategoryRepository Categories { get; }
        int Commit();

        Task<int> CommitAsync();
    }
}