using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using TRMDataManager.library.DataAccess;
using TRMDataManager.library.Models;

namespace TRMDataManager.Controllers
{

    [Authorize]
   
    public class UserController : ApiController
    {
        // GET: User/Details/5
        public List<UserModel> GetById()
        {
            String userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            return data.GetUserById(userId);
           
        }

        
       
    }
}
