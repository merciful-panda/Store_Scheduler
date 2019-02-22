using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employee_skills
    {
        [Key]
        public int ID { get; set; }
        public int employeeID { get; set; }
        public virtual employees employee { get; set; }

        public int skillID { get; set; }
        public virtual skills skill { get; set; }

        public int experience { get; set; }
    }
}
