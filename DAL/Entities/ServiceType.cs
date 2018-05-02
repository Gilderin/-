using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ServiceType
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
