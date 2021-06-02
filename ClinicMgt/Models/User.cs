using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Enter User Name")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
    }
}
