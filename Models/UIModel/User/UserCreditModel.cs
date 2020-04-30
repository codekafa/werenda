using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UIModel.User
{
    public class UserCreditModel
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public string CreditNo { get; set; }

        public string ExpDate { get; set; }

        public string SecNo { get; set; }

        public string FullName { get; set; }
        public bool IsMastercart { get; set; }

        public bool IsVisa { get; set; }
        public bool IsPrimary { get; set; }
    }
}
