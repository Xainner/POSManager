using BusinessLibrary.Models;
using DataBaseLibrary.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class EmployeeManagement
    {
        public static List<EmployeeModel> SelectAllEmployees()
        {
            try
            {
                return EmployeeConnection.SelectAllEmployees();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<EmployeeModel> MultipleValueSearch(string value)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Name = value,
                    Identification = value,
                    Lastname = value
                };
                return EmployeeConnection.MultipleValueSearch(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<EmployeeModel> SelectEmployeesByName(string name)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Name = name
                };
                return EmployeeConnection.SelectEmployeesByName(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static EmployeeModel SelectEmployeeById(int id)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    IdEmployee = id
                };
                return EmployeeConnection.SelectEmployeeById(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static EmployeeModel SelectIdentification(string identification)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Identification = identification
                };
                return EmployeeConnection.SelectIdentification(employeeModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertEmployee(string name, string lastName, string idType, string identification, DateTime bornDate)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Name = name,
                    Lastname = lastName,
                    IdentificationType = idType,
                    Identification = identification,
                    BornDate = bornDate
                };
                return EmployeeConnection.InsertEmployee(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateEmployeeById(int id, string name, string lastName, string idType, string identification, DateTime bornDate)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    IdEmployee = id,
                    Name = name,
                    Lastname = lastName,
                    IdentificationType = idType,
                    Identification = identification,
                    BornDate = bornDate
                };
                return EmployeeConnection.UpdateEmployeeById(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteEmployeeById(int id)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    IdEmployee = id
                };
                return EmployeeConnection.DeleteEmployeeById(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
