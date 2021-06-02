using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
  public  interface ILogin<T>
    {
        bool Login(T t);
    }
}
