using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class stores
    {
        public int storeID { get; set; }
        public string storeName { get; set; }
        public string address{ get; set; }
        public string city { get; set; }
        public string state { get; set; }

        [MaxLength(10, ErrorMessage = "zip code cannot be more than 10 digits")]
        public string zipcode { get; set; }
        public string phone { get; set; }

    }
}
