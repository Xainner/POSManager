using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using UI.Utilities;
using BusinessLibrary.Models;
using LogicLibrary.Management;
using FoxLearn.License;

namespace UI.Forms.Extras
{
    public partial class FrmFirstRun : MetroForm
    {
        string tempImage;
        const int ProductCode = 1;

        public FrmFirstRun()
        {
            InitializeComponent();
            startUpAdvancedWizard.NextButtonEnabled = false;
        }

        private void startUpAdvancedWizard_Load(object sender, EventArgs e)
        {

        }

        private void startUpAdvancedWizard_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startUpAdvancedWizard_Finish(object sender, EventArgs e)
        {
            Properties.Settings.Default.startUp = true;
            Properties.Settings.Default.Save();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Dispose();
        }

        private void startUpAdvancedWizard_Back(object sender, EventArgs e)
        {

        }

        private void startUpAdvancedWizard_Help(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Configuración inicial del sistema.", "MiFacturador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startUpAdvancedWizard_Next(object sender, AdvancedWizardControl.EventArguments.WizardEventArgs e)
        {
            switch (e.CurrentPageIndex)
            {
                case 0:
                    
                    break;
                case 1:
                    
                    break;
                case 2:
                    string storeName = fantasyNameTextBox.Text;
                    string societyName = societyNameTextBox.Text;
                    string legalCertification = juridicIdTextBox.Text;
                    string telephone = telephoneTextBox.Text;

                    BusinessModel businessModel = new BusinessModel()
                    {
                        FantasyName = storeName,
                        LegalCertification = legalCertification,
                        Logo = ImageManagement.ImageToByte(ImageManagement.TemporaryImage(pictureBox1.Image)),
                        Telephone = telephone,
                        SocietyName = societyName,
                        Main = 1
                    };
                    Properties.Settings.Default.mainStore = storeName;
                    advancedWizardPage4.HeaderTitle = storeName;
                    break;
            }
        }

        private void startUpAdvancedWizard_Cancel(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------EVENTS---------\\

        private void selectLogoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Seleccione el logo",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tempImage = ImageManagement.TemporaryImage(Image.FromFile(openFileDialog.FileName));
                    pictureBox1.Load(tempImage);
                }
            }
        }

        private void validateSerialButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keyMaskedTextBox.Text))
            {
                if (KeyManagement.SelectKeyByCode(keyMaskedTextBox.Text) != null)
                {
                    KeyManager keyManager = new KeyManager("0000000000");
                    string productKey = keyMaskedTextBox.Text;
                    if (keyManager.ValidKey(ref productKey))
                    {
                        KeyValuesClass keyValuesClass = new KeyValuesClass();
                        if (keyManager.DisassembleKey(productKey, ref keyValuesClass))
                        {
                            LicenseInfo licenseInfo = new LicenseInfo();
                            licenseInfo.ProductKey = productKey;
                            licenseInfo.FullName = "User";
                            keyManager.SaveSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), licenseInfo);
                            MetroMessageBox.Show(this, "¡Licencia ingresada de manera correcta!", "Licencia ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            startUpAdvancedWizard.NextButtonEnabled = false;
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La licencia no es valida.", "Licencia invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else
            {
                MetroMessageBox.Show(this, "Debe ingresar un valor.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
