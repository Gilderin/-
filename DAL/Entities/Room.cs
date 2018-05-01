using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Room
    {
        public Int32 Id { get; set; }
        public Int32 Number { get; set; }
        public String Status { get; set; }
        public Int32 Capacity { get; set; }

        public Int32 RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
