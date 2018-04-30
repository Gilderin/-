using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Position
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        virtual public ICollection<Employee> Employees { get; set; }

    }
}
