using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities.Auth
{
    public class Permission
    {
        public Int32 Id { get; set; }

        public Int32 RoleId { get; set; }
        public virtual Role Role { get; set; }
        public Int32 AdminUnitId { get; set; }
        public virtual AdminUnit AdminUnit { get; set; }
        public Int32 PermissionTypeId { get; set; }
        public virtual PermissionType PermissionType { get; set; }
    }
}
