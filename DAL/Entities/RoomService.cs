using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class RoomService
    {
        public Int32 Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public Int32 EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public Int32 PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
