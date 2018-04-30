using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserRightsModel
    {
        public UserRightsModel()
        {
            ClientsRights = new RightsModel();
            RoomsRights = new RightsModel();
            EmployeesRights = new RightsModel();
        }
        public RightsModel ClientsRights { get; set; }
        public RightsModel RoomsRights { get; set; }
        public RightsModel EmployeesRights { get; set; }
    }
}
