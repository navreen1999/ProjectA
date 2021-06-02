using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
    public class AppointmentRepo : IAppointment
    {
        private ClinicContext _context;

        public AppointmentRepo(ClinicContext context)
        {
            _context = context;
        }
        public void AddApp(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void DeleteAppoinment(Appointment t)
        {
            _context.Appointments.Remove(t);
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetByID(int id)
        {
            Appointment app = _context.Appointments.FirstOrDefault(p => p.AppointmentID == id);
            return app;
        }
    }
}
