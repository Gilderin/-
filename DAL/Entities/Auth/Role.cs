using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Auth
{
    public class Role
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
