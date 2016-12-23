using LogisticsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogisticsManagement.Controllers
{
    public class UserDetailController : ApiController
    {
        private  UserDetailRepo userDetailRepo;

        public UserDetailController()
        {
            this.userDetailRepo = new UserDetailRepo();
        }
        // GET: api/UserDetail
        public IEnumerable<UserDetail> Get()
        {
            return userDetailRepo.GetUserDetails();
        }

        // GET: api/UserDetail/5
        public UserDetail Get(int id)
        {
            return userDetailRepo.GetUserDetailById(id);
        }

        // POST: api/UserDetail
        public void Post([FromBody]UserDetail userDetail)
        {
            //    UserDetail userDetailObj = new UserDetail() { FirstName = value.FirstName, LastName = value.LastName, email = value.email, Address = value.Address, Phone = value.Phone, UserId = new Guid(); };
            try
            {
                userDetailRepo.AddUserDetail(userDetail);
            }
            catch (Exception)
            {
                
            }
        }

        // PUT: api/UserDetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserDetail/5
        public void Delete(int id)
        {
        }
    }
}
