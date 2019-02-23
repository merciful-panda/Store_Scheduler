using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class sales
    {
        [Key]
        public int salesID { get; set; }
        public double laborCost { get; set; }
        public double revenue  { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        public int storeID { get; set; }
        public virtual stores store { get; set; }
    }
}
