using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class RightsService
    {
        public static UserRightsModel GetUserRights()
        {
            var rights = new UserRightsModel();
            rights.ClientsRights = new RightsModel()
            {
                CanRead = true,
                CanEdit = true,
                CanAdd = true,
                CanDelete = false
            }; //mock

            return rights;
        }
    }
}
