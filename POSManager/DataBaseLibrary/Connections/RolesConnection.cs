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
    public static class RolesConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<RolesModel> SelectAllRolesByUserId(RolesModel rolesModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<RolesModel>("SELECT * FROM userxrole WHERE IdUser = @IdUser ORDER BY IdRole ASC", rolesModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateUserRolesById(List<RolesModel> rolesModels)
        {
            try
            {
                foreach (RolesModel rolesModel in rolesModels)
                {
                    using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                    {
                        var output = cnn.Query<RolesModel>("UPDATE userxrole SET Enabled = @Enabled WHERE IdUser = @IdUser AND IdRole = @IdRole", rolesModel);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertUserXRole(RolesModel rolesModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO userxrole(IdUser, IdRole) VALUES(@IdUser, @IdRole)", rolesModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static void DeleteUserXRoleByUserId(RolesModel rolesModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM userxrole WHERE IdUser = @IdUser", rolesModel);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
