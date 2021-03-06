﻿using LogicLibrary.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;
using UI.Forms.Extras;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (BusinessManagement.SelectMainBusiness() == null)
            {
                Application.Run(new FrmFirstRun());
            } else
            {
                Application.Run(new FrmLogin());
            }
        }
    }
}
