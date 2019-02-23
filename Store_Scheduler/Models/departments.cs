using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class departments
    {
        [Key]
        public int departmentID { get; set; }
        public string name { get; set; }
        public int priority { get; set; }
        public int openspot { get; set; }
        public int status { get; set; }
        public String description { get; set; }

        public int storeID { get; set; }
        public virtual stores store { get; set; }

        public virtual ICollection<department_positions> Positions { get; set; }
    }
}
