using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Service
    {
        public Int32 Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public Decimal Cost { get; set; }

        public Int32 ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public Int32 paymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
