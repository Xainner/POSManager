using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class BusinessManagement
    {
        public static List<BusinessModel> SelectAllBusiness()
        {
            try
            {
                return BusinessConnection.SelectAllBusinesses();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BusinessModel> SelectBusinessesByName(string name)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    FantasyName = name
                };
                return BusinessConnection.SelectBusinessesByFantasyName(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BusinessModel SelectMainBusiness()
        {
            try
            {
                return BusinessConnection.SelectMainBusiness();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static int SelectMainBusinessId()
        {
            try
            {
                return BusinessConnection.SelectMainBusinessId();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BusinessModel SelectBusinessById(int id)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    IdBusiness = id
                };
                return BusinessConnection.SelectBusinessById(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertBusiness(string fantasyName, string societyName, string legalCertification, string telephone, string mainAddress, string generalAddress, string email, string webPage, byte[] logo)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    FantasyName = fantasyName,
                    SocietyName = societyName,
                    LegalCertification = legalCertification,
                    Telephone = telephone,
                    MainAddress = mainAddress,
                    GeneralAddress = generalAddress,
                    Email = email,
                    WebPage = webPage,
                    Logo = logo
                };
                return BusinessConnection.InsertBusiness(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateBusinessById(int id, string fantasyName, string telephone, string mainAddress, string generalAddress, string email, string webPage, byte[] logo)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    IdBusiness = id,
                    FantasyName = fantasyName,
                    Telephone = telephone,
                    MainAddress = mainAddress,
                    GeneralAddress = generalAddress,
                    Email = email,
                    WebPage = webPage,
                    Logo = logo
                };
                return BusinessConnection.UpdateBusinessById(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteBusinessById(int id)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    IdBusiness = id
                };
                return BusinessConnection.DeleteBusinessById(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool InsertBusiness(string fantasyName, string societyName, string legalCertification, int main, string telephone, byte[] logo)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    FantasyName = fantasyName, SocietyName = societyName, LegalCertification = legalCertification, Main = main, Telephone = telephone, Logo = logo, GeneralAddress = "", MainAddress = ""
                };
                return BusinessConnection.InsertBusiness(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
