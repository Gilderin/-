using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Client
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }
        public String SecondName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public String PasportNumber { get; set; }

        virtual public ICollection<Payment> Payments { get; set; }
    }
}
