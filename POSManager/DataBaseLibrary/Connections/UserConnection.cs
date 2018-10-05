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
    public static class UserConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<UserModel> SelectAllUsers()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>("SELECT * FROM user");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectUsersByRole(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>("SELECT * FROM user WHERE Role like @Role", userModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectUsersByUserName(UserModel userModel)
        {
            try
            {
                UserModel auxModel = new UserModel()
                {
                    UserName = $"%{ userModel.UserName }%"
                };
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>("SELECT * FROM user WHERE UserName like @UserName", auxModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectUsersByUserName(UserModel userModel, int role)
        {
            try
            {
                UserModel auxModel = new UserModel()
                {
                    UserName = $"%{ userModel.UserName }%",
                    Role = role
                };
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>("SELECT * FROM user WHERE UserName like @UserName AND Role = @Role", auxModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static UserModel SelectUserById(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>("SELECT * FROM user WHERE Id = @Id", userModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static UserModel SelectUserByUserName(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>("SELECT * FROM user WHERE UserName = @UserName", userModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertUser(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO user (UserName, PasswordHash, Role) VALUES(@UserName, @PasswordHash, @Role)", userModel);
                }
                userModel = SelectUserByUserName(userModel);
                RolesModel rolesModel = new RolesModel()
                {
                    IdUser = userModel.Id,
                };
                for (int i = 1; i < 9; i++)
                {
                    rolesModel.IdRole = i;
                    RolesConnection.InsertUserXRole(rolesModel);
                }
                return true;
             }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeletUserById(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    RolesModel rolesModel = new RolesModel()
                    {
                        IdUser = userModel.Id
                    };
                    RolesConnection.DeleteUserXRoleByUserId(rolesModel);
                    cnn.Execute("DELETE FROM user WHERE Id = @Id", userModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateUserPasswordById(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE user SET PasswordHash = @PasswordHash WHERE Id = @Id", userModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateUserRoledById(UserModel userModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE user SET Role = @Role WHERE Id = @Id", userModel);
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
