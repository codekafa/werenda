using Entities.ConCreate;
using Models;
using Models.UIModel;
using Models.UIModel.User;
using System.Collections.Generic;

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
        ResultModel RegisterUser(RegisterUserModel newUser);
        users UpdateUser(users newUser);
        user_address AddNewAddress(user_address address);
        user_address UpdateUserAddress(user_address address);

        List<user_address> GetAddressesByUserId(int user_id);
        void RemoveUserAddress(user_address address);

    }
}
