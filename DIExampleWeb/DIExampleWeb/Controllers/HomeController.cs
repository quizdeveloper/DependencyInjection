using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DIExampleWeb.Models;
using DIExampleWeb.Bsl;

namespace DIExampleWeb.Controllers
{
    public class HomeController : Controller
    {
        private IStudentBsl _studentBsl;
        public HomeController(IStudentBsl studentBsl)
        {
            _studentBsl = studentBsl;
        }

        public IActionResult Index()
        {
            var lstStudent = _studentBsl.GetAll();
            return View(lstStudent);
        }
    }
}
