using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class roles
    {
        [Key]
        public int roleID { get; set; }
        public String name { get; set; }

        public virtual ICollection<employees> employees { get; set; }
    }
}
