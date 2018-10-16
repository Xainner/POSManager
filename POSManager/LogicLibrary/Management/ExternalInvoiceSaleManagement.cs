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

        public static bool InsertExternalInvoiceSaleDetails(decimal discount, decimal taxes, decimal subTotal, decimal total, decimal cashAmount, decimal cardAmount, string currencyType, int businessId, int clientId, int employeeId, List<int> productsIds, List<int> productquantity, List<decimal> price, List<decimal> amout, List<decimal> discounts)
        {
            try
            {
                ExternalInvoiceSaleDetailsModel externalInvoiceSaleDetailsModel = new ExternalInvoiceSaleDetailsModel()
                {
                    IdClient = clientId,
                    IdEmployee = employeeId,
                    IdBusiness = businessId,
                    CurrencyType = currencyType,
                    IviAmount = taxes,
                    CashDeposit = cashAmount,
                    CardDeposit = cardAmount,
                    SubTotal = subTotal,
                    TotalDiscount = discount,
                    Total = total
                };
                return ExternalInvoiceSaleDetailsConnection.InsertExternalInvoiceSaleDetails(externalInvoiceSaleDetailsModel, productsIds, productquantity, price, amout, discounts);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static ExternalInvoiceSaleDetailsModel SelectInvoiceById2(int id)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoice2ById(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ProductXQuantityModel> SelectProductsInvoiceXInvoiceId(int id)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.productXQuantityModels(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static ExternalInvoiceSaleDetailsModel SelectInvoiceById(int id)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoiceById(id);
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

        public static List<ExternalInvoiceSaleDetailsModel> SelectInvoicesByDate(string start, string end)
        {
            try
            {
                return ExternalInvoiceSaleDetailsConnection.SelectInvoicesByDate(DateTime.Parse(start), DateTime.Parse(end));
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //SELECT PRODUCTS BY DAY

        public static List<ProductXQuantityModel> SelectProductsByDay(DateTime date)
        {
            try
            {
                return SelectProductsByDay2(ExternalInvoiceSaleDetailsConnection.SelectProductsByDay(date));
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private static List<ProductXQuantityModel> SelectProductsByDay2(List<int> ids)
        {
            try
            {
                List<ProductXQuantityModel> productXQuantityModels = new List<ProductXQuantityModel>();
                foreach (int  item in ids)
                {
                    foreach (ProductXQuantityModel item2 in ExternalInvoiceSaleDetailsConnection.productXQuantityModels(item))
                    {
                        productXQuantityModels.Add(item2);
                    }
                }
                return productXQuantityModels;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public static List<ProductXQuantityModel> SelectProductsByDate(string value1, string value2)
        {
            try
            {
                return SelectProductsByDay2(ExternalInvoiceSaleDetailsConnection.SelectInvoicesByDate2(DateTime.Parse(value1), DateTime.Parse(value2)));
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}