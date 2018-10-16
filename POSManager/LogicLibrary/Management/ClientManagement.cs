using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class ClientManagement
    {
        public static List<ClientModel> SelectAllClients()
        {
            try
            {
                return ClientConnection.SelectAllClients();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ClientModel> MultipleValueSearch(string value)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Name = value,
                    Email = value,
                    Identification = value,
                    Lastname = value
                };
                return ClientConnection.MultipleValueSearch(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ClientModel> SelectClientsByName(string name)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Name = name
                };
                return ClientConnection.SelectClientsByName(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static ClientModel SelectClientById(int id)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    IdClient = id
                };
                return ClientConnection.SelectClientById(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static ClientModel SelectIdentification(string identification)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Identification = identification
                };
                return ClientConnection.SelectIdentification(clientModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertClient(string name, string lastName, string idType, string identification, string email, DateTime bornDate)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Name = name,
                    Lastname = lastName,
                    IdentificationType = idType,
                    Email = email,
                    Identification = identification,
                    BornDate = bornDate
                };
                return ClientConnection.InsertClient(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateClientById(int id, string name, string lastName, string idType, string identification, string email, DateTime bornDate)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    IdClient = id,
                    Name = name,
                    Lastname = lastName,
                    IdentificationType = idType,
                    Email = email,
                    Identification = identification,
                    BornDate = bornDate
                };
                return ClientConnection.UpdateClientById(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteClientById(int id)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    IdClient = id
                };
                return ClientConnection.DeleteClientById(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
