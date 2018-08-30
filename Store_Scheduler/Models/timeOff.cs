using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class timeOff
    {
        public int timeOffID { get; set; }
        public int employeeID { get; set; }
        public int reviewer { get; set; }
        public DateTime date { get; set; }
        public int status { get; set; }
        public DateTime reviewedOn { get; set; }
        public DateTime requestedOn { get; set; }
        public String employeeComment { get; set; }
        public String reviewerComment { get; set; }

        public employees employee { get; set; }
    }
}
