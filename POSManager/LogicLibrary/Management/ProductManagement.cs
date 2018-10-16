using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLibrary.Models;
using DataBaseLibrary;

namespace LogicLibrary.Management
{
    public static class ProductManagement
    {
        public static bool InsertProduct(
            string code,
            string style,
            string idBrand,
            string description,
            string idSubCategory,
            string normalPrice,
            string lowerPrice,
            string estableQuantity,
            string variableQuantity,
            byte[] image,
            bool ivi,
            bool existingInvoice
        )
        {
            try
            {
                string[] Product = new string[] {
                    code,
                    style,
                    idBrand,
                    description,
                    idSubCategory,
                    normalPrice,
                    lowerPrice,
                    estableQuantity,
                    variableQuantity
                };
                ProductModel productModel = new ProductModel()
                {
                    Code = code,
                    Style = style,
                    idBrand = int.Parse(idBrand),
                    Description = description,
                    idsubCategory = int.Parse(idSubCategory),
                    normalPrice = decimal.Parse(normalPrice),
                    lowerPrice = decimal.Parse(lowerPrice),
                    estableQuantity = int.Parse(estableQuantity),
                    variableQuantity = int.Parse(variableQuantity),
                    Ivi = ivi,
                    existingInvoice = existingInvoice,
                    Image = image
                };

                return ProductConnection.InsertProduct(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        public static ProductModel SelectProductByCode(string code)
        {
            try
            {
                ProductModel productModel = new ProductModel()
                {
                    Code = code
                };
                return ProductConnection.SelectProductByCode(productModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static ProductModel SelectProductByID(string id)
        {
            try
            {
                ProductModel productModel = new ProductModel()
                {
                    idProduct = int.Parse(id)
                };
                return ProductConnection.SelectProductByID(productModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool UpdateProductById(
            string idProduct,
            string code, string style,
            string idBrand,
            string description,
            string idSubCategory,
            string normalPrice,
            string lowerPrice,
            string estableQuantity,
            string variableQuantity,
            byte[] image,
            bool ivi,
            bool existingInvoice
        )
        {
            try
            {
                string[] product = new string[] {
                    idProduct,
                    code,  style,
                    idBrand,
                    description,
                    idSubCategory,
                    normalPrice,
                    lowerPrice,
                    estableQuantity,
                    variableQuantity
                };
                    ProductModel productModel = new ProductModel()
                    {
                        idProduct = int.Parse(idProduct),
                        Code = code,
                        Style = style,
                        idBrand = int.Parse(idBrand),
                        Description = description,
                        idsubCategory = int.Parse(idSubCategory),
                        normalPrice = decimal.Parse(normalPrice),
                        lowerPrice = decimal.Parse(lowerPrice),
                        estableQuantity = int.Parse(estableQuantity),
                        variableQuantity = int.Parse(variableQuantity),
                        Ivi = ivi,
                        existingInvoice = existingInvoice,
                        Image = image

                    };
                    return ProductConnection.UpdateProductById(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        public static bool DeleteProductById(string idProduct)
        {
            try
            {
                string[] product = new string[] { idProduct };
                ProductModel productModel = new ProductModel()
                {
                    idProduct = int.Parse(idProduct),
                };
                return ProductConnection.DeleteProductById(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        public static List<ProductModel> SelectAllProducts()
        {
            try
            {
                return ProductConnection.SelectAllProducts();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
