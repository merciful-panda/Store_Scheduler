using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employees
    {
        [Key]
        public int employeeID { get; set; }

        public Boolean status { get; set; }
        public int payType { get; set; }
        public double? hourlyRate { get; set; }
        public double? overtimeRate { get; set; }

        public int userID { get; set; }
        public users user { get; set; }

        public int roleID { get; set; }
        public virtual roles role { get; set; }

        public virtual ICollection<employee_stores> employee_stores { get; set; }
        public virtual ICollection<shifts> shifts { get; set; } 
    }
}
