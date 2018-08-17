using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employees_roles
    {
        public int roleID { get; set; }
        public int employeeID { get; set; }

        public roles role { get; set; }
        public employees employee { get; set; }
    }
}
