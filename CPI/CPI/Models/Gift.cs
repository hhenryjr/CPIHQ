using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCloudantWebstarter.Models
{
    public class Gift
    {

        public int Id { get; set; }

        public string GiftCategory { get; set; }

        public string Gender { get; set; }

        public string NameOfGift { get; set; }

        public double PriceOfGift { get; set; }

        public string DescriptionOfGift { get; set; }

        public string Picture { get; set; }

    }
}
