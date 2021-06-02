using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
   public interface IAppointment
    {
        IEnumerable<Appointment> GetAppointments();
        // Appointment GetAppointmentByPatientID(int id);
        void AddApp(Appointment appointment);
        void DeleteAppoinment(Appointment t);
        Appointment GetByID(int id);
        
    }
}
