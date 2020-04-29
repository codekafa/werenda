using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Business.Abstract;
using CommonUI.Constants;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Models.UIModel;
using UI.SessionManager;

namespace UI.Controllers
{
    public class WerendaController : Controller
    {
        IUIService _uIService;
        IUserService _userService;
        ISessionManager _sessionManager;
        public WerendaController(IUIService uIService, IUserService userService, ISessionManager sessionManager)
        {
            _uIService = uIService;
            _userService = userService;
            _sessionManager = sessionManager;
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
        [AllowAnonymous]
        public async Task<IActionResult> LoginUserAsync([FromBody] LoginUserModel loginModel)
        {
            LoginResultModel result = _userService.LoginUser(loginModel.Email, loginModel.Password);

            if (result != null)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, result.Email));
                identity.AddClaim(new Claim(ClaimTypes.GivenName, result.Name));
                identity.AddClaim(new Claim(ClaimTypes.Surname, result.LastName));
                identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        public JsonResult RegisterUser()
        {
            return new JsonResult(true);
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Werenda");
        }

    }
}