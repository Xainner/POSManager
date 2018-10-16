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

namespace DataBaseLibrary
{
    public static class ProductConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<ProductModel> SelectAllProducts()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product ORDER BY idProduct ASC LIMIT 20");
                return output.ToList();
            }
        }

        public static List<ProductModel> SelectProductById(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idProduct = @idProduct", productModel);
                return output.ToList();
            }
        }

        public static ProductModel SelectProductByCode(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE Code = @Code", productModel);
                return output.Single();
            }
        }

        public static ProductModel SelectProductByID(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idProduct = @idProduct", productModel);
                return output.Single();
            }
        }

        public static ProductModel SelectProductByStyle(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE Style = @Style", productModel);
                return output.Single();
            }
        }

        public static List<ProductModel> SelectProductsByStyle(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                productModel.Style = $"%{ productModel.Style }%";
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE (Style like @Style)", productModel);
                return output.ToList();
            }
        }

        public static List<ProductModel> SelectProductByBrandId(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idBrand = @idBrand", productModel);
                return output.ToList();
            }
        }

        public static List<ProductModel> SelectProductByDescription(ProductModel productModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                productModel.Description = $"%{ productModel.Description }%";
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE (Description like @Description)", productModel);
                return output.ToList();
            }
        }

        public static bool InsertProduct(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {

                    cnn.Execute("INSERT INTO product (Code, Style, idBrand, idsubCategory, Description, " +
                        "normalPrice, lowerPrice, estableQuantity, variableQuantity, Image, Ivi, existingInvoice) VALUES" +
                        "(@Code, @Style, @idBrand, @idsubCategory, @Description, @normalPrice, @lowerPrice, @estableQuantity, @variableQuantity,  @Image, @Ivi, @existingInvoice)", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool DeleteProductById(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM product WHERE idProduct = @idProduct", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool UpdateProductById(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE product SET Code = @Code, Style = @Style, idBrand = @idBrand, " +
                        "idsubCategory = @idsubCategory, Description = @Description, normalPrice = @normalPrice, lowerPrice = @lowerPrice, " +
                        "estableQuantity = @estableQuantity, variableQuantity = @variableQuantity, Image = @Image, " +
                        "Ivi = @Ivi, existingInvoice = @existingInvoice WHERE idProduct = @idProduct", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
