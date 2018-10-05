using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class CategoryManagement
    {
        public static List<CategoryModel> SelectAllCategories()
        {
            try
            {
                return CategoryConnection.SelectAllCategories();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<CategoryModel> SelectCategoriesByName(string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name
                };
                return CategoryConnection.SelectCategoriesByName(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static CategoryModel SelectCategoryByName(string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name
                };
                return CategoryConnection.SelectCategoryByName(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertCategory(string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name
                };
                return CategoryConnection.InsertCategory(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateCategoryById(int id, string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    IdCategory = id,
                    Name = name
                };
                return CategoryConnection.UpdateCategoryById(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteCategoryById(int id)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    IdCategory = id
                };
                return CategoryConnection.DeleteCategoryById(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
