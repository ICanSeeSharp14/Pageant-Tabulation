using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabulation_System.Core.Models
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int? Sequence { get; set; }

        public int EventId { get; set; }
      
       
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public double Percentage { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
