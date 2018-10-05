using DataBaseLibrary.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class ExternalInvoiceSaleManagement
    {
        public static int SelectLastInvoiceNumber()
        {
            try
            {
                return InvoiceSaleDetailsConnection.SelectLastInvoiceNumber();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
