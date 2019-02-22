using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class employee_stores
    {
        [Key]
        public int ID { get; set; }
        public int employeeID { get; set; }
        public virtual employees employee { get; set; }

        public int storeID { get; set; }
        public virtual stores store { get; set; }
    }
}
