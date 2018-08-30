using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class department_positions
    {
        public int positionID { get; set; }
        public int departmentID { get; set; }
        public int skillID { get; set; }
        public int openSpots { get; set; }
        public Boolean status { get; set; }
        public string positionName { get; set; }
        public int skillLevel { get; set; }

        public shifts shift { get; set; }
        public skills skill { get; set;}

    }
}
