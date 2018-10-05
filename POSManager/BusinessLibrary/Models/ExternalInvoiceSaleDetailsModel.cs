using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ExternalInvoiceSaleDetailsModel
    {
        public int NumberInvoice { get; set; }
        public DateTime ActualDate { get; set; }
        public int IdClient { get; set; }
        public int IdEmployee { get; set; }
        public int IdBusiness { get; set; }
        public string CurrencyType { get; set; }
        public decimal IviAmount { get; set; }
        public decimal CashDeposit { get; set; }
        public decimal CardDeposit { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
