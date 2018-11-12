using System;
using System.ComponentModel.DataAnnotations;

namespace Tabulation_System.Core.Models
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
        bool? IsActive { get; set; }
      
        DateTime? DateTimeCreated { get; set; }
        int? CreatedBy { get; set; }

        DateTime? DateTimeModified { get; set; }

        int? ModifiedBy { get; set; }



    }
}