using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Complaint
    {
        public Int32 Id { get; set; }
        public String Text { get; set; }

        public Int32 ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ComplaintCategoryJoin> ComplaintCategotyJoins { get; set; }
    }
}
