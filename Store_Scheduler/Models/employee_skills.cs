using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employee_skills
    {
        public int employeeID { get; set; }
        public int skillID { get; set; }
        public int experience { get; set; }

        public skills skill { get; set; }

    }
}
