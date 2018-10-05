using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class PositionManagement
    {
        public static List<PositionModel> SelectAllPositions()
        {
            try
            {
                return PositionConnection.SelectAllPositions();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<PositionModel> SelectPositionsByName(string name)
        {
            try
            {
                PositionModel positionModel = new PositionModel()
                {
                    Name = name
                };
                return PositionConnection.SelectPositionsByName(positionModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<PositionModel> SelectPositionsBySalaryId(int id)
        {
            try
            {
                PositionModel positionModel = new PositionModel()
                {
                    IdSalary = id
                };
                return PositionConnection.SelectPositionsBySalaryId(positionModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static PositionModel SelectPositionByName(string name)
        {
            try
            {
                PositionModel positionModel = new PositionModel()
                {
                    Name = name
                };
                return PositionConnection.SelectPositionByName(positionModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertPosition(int id, string name)
        {
            try
            {
                PositionModel positionModel = new PositionModel()
                {
                    IdSalary = id,
                    Name = name
                };
                return PositionConnection.InsertPosition(positionModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdatePositionById(int id, int idSalary, string name)
        {
            try
            {
                PositionModel positionModel = new PositionModel()
                {
                    IdPosition = id,
                    IdSalary = idSalary,
                    Name = name
                };
                return PositionConnection.UpdatePositionById(positionModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeletePositionById(int id)
        {
            try
            {
                PositionModel positionModel = new PositionModel()
                {
                    IdPosition = id
                };
                return PositionConnection.DeletePositionById(positionModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
