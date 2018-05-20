using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GridModels
{
    public class ComplaintsGridModel
    {
        public Int32 Id { get; set; }
        public String Text { get; set; }

        public Int32 ClientId { get; set; }
    }
}
