using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ProductModel
    {
        public int idProduct { get; set; }
        public string Code { get; set; }
        public string Style { get; set; }
        public int idBrand { get; set; }
        public string Description { get; set; }
        public int idsubCategory { get; set; }
        public decimal normalPrice { get; set; }
        public decimal lowerPrice { get; set; }
        public int estableQuantity { get; set; }
        public int variableQuantity { get; set; }
        public byte[] Image { get; set; }
        public bool Ivi { get; set; }
        public bool existingInvoice { get; set; }
    }
}
