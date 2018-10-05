using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class SalaryManagement
    {
        public static List<SalaryModel> SelectAllSalaries()
        {
            try
            {
                return SalaryConnection.SelectAllSalaries();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SalaryModel> SelectSalariesByAmount(decimal amount)
        {
            try
            {
                SalaryModel salaryModel = new SalaryModel()
                {
                    SalaryAmount = amount
                };
                return SalaryConnection.SelectSalariesByAmount(salaryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SalaryModel SelectSalaryById(int id)
        {
            try
            {
                SalaryModel salaryModel = new SalaryModel()
                {
                    IdSalary = id
                };
                return SalaryConnection.SelectSalaryById(salaryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SalaryModel SelectSalaryByAmount(decimal amount)
        {
            try
            {
                SalaryModel salaryModel = new SalaryModel()
                {
                    SalaryAmount = amount
                };
                return SalaryConnection.SelectSalaryByAmount(salaryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertSalary(decimal amount)
        {
            try
            {
                SalaryModel salaryModel = new SalaryModel()
                {
                    SalaryAmount = amount
                };
                return SalaryConnection.InsertSalary(salaryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateSalaryById(int id, decimal amount)
        {
            try
            {
                SalaryModel salaryModel = new SalaryModel()
                {
                    IdSalary = id,
                    SalaryAmount = amount
                };
                return SalaryConnection.UpdateSalaryById(salaryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteSalaryById(int id)
        {
            try
            {
                SalaryModel salaryModel = new SalaryModel()
                {
                    IdSalary = id
                };
                return SalaryConnection.DeleteSalaryById(salaryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
