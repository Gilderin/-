using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class ComplaintCategoryJoin
    {
        public Int32 ComplaintCategoryId { get; set; }
        public virtual ComplaintCategory ComplaintCategory { get; set; }

        public Int32 ComplaintId { get; set; }
        public virtual Complaint Complaint { get; set; }
    }
}
