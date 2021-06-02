using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
   public interface IDoctor
    {
        IEnumerable<Doctor> GetDoctors();
        //  Doctor GetDoctorByID(int id);
        void AddDoc(Doctor doctor);
        //IEnumerable<Doctor> GetDoctorsBySpecialization(string spec);
        //  List<string> GetDoctorBySpec(string spec);
    }
}
