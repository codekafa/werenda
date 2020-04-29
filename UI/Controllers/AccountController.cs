using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Business.Abstract;
using CommonUI.Constants;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.UIModel;
using UI.SessionManager;

namespace UI.Controllers
{
    [Route("api/Account/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        IUIService _uIService;
        IUserService _userService;
        ISessionManager _sessionManager;
        public AccountController(IUIService uIService, IUserService userService, ISessionManager sessionManager)
        {
            _uIService = uIService;
            _userService = userService;
            _sessionManager = sessionManager;
        }

        [HttpPost]
        public JsonResult LoginUser([FromBody] LoginUserModel model)
        {
            LoginResultModel result = _userService.LoginUser(model.Email, model.Password);

            if (result != null)
            {
                _sessionManager.SetObject(SessionKeyConstants.CurrentUser, result);
                var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, model.Email)
                            };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync(principal).Wait();

                return new JsonResult(true);
            }
            else
            {
                return new JsonResult(false);
            }
        }

        public JsonResult RegisterUser()
        {
            return new JsonResult(true);
        }
    }
}