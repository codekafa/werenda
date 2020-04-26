using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCreate;
using Models.UIModel;
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
            var user = GetUserByEmailAndPass(email, password);

            if (user != null && user.is_active && user.is_approve)
            {
                result.Id = user.id;
                result.Name = user.first_name;
                result.LastName = user.last_name;
                result.Phone = user.phone;
                result.UserType = user.user_type;
            }
            return result;
        }

        public LoginResultModel LogoutUser(string email)
        {
            throw new NotImplementedException();
        }

        public users RegisterUser(users newUser)
        {
            _userDal.Add(newUser);
            return newUser;
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
