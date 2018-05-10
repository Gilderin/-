﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class ComplaintCategory
    {
        public Int32 Id  { get; set; }
        public String Name { get; set; }

        public virtual ICollection<ComplaintCategoryJoin> ComplaintCategotyJoins { get; set; }
    }
}
