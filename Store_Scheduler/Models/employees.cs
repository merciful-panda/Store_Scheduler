using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employees
    {
        public int employeeID { get; set; }
        public int userID { get; set; }
        public int roleID { get; set; }
        public Boolean status { get; set; }
        public int payType { get; set; }
        public double hourlyRate { get; set; }
        public double overtimeRate { get; set; }

        public users user { get; set; }
        public roles role { get; set; }
    }
}
