using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPI.Models
{
    public class TwitterRequestModel
    {
        public string enddate { get; set; }
        public string name { get; set; }
        public string rule { get; set; }
        public List<TwitterSearchRule> rules { get; set; } 
    }
}
