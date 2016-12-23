using LogicsWebApi.Models;
using LogicsWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicsWebApi.Models
{
    public class UserDetailRepo : IUserDetailRepo
    {
        ParcelMgmntSysEntities parcelObj = new ParcelMgmntSysEntities();
        public UserDetail AddUserDetail(UserDetail userDetail)
        {
            try {
                parcelObj.UserDetails.Add(userDetail);
                parcelObj.SaveChanges();
               
            }
            catch(Exception ex)
            {

            }
            return userDetail;
         //   throw new NotImplementedException();
        }

        public void DeleteUserDetail(int userDetailId)
        {
            UserDetail delItem = parcelObj.UserDetails.SingleOrDefault(i => i.UserId == userDetailId);
            if (delItem != null)
                parcelObj.UserDetails.Remove(delItem);
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
            UserDetail updateItem = parcelObj.UserDetails.Where(x => x.UserId   == userDetail.UserId).FirstOrDefault();
            if (updateItem != null)
            { 
                parcelObj.UserDetails.Attach(updateItem);
                parcelObj.Entry(updateItem).State = System.Data.Entity.EntityState.Modified;
                parcelObj.SaveChanges();
            }
        }
    }
}