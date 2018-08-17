using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class users_permissions
    {
        public int permissionID { get; set; }
        public int userID { get; set; }

        public permissions permission { get; set; }
        public users user { get; set; }
    }
}
