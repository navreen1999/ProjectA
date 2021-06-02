using ClinicMgt.Models;
using ClinicMgt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Controllers
{
    public class PatientController : Controller
    {
        private IPatient _prepo;

        public PatientController(IPatient prepo)
        {
            _prepo = prepo;
        }
        [HttpGet]
        public IActionResult IndexPatient()
        {
            List<Patient> patient = _prepo.GetPatients().ToList();
            return View(patient);
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {
            _prepo.AddPat(patient);
            return RedirectToAction("Indexes","Doctor");
        }
    }
}
