using BusinessLibrary.Models;
using DataBaseLibrary;
using LogicLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class UserManagement
    {
        public static UserModel SelectUserByUserName(string userName)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    UserName = userName
                };
                return UserConnection.SelectUserByUserName(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectUsersByUserName(string userName)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    UserName = userName
                };
                return UserConnection.SelectUsersByUserName(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectUsersByUserName(string userName, int role)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    UserName = userName
                };
                return UserConnection.SelectUsersByUserName(userModel, role);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectUsersByRole(int role)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Role = role
                };
                return UserConnection.SelectUsersByRole(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<UserModel> SelectAllUsers()
        {
            try
            {
                return UserConnection.SelectAllUsers();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static UserModel SelectUserById(int id)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Id = id
                };
                return UserConnection.SelectUserById(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertUser(string userName, int role, string password)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    UserName = userName,
                    Role = role,
                    PasswordHash = PasswordManagement.HashPassword(password)
                };
                return UserConnection.InsertUser(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateUserRoledById(int id, int idRole)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Id = id,
                    Role = idRole
                };
                return UserConnection.UpdateUserRoledById(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateUserPasswordById(int id, string password)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Id = id,
                    PasswordHash = PasswordManagement.HashPassword(password)
                };
                return UserConnection.UpdateUserPasswordById(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteUserById(int id)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Id = id
                };
                return UserConnection.DeletUserById(userModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public static bool ValidateUserPassword(string userName, string password)
        {
            try
            {
                UserModel userModel = SelectUserByUserName(userName);
                if (PasswordManagement.ValidatePassword(password, userModel.PasswordHash))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
