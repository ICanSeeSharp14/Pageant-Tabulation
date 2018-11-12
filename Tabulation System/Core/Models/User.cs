using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Tabulation_System.Commons.Enums;

namespace Tabulation_System.Core.Models 
{
    public class User : Person , IAccount, IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int? ModifiedBy { get; set; }
       
    }
}
