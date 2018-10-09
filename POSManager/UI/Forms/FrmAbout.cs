using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;
using MetroFramework.Forms;

namespace UI.Forms
{
    public partial class FrmAbout : MetroForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            string key = "0000000000";
            KeyManager keyManager = new KeyManager(key);
            LicenseInfo licenseInfo = new LicenseInfo();
            int value = keyManager.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref licenseInfo);
            string productKey = licenseInfo.ProductKey;
            if (keyManager.ValidKey(ref productKey))
            {
                KeyValuesClass keyValuesClass = new KeyValuesClass();
                if (keyManager.DisassembleKey(productKey, ref keyValuesClass))
                {
                    productNameLabel.Text = "MiFacturador";
                    productKeyLabel.Text = productKey;
                    licenseTypeLabel.Text = "Completa";
                }
            }
        }
    }
}
