using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class users
    {
        public int userID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public DateTime birthDate { get; set; }

        public employees employee { get; set; }
    }
}
