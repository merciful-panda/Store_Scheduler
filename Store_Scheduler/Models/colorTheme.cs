using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Models
{
    public class colorTheme
    {
        int themeID { get; set; }
        public int storeID { get; set; }
        public string color1 { get; set; }
        public string color2 { get; set; }
        public string color3 { get; set; }
        public string color4 { get; set; }

        public stores store { get; set; }
    }
}
