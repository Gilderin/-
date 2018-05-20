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
            PaymentsRigths = new RightsModel();
            ComplaintsRights = new RightsModel();
            ServicesRights = new RightsModel();
        }
        public RightsModel ClientsRights { get; set; }
        public RightsModel RoomsRights { get; set; }
        public RightsModel EmployeesRights { get; set; }

        public RightsModel PaymentsRigths { get; set; }
        public RightsModel ComplaintsRights  { get; set; }
        public RightsModel ServicesRights { get; set; }
    }
}
