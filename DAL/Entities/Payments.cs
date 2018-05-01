using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Payment
    {
        public Int32 Id { get; set; }
        public Decimal Money { get; set; }
        public DateTimeOffset ArrivalDate { get; set; }
        public DateTimeOffset DepartureDate { get; set; }
        public Int32 ClientId { get; set; }
        public Int32 PeopleCount { get; set; }
        public String ReceiptOfPayment { get; set; }
        virtual public Client Client { get; set; }
        public Int32 RoomId { get; set; }
        virtual public Room Room { get; set; }
        public Int32 EmployeeId { get; set; }
        virtual public Employee Employee { get; set; }

    }
}
