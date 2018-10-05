using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class BrandManagement
    {
        public static List<BrandModel> SelectAllBrands()
        {
            try
            {
                return BrandConnection.SelectAllBrands();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BrandModel> SelectBrandsByName(string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                return BrandConnection.SelectBrandsByName(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BrandModel SelectBrandByName(string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                return BrandConnection.SelectBrandByName(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertBrand(string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                return BrandConnection.InsertBrand(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateBrandById(int id, string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = id,
                    Name = name
                };
                return BrandConnection.UpdateBrandById(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteBrandById(int id)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = id
                };
                return BrandConnection.DeleteBrandById(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
