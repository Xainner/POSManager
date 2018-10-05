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
    public static class ExternalInvoiceSaleDetailsConnection
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
                    var output = cnn.Query<int>("SELECT COUNT(numberInvoice) FROM detailexternalinvoicesell ORDER BY numberInvoice DESC LIMIT 1");
                    return output.Single();
                }
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public static bool InsertExternalInvoiceSaleDetails(ExternalInvoiceSaleDetailsModel externalInvoiceSaleDetailsModel, List<int> productsIds)
        {
            try
            {
                if (externalInvoiceSaleDetailsModel.IdClient != 0)
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Query("INSERT detailexternalinvoicesell (IdClient, idEmployee, idBusiness, currencyType, iviAmount, cashDeposit, cardDepost, totalDiscount, subTotal, TOtal) VALUES (@IdClient, @idEmployee, @idBusiness, @currencyType, @iviAmount, @cashDeposit, @cardDepost, @totalDiscount, @subTotal, @TOtal)");
                        InsertProductsXInvoice(productsIds);
                        return true;
                    }
                } else
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Query("INSERT detailexternalinvoicesell (idEmployee, idBusiness, currencyType, iviAmount, cashDeposit, cardDepost, totalDiscount, subTotal, TOtal) VALUES (@idEmployee, @idBusiness, @currencyType, @iviAmount, @cashDeposit, @cardDepost, @totalDiscount, @subTotal, @TOtal)");
                        InsertProductsXInvoice(productsIds);
                        return true;
                    }
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static void InsertProductsXInvoice(List<int> productsids)
        {
            ProductsXInvoiceModel productsXInvoiceModel;
            foreach (int item in productsids)
            {
                productsXInvoiceModel = new ProductsXInvoiceModel()
                {
                    Product_idProduct = item,
                    IdDetailExternalInvoiceSell = SelectLastInvoiceNumber()
                };
            
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Query("INSERT externalinvoicesell (Product_idProduct, idDetailExternalInvoiceSell) VALUES (@Product_idProduct, @idDetailExternalInvoiceSell)", productsXInvoiceModel);
                }
            }
        }
    }
}
