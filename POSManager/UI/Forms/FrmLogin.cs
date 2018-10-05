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
using LogicLibrary.Management;
using BusinessLibrary.Models;
using LogicLibrary.Utilities;

namespace UI.Forms
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                if (!string.IsNullOrEmpty(userNameTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(passwordTextBox.Text))
                    {
                        if (UserManagement.SelectUserByUserName(userNameTextBox.Text) != null)
                        {
                            if (UserManagement.ValidateUserPassword(userNameTextBox.Text, passwordTextBox.Text))
                            {
                                UserModel userModel = UserManagement.SelectUserByUserName(userNameTextBox.Text);
                                FrmMain frmMain = new FrmMain(userModel);
                                frmMain.Show();
                                frmMain.FormClosed += new FormClosedEventHandler(frmMain_FormClosed);
                                Hide();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Usuario o contraseña no correctos, por favor verifique sus datos.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "No existe un usuario con ese nombre, por favor verifique sus datos.", "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void userNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
