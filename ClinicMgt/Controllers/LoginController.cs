using ClinicMgt.Models;
using ClinicMgt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Controllers
{
    public class LoginController : Controller
    {
        private ILogin<User> _repo;

        public LoginController(ILogin<User> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            try
            {
                if (_repo.Login(user))
                {
                    ViewBag.Message = "Login Sucessfull";
                    return RedirectToAction("Indexes", "Doctor");

                }
            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}
