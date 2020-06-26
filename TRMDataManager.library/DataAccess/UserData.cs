using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.library.Internal.DataAccess;
using TRMDataManager.library.Models;

namespace TRMDataManager.library.DataAccess
{
   public  class UserData
    {
        public List<UserModel> GetUserById(String Id) 
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Id = Id };
           var output= sql.LoadData<UserModel, dynamic>("dbo.spUserLookUp", p, "TRMData");

            return output;
        }
    }
}
