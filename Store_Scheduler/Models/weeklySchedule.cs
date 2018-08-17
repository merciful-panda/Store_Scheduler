using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class weeklySchedule
    {
        public int  weeklyScheduleID { get; set; }
        public int employeeID { get; set; }
        public DateTime date { get; set; }

    }
}
