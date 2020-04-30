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
using Models;
using Models.UIModel;
using Models.UIModel.User;
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

            if (result != null && result.Id > 0)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Email, result.Email));
                identity.AddClaim(new Claim(ClaimTypes.GivenName, result.Name));
                identity.AddClaim(new Claim(ClaimTypes.Surname, result.LastName));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));

                switch (result.UserType)
                {
                    case 1:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                        break;
                    case 2:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                        break;
                    default:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                        break;
                }
                
                identity.AddClaim(new Claim(ClaimTypes.Name , result.FullName));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        public async Task<ResultModel> RegisterUserAsync([FromBody]RegisterUserModel registerModel)
        {
            ResultModel resultregister = new ResultModel();
            resultregister = _userService.RegisterUser(registerModel);

            if (!resultregister.IsSuccess)
            {
                return resultregister;
            }

            LoginResultModel result = _userService.LoginUser(registerModel.Email, registerModel.Password);

            if (result != null && result.Id > 0)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Email, result.Email));
                identity.AddClaim(new Claim(ClaimTypes.GivenName, result.Name));
                identity.AddClaim(new Claim(ClaimTypes.Surname, result.LastName));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));

                switch (result.UserType)
                {
                    case 1:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                        break;
                    case 2:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                        break;
                    default:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                        break;
                }

                identity.AddClaim(new Claim(ClaimTypes.Name, result.FullName));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return resultregister;
            }
            else
            {
                resultregister.IsSuccess = false;
                resultregister.Message.Add("error_register");
                return resultregister;
            }
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Werenda");
        }
    }
}