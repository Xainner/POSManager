using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class SubCategoryManagement
    {
        public static List<SubCategoryModel> SelectAllSubCategories()
        {
            try
            {
                return SubCategoryConnection.SelectAllSubCategories();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SubCategoryModel> SelectSubCategoriesByName(string name)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    Name = name
                };
                return SubCategoryConnection.SelectSubCategoriesByName(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SubCategoryModel> SelectSubCategoriesByCategoryId(int id)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    IdCategory = id
                };
                return SubCategoryConnection.SelectSubCategoriesByCategoryId(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SubCategoryModel SelectSubCategoryByName(string name)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    Name = name
                };
                return SubCategoryConnection.SelectSubCategoryByName(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SubCategoryModel SelectSubCategoryById(int id)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    IdSubCategory = id
                };
                return SubCategoryConnection.SelectSubCategoryById(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertSubCategory(int id, string name)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    IdCategory = id,
                    Name = name
                };
                return SubCategoryConnection.InsertSubCategory(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateSubCategoryById(int id, int categoryId, string name)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    IdSubCategory = id,
                    IdCategory = categoryId,
                    Name = name
                };
                return SubCategoryConnection.UpdateSubCategoryById(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteSubCategoryById(int id)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    IdSubCategory = id
                };
                return SubCategoryConnection.DeleteSubCategoryById(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
