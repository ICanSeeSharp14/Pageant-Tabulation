using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tabulation_System.Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DbConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modeBuilder)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Criteria> SubCategories { get; set; }
        public virtual DbSet<Event> Events { get; set; }
    }
}
