using Entities.ConCreate;
using Models.UIModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserCreditService
    {
        List<UserCreditModel> GetUserCredits(int user_id);

        UserCreditModel GetCreditCartWithDecode(user_credits credit);
    }
}
