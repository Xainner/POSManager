using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLibrary.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace DataBaseLibrary
{
    public static class ClientConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<ClientModel> SelectAllClients()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ClientModel>("SELECT * FROM client");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ClientModel> MultipleValueSearch(ClientModel clientModel)
        {
            try
            {
                clientModel.Name = $"%{ clientModel.Name }%";
                clientModel.Lastname = $"%{ clientModel.Lastname }%";
                clientModel.Identification = $"%{ clientModel.Identification }%";
                clientModel.Email = $"%{ clientModel.Email }%";
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ClientModel>("SELECT * FROM client WHERE Name like @Name OR lastName like @lastName OR Identification like @Identification OR Email like @Email", clientModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<ClientModel> SelectClientsByName(ClientModel clientModel)
        {
            try
            {
                clientModel.Name = $"%{ clientModel.Name }%";
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ClientModel>("SELECT * FROM client WHERE Name like @Name", clientModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static ClientModel SelectClientById(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ClientModel>("SELECT * FROM client WHERE idClient = @idClient", clientModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertClient(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO client (Name, lastName, identificationType, Identification, Email, bornDate) VALUES (@Name, @lastName, @identificationType, @Identification, @Email,  @bornDate)", clientModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateClientById(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE client SET Name = @Name, lastName = @lastName, identificationType = @identificationType, Identification = @Identification, Email = @Email, bornDate = @bornDate WHERE idClient = @idClient", clientModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteClientById(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM client WHERE idClient = @idClient", clientModel);
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
