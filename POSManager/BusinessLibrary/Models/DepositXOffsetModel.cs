using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class DepositXOffsetModel
    {
        public int IdDetailOffsetInvoice { get; set; }
        public DateTime CurrentDate { get; set; }
        public decimal Deposit { get; set; }
    }
}
