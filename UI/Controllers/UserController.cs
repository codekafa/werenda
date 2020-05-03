using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace UI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        IUserService _userManager;
        IUserCreditService _creditManager;
        public UserController(IUserService userManager, IUserCreditService creditManager)
        {
            _userManager = userManager;
            _creditManager = creditManager;
        }
        public IActionResult Profile()
        {
            var email = User.Claims.Where(c => c.Type == ClaimTypes.Email)
               .Select(c => c.Value).SingleOrDefault();
            var user = _userManager.GetUserByEmail(email);
            return View(user);
        }

        public IActionResult MyReservations()
        {
            return View();
        }

        public IActionResult MyCredits()
        {
            var ids = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
               .Select(c => c.Value).SingleOrDefault();

            int id = Convert.ToInt32(ids);
            var list = _creditManager.GetUserCredits(id);
            return View(list);
        }

        public IActionResult MyHomes()
        {
            var ids = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
               .Select(c => c.Value).SingleOrDefault();

            int id = Convert.ToInt32(ids);
            var list = _creditManager.GetUserCredits(id);
            return View(list);
        }

        public IActionResult MyFavorites()
        {
            var ids = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
               .Select(c => c.Value).SingleOrDefault();

            int id = Convert.ToInt32(ids);
            var list = _creditManager.GetUserCredits(id);
            return View(list);
        }

        public IActionResult AddNewHome()
        {
            return View();
        }
    }
}