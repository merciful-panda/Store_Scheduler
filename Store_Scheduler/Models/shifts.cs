using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class shifts
    {
        public int shiftID { get; set; }
        public int positionID { get; set; }
        public int employeeID { get; set; }
        public string assignedBy { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

    }
}
