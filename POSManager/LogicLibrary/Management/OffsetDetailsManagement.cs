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
        public static List<DepositXOffsetModel> SelectAllOffsetDeposit()
        {
            try
            {
                return OffsetDetailsConnection.SelectAllOffsetDeposit();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DepositXOffsetModel SelectOffsetDetailByInvoice(string code)
        {
            try
            {
                DepositXOffsetModel offSetDetails = new DepositXOffsetModel()
                {
                    IdDetailOffsetInvoice = int.Parse(code)
                };
                return OffsetDetailsConnection.SelectDepositByInvoice(offSetDetails);
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
             decimal cashAmount, decimal cardAmount, decimal discount, decimal subTotal, decimal total, decimal taxes, decimal deposit, List<int> productsIds, List<int> quantities)
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
                return OffsetDetailsConnection.InsertOffsetDetails(offsetDetailsModel, productsIds, quantities, deposit);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertOffsetDeposit(string id, decimal deposit)
        {
            try
            {
                DepositXOffsetModel depositXOffset = new DepositXOffsetModel()
                {
                    IdDetailOffsetInvoice = int.Parse(id),
                    Deposit = deposit
                };
                return OffsetDetailsConnection.InsertOffsetDeposit(depositXOffset);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
