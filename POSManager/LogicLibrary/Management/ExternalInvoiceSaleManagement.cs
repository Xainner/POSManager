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

        public static bool InsertExternalInvoiceSaleDetails(decimal discount, decimal taxes, decimal subTotal, decimal total, decimal cashAmount, decimal cardAmount, string currencyType, int businessId, int clientId, int employeeId, List<int> productsIds, List<int> productquantity)
        {
            try
            {
                ExternalInvoiceSaleDetailsModel externalInvoiceSaleDetailsModel = new ExternalInvoiceSaleDetailsModel()
                {
                    IdClient = clientId, IdEmployee = employeeId, IdBusiness = businessId, CurrencyType = currencyType, IviAmount = taxes, CashDeposit = cashAmount, CardDeposit = cardAmount, SubTotal = subTotal, TotalDiscount = discount, Total = total
                };
                return ExternalInvoiceSaleDetailsConnection.InsertExternalInvoiceSaleDetails(externalInvoiceSaleDetailsModel, productsIds, productquantity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ExternalInvoiceSaleDetailsModel> SelectInvoices()
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoices();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ExternalInvoiceSaleDetailsModel> SelectInvoicesByDay(DateTime date)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoicesByDay(date);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ExternalInvoiceSaleDetailsModel> SelectInvoicesByMonth(DateTime date)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoicesByMonth(date);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ExternalInvoiceSaleDetailsModel> SelectInvoicesByDate(DateTime start, DateTime end)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoicesByDate(start, end);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
