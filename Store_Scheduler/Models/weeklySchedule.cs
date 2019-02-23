using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class weeklySchedule
    {
        [Key]
        public int  weeklyScheduleID { get; set; }
        public int employeeID { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        /*public DateTime startTime { get; set; } Very questionable if these are needed
        public employees employee { get; set; } */

        public virtual ICollection<shifts> shifts { get; set; }

    }
}
