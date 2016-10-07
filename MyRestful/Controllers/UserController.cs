using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace MyRestful.Controllers
{
    public class UserController : ApiController
    {
        Models.User[] users = new Models.User[]
        {
            new  Models.User { ID = 1, lower_user_name = "石曼迪", user_key = "mady" },
            new  Models.User { ID = 2, lower_user_name = "狗王", user_key = "taisanDog" },
            new  Models.User { ID = 3, lower_user_name = "道长", user_key = "kongque" }
        };

        public IEnumerable<Models.User> GetAllUsers()
        {
            return users;
        }
        public Models.User GetUserById(int id)
        {
            var user = users.FirstOrDefault((p) => p.ID == id);
            if (user == null)
             {
            throw new HttpResponseException(HttpStatusCode.NotFound);
             }
            return user;
        }
        public Models.User GetUserById2(int id)
        {
            var user = users.FirstOrDefault((p) => p.ID == id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
        }
    }
}
