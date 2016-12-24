using LogicsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace LogicsWebApi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
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
        public dynamic Get(string sidx, string sord, int page, int rows)
        {
           
            var userDetails = userDetailRepo.GetUserDetails() as IEnumerable<UserDetail>;
            var pageIndex = Convert.ToInt32(page) - 1;
            var pageSize = rows;
            var totalRecords = userDetails.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);
            userDetails = userDetails.Skip(pageIndex * pageSize).Take(pageSize);
            return new
            {
                total = totalPages,
                page = page,
                records = totalRecords,
                rows = (
                    from userDetail in userDetails
                    select new
                    {
                        id = userDetail.UserId.ToString(),
                        cell = new object[] {
                         userDetail.UserId.ToString(),
                         userDetail.FirstName,
                         userDetail.LastName,
                         userDetail.Address,
                         userDetail.email,
                         userDetail.Phone.ToString()

                        }
                    }).ToList()

            };
            // return userDetailRepo.GetUserDetails();
        }

        // GET: api/UserDetail/5
        public UserDetail Get(int id)
        {
            return userDetailRepo.GetUserDetailById(id);
        }

        // POST: api/UserDetail
        public HttpResponseMessage Post(UserDetail userDetail)
        {
           
            //    UserDetail userDetailObj = new UserDetail() { FirstName = value.FirstName, LastName = value.LastName, email = value.email, Address = value.Address, Phone = value.Phone, UserId = new Guid(); };
          
                var userDet = userDetailRepo.AddUserDetail(userDetail);
            HttpResponseMessage response = Request.CreateResponse<UserDetail>(HttpStatusCode.Created, userDet);
            string uri = Url.Link("DefaultApi", new { id = userDetail.UserId });
            response.Headers.Location = new Uri(uri);
            return response;

        }

        // PUT: api/UserDetail/5
        public void Put(UserDetail userDetail)

        {
            userDetailRepo.UpadateUserDetail(userDetail);
        }

        // DELETE: api/UserDetail/5
        public HttpResponseMessage Delete(int id)
        {
            userDetailRepo.DeleteUserDetail(id);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
