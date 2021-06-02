using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
    public class PatientRepo:IPatient
    {
        private ClinicContext _context;

        public PatientRepo(ClinicContext context)
        {
            _context = context;
        }
        public void AddPat(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        //public Patient GetPatientByID(int id)
        //{
        //    return _context.Patients.SingleOrDefault(a => a.PatientID == id);
        //}

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }
    }
}
