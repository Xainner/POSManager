using BusinessLibrary.Models;
using DataBaseLibrary.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Management
{
    public static class KeyManagement
    {
        public static KeyModel SelectKeyByCode(string code)
        {
            try
            {
                KeyModel keyModel = new KeyModel()
                {
                    KeyCode = code
                };
                return KeyConnection.SelectKeyByCode(keyModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool RegisterKey(string code)
        {
            try
            {
                KeyModel keyModel = new KeyModel()
                {
                    KeyCode = code,
                    Status = true
                };
                return KeyConnection.UpdateKeyStatus(keyModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
