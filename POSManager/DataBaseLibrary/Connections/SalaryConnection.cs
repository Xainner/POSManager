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
    public static class SalaryConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<SalaryModel> SelectAllSalaries()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SalaryModel>("SELECT * FROM salary");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SalaryModel> SelectSalariesByAmount(SalaryModel salaryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SalaryModel>("SELECT * FROM salary WHERE SalaryAmount like @value", new { value = "%" + salaryModel.SalaryAmount + "%" });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SalaryModel SelectSalaryById(SalaryModel salaryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SalaryModel>("SELECT * FROM salary WHERE IdSalary = @IdSalary", salaryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static SalaryModel SelectSalaryByAmount(SalaryModel salaryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SalaryModel>("SELECT * FROM salary WHERE SalaryAmount = @SalaryAmount", salaryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertSalary(SalaryModel salaryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO salary (SalaryAmount) VALUES(@SalaryAmount)", salaryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteSalaryById(SalaryModel salaryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM salary WHERE idSalary = @IdSalary", salaryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateSalaryById(SalaryModel salaryModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE salary SET SalaryAmount = @SalaryAmount WHERE idSalary = @IdSalary", salaryModel);
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
