using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Models
{
    public class Appointment
    {
        [Key]
        [Display(Name ="Appointment ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentID { get; set; }

        [ForeignKey("Patient")]
        [Display(Name ="Patient ID")]
        [Required(ErrorMessage = "Enter Patient ID")]
        public int PatientID { get; set; }

        [ForeignKey("Doctor")]
        [Display(Name ="Doctor ID")]
        [Required(ErrorMessage ="Enter Doctor ID")]
        public int DoctorID { get; set; }

        [Display(Name ="Specialization")]
        [Required(ErrorMessage = "Enter Specialization")]
        public string Specialization { get; set; }

        [Required]
        [Display(Name ="Doctors First Name")]
        public string DoctorFirstName { get; set; }

        [Required]
        [Display(Name = "Doctors Last Name")]
        public string DoctorLastName { get; set; }

        [Required(ErrorMessage = "Enter Appointment Time")]
        [DataType(DataType.Time)]
        [Display(Name ="Appointment Time")]
        
        public DateTime AppointmentTime { get; set; }

        [Required(ErrorMessage ="Enter Date Of Appointment")]
        [DataType(DataType.Date)]
        [Display(Name ="Appointment Date")]
        
        public DateTime AppointmentDate { get; set; }
    }
}
