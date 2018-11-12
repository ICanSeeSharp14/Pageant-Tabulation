using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabulation_System.Core.Models
{
    public class Judge : Person , IEntity 
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int? ModifiedBy { get; set; }


    }
}
