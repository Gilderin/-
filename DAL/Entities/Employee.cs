using Entity.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Employee
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String SecondName { get; set; }

        public String NumberPhone { get; set; }
        public virtual Position Position { get; set; }
        public Int32 ActorId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual ICollection<RoomService> RoomServices { get; set; }
    }
}
