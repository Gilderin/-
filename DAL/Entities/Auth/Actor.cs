using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Auth
{
    public class Actor
    {
        public Int32 Id { get; set; }

        public String Login { get; set; }
        public String Password { get; set; }

        public Role Role { get; set; }

        public Int32 EmployeeId { get; set; }
        virtual public Employee Employee { get; set; }
    }
}
