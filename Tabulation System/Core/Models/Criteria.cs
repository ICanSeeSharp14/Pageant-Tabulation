using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabulation_System.Core.Models
{
    public class Criteria : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CriteriaName { get; set; }
        public int Percentage { get; set; }
        public double MinimumScore { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
