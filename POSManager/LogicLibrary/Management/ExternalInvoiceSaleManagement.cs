using DataBaseLibrary.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLibrary.Models;

namespace LogicLibrary.Management
{
    public static class ExternalInvoiceSaleManagement
    {
        public static int SelectLastInvoiceNumber()
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectLastInvoiceNumber();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertExternalInvoiceSaleDetails(decimal discount, decimal taxes, decimal subTotal, decimal total, decimal cashAmount, decimal cardAmount, string currencyType, int businessId, int clientId, int employeeId, List<int> productsIds)
        {
            try
            {
                ExternalInvoiceSaleDetailsModel externalInvoiceSaleDetailsModel = new ExternalInvoiceSaleDetailsModel()
                {
                    IdClient = clientId, IdEmployee = employeeId, IdBusiness = businessId, CurrencyType = currencyType, IviAmount = taxes, CashDeposit = cashAmount, CardDeposit = cardAmount, SubTotal = subTotal, TotalDiscount = discount, Total = total
                };
                return ExternalInvoiceSaleDetailsConnection.InsertExternalInvoiceSaleDetails(externalInvoiceSaleDetailsModel, productsIds);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
