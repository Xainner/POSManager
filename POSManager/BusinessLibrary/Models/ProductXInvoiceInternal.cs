using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ProductXInvoiceInternal
    {
        public int IdDetailInternalInvoiceSell { get; set; }
        public int Product_idProduct { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
    }
}
