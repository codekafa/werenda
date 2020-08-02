using Business.Abstract;
using CommonUI.Constants;
using DataAccess.Abstract;
using Entities.ConCreate;
using Models;
using Models.UIModel;
using Models.UIModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCreate
{
    public class UserManager : IUserService
    {

        IUserDal _userDal;
        IUserAddressDal _userAddressDal;

        public UserManager(IUserDal userDal, IUserAddressDal userAddressDal)
        {
            _userDal = userDal;
            _userAddressDal = userAddressDal;
        }
        public user_address AddNewAddress(user_address address)
        {
            _userAddressDal.Add(address);
            return address;
        }

        public List<user_address> GetAddressesByUserId(int user_id)
        {
            var addresses = _userAddressDal.GetList(x => x.user_id == user_id);
            return addresses;
        }

        public users GetUserByEmail(string email)
        {
            return _userDal.Get(x => x.email == email);
        }

        public users GetUserByEmailAndPass(string email, string pass)
        {
            return _userDal.Get(x => x.email == email && x.password == pass);
        }

        public users GetUserById(int id)
        {
            return _userDal.Get(x => x.id == id);
        }

        public users GetUserByPhone(string phone)
        {
            return _userDal.Get(x => x.phone == phone);
        }

        public LoginResultModel LoginUser(string email, string password)
        {
            LoginResultModel result = new LoginResultModel();
            try
            {
                var user = GetUserByEmailAndPass(email, password);

                if (user != null && user.is_active && user.is_approve)
                {
                    result.Id = user.id;
                    result.Email = user.email;
                    result.Name = user.first_name;
                    result.LastName = user.last_name;
                    result.Phone = user.phone;
                    result.UserType = user.user_type;
                }
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }

        public LoginResultModel LogoutUser(string email)
        {
            throw new NotImplementedException();
        }

        public ResultModel RegisterUser(RegisterUserModel registerModel)
        {
            ResultModel result = new ResultModel();

            if (string.IsNullOrEmpty(registerModel.Email))
            {
                result.Message.Add("email_is_required");
                return result;
            }

            if (registerModel.Password != registerModel.PasswordAgain)
            {
                result.Message.Add("password_again");
                return result;
            }

            var is_exist_email = GetUserByEmail(registerModel.Email);

            if (is_exist_email!= null || is_exist_email.id > 0)
            {
                result.Message.Add("already_exist_email");
                return result;
            }

            try
            {
                users newUser = new users();
                newUser.create_date = DateTime.Now;
                newUser.email = registerModel.Email;
                newUser.first_name = registerModel.FirstName;
                newUser.is_active = true;
                newUser.is_approve = true;
                newUser.last_name = registerModel.LastName;
                newUser.password = registerModel.Password;
                newUser.user_type = (int)EnumList.UserTypes.User;
                var user = _userDal.Add(newUser);

                // TODO mail

                result.Data = user;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message.Add("error_register");
            }
            return result;
        }

        public void RemoveUserAddress(user_address address)
        {
            _userAddressDal.Delete(address);
        }

        public users UpdateUser(users updateUser)
        {
            _userDal.Update(updateUser);
            return updateUser;
        }

        public user_address UpdateUserAddress(user_address address)
        {
            _userAddressDal.Update(address);
            return address;
        }
    }
}
