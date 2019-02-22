using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class stores
    {
        [Key]
        public int storeID { get; set; }
        public string storeName { get; set; }
        public string address{ get; set; }
        public string city { get; set; }
        public string state { get; set; }

        [MaxLength(10, ErrorMessage = "zip code cannot be more than 10 digits")]
        public string zipcode { get; set; }
        public string phone { get; set; }

        public virtual ICollection<sales> sales { get; set; }
        public virtual ICollection<departments> departments { get; set; }
        public virtual ICollection<employee_stores> Employee_Stores { get; set; }
    }
}
