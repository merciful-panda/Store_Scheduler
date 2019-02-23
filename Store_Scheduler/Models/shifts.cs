using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class shifts
    {
        [Key]
        public int shiftID { get; set; }
        public DateTime startTime { get; set; }
        public DateTime? endTime { get; set; }

        public int assignedBy { get; set; }
        public int employeeID { get; set; }
        public employees employee { get; set; }

        public int weeklyScheduleID { get; set; }
        public virtual weeklySchedule weeklySchedule { get; set; }

        public virtual ICollection<department_positions> positions { get; set; }
    }
}
