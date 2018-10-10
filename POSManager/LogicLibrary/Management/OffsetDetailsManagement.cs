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

        public static bool InsertOffsetInvoiceDetails(string client, int employeeId, int businessId, string endDate, string currencyType,
             decimal cashAmount, decimal cardAmount, decimal discount, decimal subTotal, decimal total, decimal taxes, decimal deposit, List<int> productsIds, List<int> quantities)
        {
            try
            {
                OffSetDetailsModel offsetDetailsModel = new OffSetDetailsModel()
                {
                    Client = client,
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

        public static bool InsertOffsetDeposit(string id, string name, decimal deposit)
        {
            try
            {
                DepositXOffsetModel depositXOffset = new DepositXOffsetModel()
                {
                    IdDetailOffsetInvoice = int.Parse(id),
                    Name = name,
                    Deposit = deposit
                };
                return OffsetDetailsConnection.InsertOffsetDeposit(depositXOffset);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<DepositXOffsetModel> MultipleValueSearch(string value)
        {
            try
            {
                if (int.TryParse(value, out int id))
                {
                    DepositXOffsetModel depositXOffsetNum = new DepositXOffsetModel() { IdDetailOffsetInvoice = id };
                    return OffsetDetailsConnection.MultipleValueNum(depositXOffsetNum);
                }
                else
                {
                    DepositXOffsetModel depositXOffset = new DepositXOffsetModel() { Name = value };
                    return OffsetDetailsConnection.MultipleValueName(depositXOffset);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
