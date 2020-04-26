using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Panel.Controllers
{
    public class PanelController : Controller
    {
        IUserService _userManager;
        public PanelController()
        {

        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Users()
        {

            
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
    }
}