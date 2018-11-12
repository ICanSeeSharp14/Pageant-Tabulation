using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabulation_System.Core.Models
{
    public class Result : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JudgeNo { get; set; }

        public User Judge { get; set; }
        public int CriteriaId { get; set; }
        public Criteria Criteria { get; set; }
        public double Score { get; set; }
        
        public bool? IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
