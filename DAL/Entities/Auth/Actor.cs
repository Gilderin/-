using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Auth
{
    public class Actor
    {
        public Int32 Id { get; set; }

        public String Login { get; set; }
        public String Password { get; set; }

        public Int32 RoleId { get; set; }
        public virtual Role Role { get; set; }
        public Int32 EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
