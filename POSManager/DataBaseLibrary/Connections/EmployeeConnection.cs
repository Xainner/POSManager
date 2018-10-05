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

namespace DataBaseLibrary.Connections
{
    public static class EmployeeConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<EmployeeModel> SelectAllEmployees()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<EmployeeModel>("SELECT * FROM employee");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<EmployeeModel> MultipleValueSearch(EmployeeModel employeeModel)
        {
            try
            {
                employeeModel.Name = $"%{ employeeModel.Name }%";
                employeeModel.LastName = $"%{ employeeModel.LastName }%";
                employeeModel.Identification = $"%{ employeeModel.Identification }%";
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<EmployeeModel>("SELECT * FROM employee WHERE Name like @Name OR lastName like @lastName OR Identification like @Identification", employeeModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<EmployeeModel> SelectEmployeesByName(EmployeeModel employeeModel)
        {
            try
            {
                employeeModel.Name = $"%{ employeeModel.Name }%";
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<EmployeeModel>("SELECT * FROM employee WHERE Name like @Name", employeeModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static EmployeeModel SelectEmployeeById(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<EmployeeModel>("SELECT * FROM employee WHERE idEmployee = @idEmployee", employeeModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO employee (Name, lastName, identificationType, Identification, Email, bornDate) VALUES (@Name, @lastName, @identificationType, @Identification, @Email,  @bornDate)", employeeModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateEmployeeById(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE employee SET Name = @Name, lastName = @lastName, identificationType = @identificationType, Identification = @Identification, Email = @Email, bornDate = @bornDate WHERE idEmployee = @idEmployee", employeeModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteEmployeeById(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM employee WHERE idEmployee = @idEmployee", employeeModel);
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
