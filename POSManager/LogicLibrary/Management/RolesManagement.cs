using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class RolesManagement
    {
        public static List<RolesModel> SelectAllRolesByUserId(int id)
        {
            try
            {
                RolesModel rolesModel = new RolesModel()
                {
                    IdUser = id
                };
                return RolesConnection.SelectAllRolesByUserId(rolesModel);
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
                return RolesConnection.UpdateUserRolesById(rolesModels);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
