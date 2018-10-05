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
    public static class SubCategoryConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<SubCategoryModel> SelectAllSubCategories()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SubCategoryModel> SelectSubCategoriesByName(SubCategoryModel subCategoryModel)
        {
            try
            {
                SubCategoryModel auxModel = new SubCategoryModel()
                {
                    Name = $"%{ subCategoryModel.Name }%"
                };
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory WHERE Name like @Name", auxModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SubCategoryModel SelectSubCategoryByName(SubCategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory WHERE Name = @Name", subCategoryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<SubCategoryModel> SelectSubCategoriesByCategoryId(SubCategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory WHERE IdCategory = @IdCategory", subCategoryModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static SubCategoryModel SelectSubCategoryById(SubCategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory WHERE IdSubCategory = @IdSubCategory", subCategoryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertSubCategory(SubCategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO subcategory (IdCategory, Name) VALUES(@IdCategory, @Name)", subCategoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteSubCategoryById(SubCategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM subcategory WHERE IdSubCategory = @IdSubCategory", subCategoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateSubCategoryById(SubCategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE subcategory SET Name = @Name, IdCategory = @IdCategory WHERE IdSubCategory = @IdSubCategory", subCategoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
