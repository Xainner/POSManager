using BusinessLibrary.Models;
using DataBaseLibrary.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public class OffsetDetailsManagement
    {
        public static List<OffSetDetailsModel> SelectAllOffsetDetails()
        {
            try
            {
                return OffsetDetailsConnection.SelectAllOffsetDetails();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static OffSetDetailsModel SelectOffsetDetailByInvoice(string code)
        {
            try
            {
                OffSetDetailsModel offSetDetails = new OffSetDetailsModel()
                {
                    IdDetailOffsetInvoice = int.Parse(code)
                };
                return OffsetDetailsConnection.SelectOffsetDetailByInvoice(offSetDetails);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static int SelectLastOffsetNumber()
        {
            try
            {
                return OffsetDetailsConnection.SelectLastOffsetNumber();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertOffsetInvoiceDetails(int clientId, int employeeId, int businessId, string endDate, string currencyType,
             decimal cashAmount, decimal cardAmount, decimal discount, decimal subTotal, decimal total, decimal taxes, List<int> productsIds, List<int> quantities)
        {
            try
            {
                OffSetDetailsModel offsetDetailsModel = new OffSetDetailsModel()
                {
                    IdClient = clientId,
                    IdEmployee = employeeId,
                    IdBusiness = businessId,
                    EndDate = DateTime.Parse(endDate),
                    CurrencyType = currencyType,
                    CashDeposit = cashAmount,
                    CardDeposit = cardAmount,
                    SubTotal = subTotal,
                    Discount = discount,
                    Total = total,
                    Taxes = taxes
                };
                return OffsetDetailsConnection.InsertExternalInvoiceSaleDetails(offsetDetailsModel, productsIds, quantities);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
