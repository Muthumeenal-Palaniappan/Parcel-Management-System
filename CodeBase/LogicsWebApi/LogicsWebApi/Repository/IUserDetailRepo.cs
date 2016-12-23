using LogicsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsWebApi.Repository
{
    public interface IUserDetailRepo
    {

        IEnumerable<UserDetail> GetUserDetails();
        UserDetail AddUserDetail(UserDetail userDetail);
        void UpadateUserDetail(UserDetail userDetail);
        void DeleteUserDetail(int userDetailId);
        UserDetail GetUserDetailById(int userDetailId);
    }
}
