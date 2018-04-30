using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class RoomType
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        public Decimal Cost { get; set; }

        virtual public ICollection<Room> Rooms { get; set; }
    }
}
