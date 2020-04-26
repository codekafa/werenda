using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UIModel
{
    public class LoginResultModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string FullName { get { return Name + " " + LastName; } }

        public int UserType { get; set; }
    }
}
