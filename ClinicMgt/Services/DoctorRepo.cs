using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
    public class DoctorRepo:IDoctor
    {
        private ClinicContext _context;

        public DoctorRepo(ClinicContext context)
        {
            _context = context;
        }
        public void AddDoc(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        //public Doctor GetDoctorByID(int id)
        //{
        //    return _context.Doctors.SingleOrDefault(a => a.DoctorID == id);
        //}


        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        //public IEnumerable<Doctor> GetDoctorsBySpecialization(string spec)
        //{
        //    var dname = from d in _context.Doctors where (d.Specialization == spec) select d.FirstName.ToList();
        //    return List<dname>;
        //}
        //public List<string> GetDoctorBySpec(string spec)
        //{
        //    List<string> dname = (from s in _context.Doctors
        //                          where s.Specialization == spec
        //                          select s.FirstName).ToList();
        //    return dname;
        //}
    }
}
