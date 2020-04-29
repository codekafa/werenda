using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace UI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        IUserService _userManager;
        public UserController(IUserService userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Profile()
        {
            var email = User.Claims.Where(c => c.Type == ClaimTypes.Email)
               .Select(c => c.Value).SingleOrDefault();

            var user = _userManager.GetUserByEmail(email);

            return View(user);
        }

        public IActionResult Reservation()
        {
            return View();
        }
    }
}