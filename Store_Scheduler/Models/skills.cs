using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class skills
    {
        [Key]
        public int skillID { get; set; }
        public string name { get; set; }

        public virtual ICollection<department_positions> positions { get; set; }
        public virtual ICollection<employee_skills> employee_skills { get; set; }
    }
}
