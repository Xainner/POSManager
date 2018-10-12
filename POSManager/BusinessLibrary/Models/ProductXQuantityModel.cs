using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ProductXQuantityModel
    {
        public string description { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal amount { get; set; }
        public decimal discount { get; set; }
    }
}
