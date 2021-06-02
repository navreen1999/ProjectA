using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
    public class SpecializationRepo : ISpecialization
    {
        private ClinicContext _context;

        public SpecializationRepo(ClinicContext context)
        {
            _context = context;
        }
        public void Add(Specialization s)
        {
            _context.Specializations.Add(s);
            _context.SaveChanges();
        }
    }
}
