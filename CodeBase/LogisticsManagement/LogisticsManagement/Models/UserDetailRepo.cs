using LogisticsManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogisticsManagement.Models
{
    public class UserDetailRepo : IUserDetailRepo
    {
        ParcelMgmntSysEntities parcelObj = new ParcelMgmntSysEntities();
        public void AddUserDetail(UserDetail userDetail)
        {
            parcelObj.UserDetails.Add(userDetail);
            parcelObj.SaveChanges();
         //   throw new NotImplementedException();
        }

        public void DeleteUserDetail(int userDetailId)
        {

            throw new NotImplementedException();
        }

        public UserDetail GetUserDetailById(int userDetailId)
        {
            
              return  parcelObj.UserDetails.SingleOrDefault(a => a.UserId == userDetailId);
        }

        public IEnumerable<UserDetail> GetUserDetails()
        {
            return parcelObj.UserDetails.ToList();
        }

        public void UpadateUserDetail(UserDetail userDetail)
        {
            throw new NotImplementedException();
        }
    }
}