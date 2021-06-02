using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
   public interface IPatient
    {
        IEnumerable<Patient> GetPatients();
        void AddPat(Patient patient);
    }
}
