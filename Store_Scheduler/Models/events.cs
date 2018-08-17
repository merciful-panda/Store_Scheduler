using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class events
    {
        int eventID { get; set; }
        string eventName { get; set; }
        DateTime date { get; set; }
        DateTime startTime { get; set; }
        DateTime closingTime { get; set; }
    }
}
