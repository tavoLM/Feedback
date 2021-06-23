using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IQISService.Interface
{
    public interface IUserRepository
    {
         IEnumerable<UserModel> GetAll();
         UserModel GetUser(UserModel user);
    }
}
