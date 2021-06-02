using ClinicMgt.Models;
using ClinicMgt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Controllers
{
    public class AppointmentController : Controller
    {
        private IAppointment _arepo;
        private ClinicContext _context;

        public AppointmentController(IAppointment arepo,ClinicContext context)
        {
            _arepo = arepo;
            _context = context;
        }
        [HttpGet]
        public IActionResult IndexApp()
        {
            List<Appointment> appointment = _arepo.GetAppointments().ToList();
            return View(appointment);
        }
        [HttpGet]
        public IActionResult Specialization()
        {
            return View();
        }
         [HttpPost]
        public IActionResult AddApp(string Specialization)
        {
            TempData["spec"] = Specialization;
            ViewBag.fname = (from s in _context.Doctors
                            where s.Specialization == Convert.ToString(TempData["spec"])
                            select s.FirstName).ToList();
            ViewBag.lname = (from s in _context.Doctors
                            where s.Specialization == Convert.ToString(TempData["spec"])
                            select s.LastName).ToList();
            ViewBag.did = (from s in _context.Doctors
                           where s.Specialization == Convert.ToString(TempData["spec"])
                           select s.DoctorID).ToList();
            ViewBag.IfPageLoad = true;
            return View();
        }
       
        [HttpPost]
        public IActionResult AppSave(Appointment appointment)
        {
            ViewBag.IfPageLoad = false;
            //List<Appointment> count = _context.Appointments.Where(e => e.DoctorID == appointment.DoctorID)
            //    .Where(e => e.AppointmentDate == appointment.AppointmentDate)
            //    .Where(e => e.AppointmentTime == appointment.AppointmentTime).ToList();
            List<Appointment> count = _context.Appointments.Where(e => e.DoctorID == appointment.DoctorID &&
                               e.AppointmentDate == appointment.AppointmentDate &&
                               e.AppointmentTime == appointment.AppointmentTime).ToList();
            int c = count.Count();
            if (c==0)
            {
                _arepo.AddApp(appointment);
                ViewBag.Message = "Record added successfully";
                return RedirectToAction("Indexes", "Doctor");
           
            }
            else
            {
                ViewBag.Message = "This slot is already booked.Please choose another slot";
                return RedirectToAction("Specialization");
            }
        }
        //[HttpPosst]
        //public IActionResult AddApp(Appointment appointment)
        //{
        //    _arepo.AddApp(appointment);
        //    //TempData["fname"] = (from s in _context.Doctors
        //    //                      where s.Specialization == appointment.Specialization
        //    //                      select s.FirstName).ToList();
        //    //TempData["lname"] = (from s in _context.Doctors
        //    //                       where s.Specialization == appointment.Specialization
        //    //                       select s.LastName).ToList();
        //    TempData["spec"] = appointment.Specialization;

        //    return RedirectToAction("Fields");
        //}
        //[HttpPost]
        //public IActionResult Fields()
        //{
        //    string spec = (string)TempData["spec"];
        //    ViewBag.fname = (from s in _context.Doctors
        //                         where s.Specialization == spec
        //                         select s.FirstName).ToList();
        //    ViewBag.lname = (from s in _context.Doctors
        //                     where s.Specialization == spec
        //                     select s.LastName).ToList();
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult GetSpec(string spec)
        //{
        //    var 
        //}
        //public IActionResult FilterDoc(string spec)
        //{
        //    spec = TempData["spec"];
        //    var docname = _drepo.GetDoctorsBySpecialization(spec).ToList();
        //}

        public IActionResult DeleteApp(int id)
        {
            Appointment app = _arepo.GetByID(id);
            return View(app);
        }
        [HttpPost]
        public IActionResult DeleteApp(Appointment app)
        {
            _arepo.DeleteAppoinment(app);
            return RedirectToAction("Indexes", "Doctor");
        }
        //[HttpGet]
        //public IActionResult PatientId()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult IndexPatient(int PatientID)
        //{
        //    List<Appointment> app = _context.Appointments.Where(a => a.PatientID == PatientID).ToList();
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteApp(Appointment app)
        //{
        //    _arepo.DeleteAppoinment(app);
        //    return RedirectToAction("Indexes", "Doctor");
        //}
        //[HttpPost]
        //public IActionResult DeleteAp(Appointment app)
        //{
        //    _arepo.DeleteAppoinment(app);
        //    return RedirectToAction("Indexes", "Doctor");
        //}
    }
}
