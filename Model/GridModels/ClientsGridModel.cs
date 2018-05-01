using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GridModels
{
    public class ClientsGridModel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String SecondName { get; set; }
        public String PassportNumber { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
