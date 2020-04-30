using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UIModel.User
{
    public class RegisterUserModel
    {
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordAgain { get; set; }
    }
}
