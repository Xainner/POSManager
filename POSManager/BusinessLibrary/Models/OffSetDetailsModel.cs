using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class OffSetDetailsModel
    {
        public int IdDetailOffsetInvoice { get; set; }
        public DateTime CurrentDate { get; set; }
        public int IdClient { get; set; }
        public int IdEmployee { get; set; }
        public int IdBusiness { get; set; }
        public DateTime EndDate { get; set; }
        public string CurrencyType { get; set; }
        public decimal CashDeposit { get; set; }
        public decimal CardDeposit { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Taxes { get; set; }
    }
}
