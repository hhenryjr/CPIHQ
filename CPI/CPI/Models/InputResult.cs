using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPI.Models
{
    public class InputResult
    {
        public string name { get; set; }
        public int count { get; set; }
        public string frequency { get; set; }
        public int version { get; set; }
        public bool newdata { get; set; }
        public string lastrunstatus { get; set; }
        public string thisversionstatus { get; set; }
        public string nextrun { get; set; }
        public string thisversionrun { get; set; }

        public TwitterTimeline results { get; set; }

        //public List<TwitterPost> collection1 { get; set; }
    }
}
