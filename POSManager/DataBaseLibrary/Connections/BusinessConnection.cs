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
    public static class BusinessConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<BusinessModel> SelectAllBusinesses()
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BusinessModel>("SELECT * FROM business");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BusinessModel> SelectBusinessesByFantasyName(BusinessModel businessModel)
        {
            try
            {
                BusinessModel auxModel = new BusinessModel()
                {
                    FantasyName = $"%{ businessModel.FantasyName }%"
                };
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BusinessModel>("SELECT * FROM business WHERE fantasyName like @FantasyName", auxModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BusinessModel SelectBusinessById(BusinessModel businessModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BusinessModel>("SELECT * FROM business WHERE idBusiness = @IdBusiness", businessModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertBusiness(BusinessModel businessModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO business" +
                        "(fantasyName, societyName, legalCertification, Telephone, mainAddress, " +
                        "generalAddress, Email, webPage, Logo) VALUES" +
                        "(@FantasyName, @SocietyName, @LegalCertification, @Telephone, @MainAddress, " +
                        "@GeneralAddress, @Email, @WebPage, @Logo)", businessModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteBusinessById(BusinessModel businessModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM business WHERE idBusiness = @IdBusiness", businessModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateBusinessById(BusinessModel businessModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE business " +
                        "SET fantasyName = @FantasyName, Telephone = @Telephone, " +
                        "mainAddress = @MainAddress, generalAddress = @GeneralAddress, " +
                        "Email = @Email, webPage = @WebPage, Logo = @Logo " +
                        "WHERE idBusiness = @IdBusiness", businessModel);
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
