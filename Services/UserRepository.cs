using IQISService.Interface;
using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    public class UserRepository : IUserRepository
    {
        private feedbackEntities db = new feedbackEntities();

        


        public IEnumerable<UserModel> GetAll()
        {
            IEnumerable<user> userList = db.users.ToList();

            IEnumerable<UserModel> userModelList = new List<UserModel>();

            AutoMapper.Mapper.Map(userList, userModelList);

            return userModelList;
        }

        public UserModel GetUser(UserModel user)
        {
            user _user = db.users.Where(u => u.id.Equals(user.id) && u.password.Equals(user.password)).SingleOrDefault();
            UserModel userModel=new UserModel();

            AutoMapper.Mapper.Map(_user, userModel);


            return userModel;
        }

        

     
    }
}