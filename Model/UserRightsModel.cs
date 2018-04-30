using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserRightsModel
    {
        public RightsModel ClientsRights { get; set; }
        public RightsModel RoomsRights { get; set; }
    }
}
