using BusinessLibrary.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary.Connections
{
    public static class InternalInvoiceSaleDetailsConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static int SelectLastInvoiceNumber()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<int>("SELECT COUNT(numberInvoice) FROM detailinternalinvoicesell ORDER BY numberInvoice DESC LIMIT 1");
                    return output.Single();
                }
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoices()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InternalInvoiceSale>("SELECT * FROM detailinternalinvoicesell");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertInternalInvoiceSaleDetails(InternalInvoiceSale externalInvoiceSaleDetailsModel, List<int> productsIds, List<int> productquantity, List<decimal> price, List<decimal> amount, List<decimal> discount)
        {
            try
            {
                externalInvoiceSaleDetailsModel.ActualDate = DateTime.Now;
                if (externalInvoiceSaleDetailsModel.IdClient != 0)
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT detailinternalinvoicesell (ActualDate, IdClient, idEmployee, idBusiness, currencyType, iviAmount, cashDeposit, cardDeposit, totalDiscount, subTotal, TOtal) VALUES (@ActualDate, @IdClient, @idEmployee, @idBusiness, @currencyType, @iviAmount, @cashDeposit, @cardDeposit, @totalDiscount, @subTotal, @Total)", externalInvoiceSaleDetailsModel);
                        InsertProductsXInvoice(productsIds, productquantity, price, amount, discount);
                        return true;
                    }
                }
                else
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT detailinternalinvoicesell (ActualDate, idEmployee, idBusiness, currencyType, iviAmount, cashDeposit, cardDeposit, totalDiscount, subTotal, TOtal) VALUES (@ActualDate, @idEmployee, @idBusiness, @currencyType, @iviAmount, @cashDeposit, @cardDeposit, @totalDiscount, @subTotal, @Total)", externalInvoiceSaleDetailsModel);
                        InsertProductsXInvoice(productsIds, productquantity, price, amount, discount);
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public static List<int> SelectProductsByDay(DateTime date)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<int>("SELECT numberInvoice FROM detailinternalinvoicesell WHERE ActualDate = @date", new { date });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static InternalInvoiceSale SelectInvoiceById(int id)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InternalInvoiceSale>("SELECT numberInvoice FROM detailinternalinvoicesell WHERE numberInvoice = @id", new { id });
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static InternalInvoiceSale SelectInvoice2ById(int id)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InternalInvoiceSale>("SELECT * FROM detailinternalinvoicesell WHERE numberInvoice = @id", new { id });
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<ProductXQuantityModel> productXQuantityModels(int id)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output2 = cnn.Query<ProductXQuantityModel>("SELECT description, quantity, price, amount, discount FROM product INNER JOIN internalinvoicesell ON product.idProduct = internalinvoicesell.Product_idProduct WHERE internalinvoicesell.idDetailInternalInvoiceSell =  @id", new { id });
                return output2.ToList();
            }
        }

        public static List<InternalInvoiceSale> SelectInvoicesByDate(DateTime start, DateTime end)
        {
            try
            {
                TestDateModel testDateModel = new TestDateModel()
                {
                    end = end,
                    start = start
                };
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InternalInvoiceSale>("SELECT * FROM detailinternalinvoicesell WHERE ActualDate BETWEEN " +
                        "@start AND @end", testDateModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<int> SelectInvoicesByDate2(DateTime start, DateTime end)
        {
            try
            {
                TestDateModel testDateModel = new TestDateModel()
                {
                    end = end,
                    start = start
                };
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<int>("SELECT numberInvoice FROM detailinternalinvoicesell WHERE ActualDate BETWEEN " +
                        "@start AND @end", testDateModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoicesByMonth(DateTime date)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InternalInvoiceSale>("SELECT * FROM detailinternalinvoicesell WHERE ActualDate = @date", new { date });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<InternalInvoiceSale> SelectInvoicesByDay(DateTime date)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InternalInvoiceSale>("SELECT * FROM detailinternalinvoicesell WHERE ActualDate = @date", new { date });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static void InsertProductsXInvoice(List<int> productsids, List<int> quantites, List<decimal> price, List<decimal> amount, List<decimal> discount)
        {
            ProductsXInvoiceModel productXInvoiceInternal;
            int i = 0;
            foreach (int item in productsids)
            {
                productXInvoiceInternal = new ProductsXInvoiceModel()
                {
                    Product_idProduct = item,
                    IdDetailExternalInvoiceSell = SelectLastInvoiceNumber(),
                    Quantity = quantites[i],
                    Amount = amount[i],
                    Discount = discount[i],
                    Price = price[i]
                };

                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT externalinvoicesell (Product_idProduct, idDetailInternalInvoiceSell, quantity, amount, discount, price) VALUES (@Product_idProduct, @idDetailInternalInvoiceSell, @Quantity, @Amount, @Discount, @Price)", productXInvoiceInternal);
                }
                i++;
            }
        }
    }
}
