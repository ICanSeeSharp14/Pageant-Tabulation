using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabulation_System.Commons.Enums;

namespace Tabulation_System.Core.Models
{
    public class Candidate : Person , IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CandidateNo { get; set; }
        public string MiddleName { get; set; }

        public string HomeTown { get; set; }
        public Gender Gender { get; set; }

        public string Attainment { get; set; }
        public string School { get; set; }
        public string Course { get; set; }
        public string YearLevel { get; set; }
        public string Weight  { get; set; }
        public string Height { get; set; }
        public string Biography { get; set; }
        public double Hipline { get; set; }
        public double Waistline { get; set; }
        public double Bustline { get; set; }
        public byte? Image { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
