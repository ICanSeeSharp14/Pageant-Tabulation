using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabulation_System.Core.Models;
using Tabulation_System.Core.Repositories;

namespace Tabulation_System.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public IUserRepository Users { get; set; }
        public IJudgeRepository Judges { get; set; }

        public ICandidateRepository Candidates { get; set; }
        public ICriteriaRepository Criterias { get; set; }

        public IEventRepository Events { get; set; }
        public ICategoryRepository Categories { get; set; }


        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Users = new UserRepository(_dbContext);
            Judges = new JudgeRepository(_dbContext);
            Criterias = new CriteriaRepository(_dbContext);
            Events = new EventRepository(_dbContext);
            Categories = new CategoryRepository(_dbContext);

        }
        
        public void Dispose()
        {
           _dbContext.Dispose();
           
        }

       
        public int Commit()
        {
           return _dbContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
