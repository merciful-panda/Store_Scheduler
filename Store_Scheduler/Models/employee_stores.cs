using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employee_stores
    {
        public int employeeID { get; set; }
        public int storeID { get; set; }

        public employees employee { get; set; }
        public stores store { get; set; }
    }
}
