using Entities.ConCreate;
using Models.UIModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        users GetUserByEmailAndPass(string email, string pass);
        users GetUserByEmail(string email);
        LoginResultModel LoginUser(string email, string password);
        LoginResultModel LogoutUser(string email);
        users GetUserByPhone(string phone);
        users GetUserById(int id);
        users RegisterUser(users newUser);
        users UpdateUser(users newUser);
        user_address AddNewAddress(user_address address);
        user_address UpdateUserAddress(user_address address);

        List<user_address> GetAddressesByUserId(int user_id);
        void RemoveUserAddress(user_address address);

    }
}
