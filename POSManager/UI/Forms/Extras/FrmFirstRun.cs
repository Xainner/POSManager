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
using LogicLibrary.Utilities;

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
            startUpAdvancedWizard.FinishButtonEnabled = false;
        }

        private void startUpAdvancedWizard_Load(object sender, EventArgs e)
        {

        }

        private void startUpAdvancedWizard_Leave(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "¿Seguro que deseas salir? Esta acción no se puede devolver.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void startUpAdvancedWizard_Finish(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide();
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
                    startUpAdvancedWizard.NextButtonEnabled = false;
                    break;
                case 1:
                    try
                    {
                        if (!string.IsNullOrEmpty(userNameTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(passwordTextBox.Text))
                            {
                                if (!string.IsNullOrEmpty(validatePasswordTextBox.Text))
                                {
                                    if (validatePasswordTextBox.Text.Equals(passwordTextBox.Text))
                                    {
                                        if (UserManagement.InsertUser(userNameTextBox.Text, 0, passwordTextBox.Text))
                                        {
                                            startUpAdvancedWizard.NextButtonEnabled = true;
                                            startUpAdvancedWizard.BackButtonEnabled = false;
                                        }
                                        else
                                        {
                                            MetroMessageBox.Show(this, "Ha ocurrido un error, intentelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, "Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El campo de validación de la contraseña no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "El campo de la contraseña no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El campo del nombre de usuario no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
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
                    startUpAdvancedWizard.FinishButtonEnabled = true;
                    Properties.Settings.Default.Save();
                    break;
            }
        }

        private void startUpAdvancedWizard_Cancel(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "¿Seguro que deseas salir? Esta acción no se puede devolver.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                            startUpAdvancedWizard.NextButtonEnabled = true;
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
