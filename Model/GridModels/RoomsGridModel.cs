using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GridModels
{
    public class RoomsGridModel
    {
        public Int32 Id { get; set; }
        public Int32 Number { get; set; }
        public String Name { get; set; }
        public Decimal Cost { get; set; }
        public Int32 Capacity { get; set; }
    }
}
