using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class weeklySchedule
    {
        public int  weeklyScheduleID { get; set; }
        public int employeeID { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }

        public employees employee { get; set; }

    }
}
