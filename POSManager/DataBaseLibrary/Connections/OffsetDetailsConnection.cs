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
    public class OffsetDetailsConnection
    {

        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<OffSetDetailsModel> SelectAllOffsetDetails()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<OffSetDetailsModel>("SELECT IdDetailOffsetInvoice, IdClient, IdEmployee, EndDate, Total FROM detailoffsetinvoice");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static OffSetDetailsModel SelectOffsetDetailByInvoice(OffSetDetailsModel offSetDetails)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OffSetDetailsModel>("SELECT * FROM detailoffsetinvoice WHERE IdDetailOffsetInvoice = @IdDetailOffsetInvoice", offSetDetails);
                return output.Single();
            }
        }

        public static int SelectLastOffsetNumber()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<int>("SELECT COUNT(IdDetailOffsetInvoice) FROM detailoffsetinvoice ORDER BY IdDetailOffsetInvoice DESC LIMIT 1");
                    return output.Single();
                }
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public static bool InsertExternalInvoiceSaleDetails(OffSetDetailsModel offSetDetails, List<int> productsIds, List<int> quantities)
        {
            try
            {
                if (offSetDetails.IdClient != 0)
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT detailoffsetinvoice (IdClient, IdEmployee, IdBusiness, EndDate, CurrencyType, Discount, SubTotal, Total, CashDeposit, CardDeposit, Taxes) VALUES (@IdClient, @IdEmployee, @IdBusiness, @EndDate, @CurrencyType, @Discount, @SubTotal, @Total, @CashDeposit, @CardDeposit, @Taxes)", offSetDetails);
                        InsertProductsXOffset(productsIds, quantities);
                        return true;
                    }
                }
                else
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT detailoffsetinvoice (idEmployee, idBusiness, EndDate, CurrencyType, Discount, SubTotal, Total, CashDeposit, CardDeposit, Taxes) VALUES (@IdEmployee, @IdBusiness, @EndDate, @CurrencyType, @Discount, @SubTotal, @Total, @CashDeposit, @CardDeposit, @Taxes)", offSetDetails);
                        InsertProductsXOffset(productsIds, quantities);
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static void InsertProductsXOffset(List<int> productsids, List<int> quantities)
        {
            try
            {
                ProductXOffsetModel productXOffset;
                for (int i = 0; i < productsids.Count; i++)
                {
                    productXOffset = new ProductXOffsetModel()
                    {
                        IdDetailOffsetInvoice = SelectLastOffsetNumber(),
                        IdProduct = productsids[i],
                        Quantity = quantities[i]
                    };

                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT offsetinvoice (IdDetailOffsetInvoice, IdProduct, Quantity) VALUES (@IdDetailOffsetInvoice, @IdProduct, @Quantity)", productXOffset);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void InsertPaymentXOffset(decimal payment, OffSetDetailsModel offSetDetails)
        {

        }

    }
}
