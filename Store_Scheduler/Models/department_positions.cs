using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class department_positions
    {
        [Key]
        public int positionID { get; set; }
        public int openSpots { get; set; }
        public Boolean status { get; set; }
        public string positionName { get; set; }
        public int skillLevel { get; set; }

        public int skillID { get; set; }
        public virtual skills skill { get; set;}

        public int departmentID { get; set; }
        public virtual departments department { get; set; }

        public int shiftID { get; set; }
        public virtual shifts shift { get; set; }

    }
}
