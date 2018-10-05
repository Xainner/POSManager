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
    }
}
