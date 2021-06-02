using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Patient ID")]
        public int PatientID { get; set; }
        
        [Required(ErrorMessage = "Enter Patient's First Name")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Enter Patient's Last Name")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage ="This field is required")]
        [Display(Name ="Gender")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Enter age")]
        [Range(0, 120)]
        [Display(Name ="Age")]
        public int Age { get; set; }
        
        [Required(ErrorMessage ="This field is required")]
        [Display(Name ="Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
