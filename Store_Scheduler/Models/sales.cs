using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class sales
    {
        public int salesID { get; set; }
        public int storeID { get; set; }
        public double MyProperty { get; set; }
        public double revenue  { get; set; }
        public DateTime date { get; set; }
    }
}
