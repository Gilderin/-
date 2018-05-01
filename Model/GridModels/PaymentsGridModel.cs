using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GridModels
{
    class PaymentsGridModel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String SecondName { get; set;}
        public DateTimeOffset ArrivalDate { get; set; }
        public DateTimeOffset DepartureDate { get; set; }
        public Int32 PeopleCount { get; set; }
        public Int32 Number { get; set; }
        public Decimal Cost { get; set; }
        public String ReceiptOfPayment { get; set; }

        public String EmployeeName { get; set; }
    }
}
