using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCreate;
using Models.UIModel.User;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Business.ConCreate
{
    public class UserCreditCartManager : IUserCreditService
    {
        IUserCreditDal _userCreditDal;
        public UserCreditCartManager(IUserCreditDal userCreditDal)
        {
            _userCreditDal = userCreditDal;
        }
        public UserCreditModel GetCreditCartWithDecode(user_credits credit)
        {
            UserCreditModel result = new UserCreditModel();

            result.CreditNo = credit.credit_no;
            result.ExpDate = credit.exp_date;
            result.FullName = credit.full_name;
            result.Id = credit.id;
            result.IsMastercart = credit.is_mastercart;
            result.IsPrimary = credit.is_primary;
            result.IsVisa = credit.is_visa;
            result.SecNo = credit.sec_no;
            result.UserId = credit.user_id;
            return result;

        }

        public List<UserCreditModel> GetUserCredits(int user_id)
        {
            var list = _userCreditDal.GetList(x => x.user_id == user_id);

            List<UserCreditModel> result = new List<UserCreditModel>();

            foreach (var item in list)
            {
                UserCreditModel  resultItem = GetCreditCartWithDecode(item);
                result.Add(resultItem);
            }

            return result;
        }
    }
}
