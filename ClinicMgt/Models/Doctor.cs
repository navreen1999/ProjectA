using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Doctor ID")]
        public int DoctorID { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Gender")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Enter Specialization")]
        [Display(Name ="Specialization")]
        public string Specialization { get; set; }

        [Required(ErrorMessage ="Required Field")]
        [Display(Name ="From")]
        [DataType(DataType.Time)]
        
        public DateTime VisitingHoursFrom { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "To")]
        [DataType(DataType.Time)]
     
        public DateTime VisitingHoursTo { get; set; }

        [Required(ErrorMessage ="Required Field")]
        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString  = "{dd/mm/yyyy}")]
        public DateTime VisitDate { get; set; }
    }
}
