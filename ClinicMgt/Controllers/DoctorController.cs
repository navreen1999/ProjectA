using ClinicMgt.Models;
using ClinicMgt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Controllers
{
    public class DoctorController : Controller
    {
        private IDoctor _drepo;
        private ISpecialization _srepo;

        public DoctorController(IDoctor drepo,ISpecialization srepo)
        {
            _drepo = drepo;
            _srepo = srepo;
        }
        [HttpGet]
        public IActionResult IndexDoc()
        {
            List<Doctor> doctor = _drepo.GetDoctors().ToList();
            return View(doctor);
        }
        public IActionResult AddDoctor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
           _drepo.AddDoc(doctor);
            Specialization s = new Specialization();
            s.Specialised = doctor.Specialization;
            s.FirstName = doctor.FirstName;
            s.LastName = doctor.LastName;
            _srepo.Add(s);
            return RedirectToAction("Indexes");
        }
        public IActionResult Indexes()
        {
            return View();
        }
    }
}
