using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class events_stores
    {
        int eventID { get; set; }
        int storeID { get; set; }
        Boolean status { get; set; }

        public events eventinstance { get; set; }
    }
}
