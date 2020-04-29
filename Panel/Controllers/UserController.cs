using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using CommonUI.Constants;
using Microsoft.AspNetCore.Mvc;
using Models.UIModel;
using Panel.SessionManager;
using static CommonUI.Constants.EnumList;

namespace Panel.Controllers
{
    public class UserController : Controller
    {

        ISessionManager _sessionManager;
        IUserService _userManager;
        public UserController(ISessionManager sessionManager, IUserService userManager)
        {
            _sessionManager = sessionManager;
            _userManager = userManager;
        }

        public ActionResult Login()
        {
            return View();
        } 
        public JsonResult LoginUser(LoginUserModel userModel)
        {
            var result = _userManager.LoginUser(userModel.Email, userModel.Password);

            if (result.Id > 0 && result.UserType == (int)UserTypes.Admin)
            {
                _sessionManager.SetObject(SessionKeyConstants.CurrentUser, result);
                return new JsonResult(true);
            }
            return new JsonResult(false);
        }

        public JsonResult LogoutUser()
        {
            _sessionManager.DeleteObject(SessionKeyConstants.CurrentUser);
            return new JsonResult(true);
        }
    }
}