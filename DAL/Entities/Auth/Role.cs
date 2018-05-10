using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Auth
{
    public class Role
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        public Int32 ActorId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
