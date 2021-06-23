using AttributeRouting.Web.Http;
using IQISService.Interface;
using IQISService.Models;
using IQISService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IQISService.Controllers
{
    public class UserController : ApiController
    {
        private UserRepository _userRepository = new UserRepository();

        public UserController(){
            
        }
        
        [HttpGet]
        [GET("api/Users/")]
        public IEnumerable<UserModel> GetAll(){

            return _userRepository.GetAll();
        }

        [HttpPost]
        [POST("api/Users/")]
        public UserModel GetUser(UserModel user)
        {
            return _userRepository.GetUser(user);
           
        }

       
        
    }
}
