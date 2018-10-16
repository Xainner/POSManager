using BusinessLibrary.Models;
using DataBaseLibrary.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class InternalManagement
    {
        public static int SelectLastInvoiceNumber()
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectLastInvoiceNumber();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertInternalInvoiceSaleDetails(decimal discount, decimal taxes, decimal subTotal, decimal total, decimal cashAmount, decimal cardAmount, string currencyType, int businessId, int clientId, int employeeId, List<int> productsIds, List<int> productquantity, List<decimal> price, List<decimal> amout, List<decimal> discounts)
        {
            try
            {
                InternalInvoiceSale internalInvoiceSale = new InternalInvoiceSale()
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
                return InternalInvoiceSaleDetailsConnection.InsertInternalInvoiceSaleDetails(internalInvoiceSale, productsIds, productquantity, price, amout, discounts);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static InternalInvoiceSale SelectInvoiceById2(int id)
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectInvoice2ById(id);
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
                return InternalInvoiceSaleDetailsConnection.productXQuantityModels(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static InternalInvoiceSale SelectInvoiceById(int id)
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectInvoiceById(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoices()
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectInvoices();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoicesByDay(DateTime date)
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectInvoicesByDay(date);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoicesByMonth(DateTime date)
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectInvoicesByMonth(date);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoicesByDate(DateTime start, DateTime end)
        {
            try
            {
                return InternalInvoiceSaleDetailsConnection.SelectInvoicesByDate(start, end);
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
                return SelectProductsByDay2(InternalInvoiceSaleDetailsConnection.SelectProductsByDay(date));
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
                foreach (int item in ids)
                {
                    foreach (ProductXQuantityModel item2 in InternalInvoiceSaleDetailsConnection.productXQuantityModels(item))
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

        public static List<ProductXQuantityModel> SelectProductsByDate(DateTime value1, DateTime value2)
        {
            try
            {
                return SelectProductsByDay2(InternalInvoiceSaleDetailsConnection.SelectInvoicesByDate2(value1, value2));
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
