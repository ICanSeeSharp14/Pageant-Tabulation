using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabulation_System.Commons.Enums;

namespace Tabulation_System.Core.Models
{
    public interface IAccount 
    {
        string Username { get; set; }
        string Password { get; set; }
        UserType UserType { get; set; }
    }
}
