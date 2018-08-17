using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class departments
    {
        public int departmentID { get; set; }
        public int storeID { get; set; }
        public string name { get; set; }
        public int priority { get; set; }
        public int  openspot { get; set; }
        public int status { get; set; }

        public List<department_positions> positionInstance { get; set; }
    }
}
