using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWebbeds.Models
{
    public class Rate
    {
        public string rateType { get; set; }
        public string boardType { get; set; }
        public double value { get; set; }
        public Rate (string rateType, string boardType, double value)
        {
            this.rateType = rateType;
            this.boardType = boardType;
            this.value = value;
        }
    }
}
