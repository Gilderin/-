using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Auth
{
    public class Permission
    {
        public Int32 Id { get; set; }
        public AdminUnit AdminUnit { get; set; }
        public PermissionType PermissionType { get; set; }
    }
}
