using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary.Management;
using MetroFramework.Forms;
using MetroFramework;
using BusinessLibrary.Models;

namespace UI.Forms
{
    public partial class FrmUser : MetroForm
    {
        public FrmUser(string userName, int id)
        {
            InitializeComponent();
            metroTabControl1.Appearance = TabAppearance.FlatButtons;
            metroTabControl1.ItemSize = new Size(1, 0);
            metroTabControl1.SizeMode = TabSizeMode.Fixed;
            metroLabel4.Text = "Área de usuario";
            Text = userName;
            metroLabel5.Text = id.ToString();
            metroTabControl1.SelectedTab = userTabPage;
            WireUpUserRolesCheckBoxes();
        }

        private void WireUpUserRolesCheckBoxes()
        {
            UserModel userModel = UserManagement.SelectUserById(int.Parse(metroLabel5.Text));
            List<RolesModel> rolesModels = RolesManagement.SelectAllRolesByUserId(userModel.Id);
            if (rolesModels[0].Enabled == 1)
            {
                brandsCheckBox.Checked = true;
            }
            if (rolesModels[1].Enabled == 1)
            {
                clientsCheckBox.Checked = true;
            }
            if (rolesModels[2].Enabled == 1)
            {
                positionsAndSalariesCheckBox.Checked = true;
            }
            if (rolesModels[3].Enabled == 1)
            {
                categoriesAndSubcategoriesCheckBox.Checked = true;
            }
            if (rolesModels[4].Enabled == 1)
            {
                employeesCheckBox.Checked = true;
            }
            if (rolesModels[5].Enabled == 1)
            {
                businessCheckBox.Checked = true;
            }
            if (rolesModels[6].Enabled == 1)
            {
                productsCheckBox.Checked = true;
            }
            if (rolesModels[7].Enabled == 1)
            {
                invoiceSaleCheckBox.Checked = true;
            }
        }

        private void goBackButton1_Click(object sender, EventArgs e)
        {
            metroLabel4.Text = "Área de usuario";
            metroTabControl1.SelectedTab = userTabPage;
        }

        private void goBackButton2_Click(object sender, EventArgs e)
        {
            metroLabel4.Text = "Área de usuario";
            metroTabControl1.SelectedTab = userTabPage;
        }

        private void changePasswordTile_Click(object sender, EventArgs e)
        {
            metroLabel4.Text = "Cambiar contraseña";
            metroTabControl1.SelectedTab = passwordTabPage;
        }

        private void rolesTile_Click(object sender, EventArgs e)
        {
            metroLabel4.Text = "Área de roles";
            metroTabControl1.SelectedTab = rolesTabPage;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(oldPasswordTextBox.Text))
            {
                if (!string.IsNullOrEmpty(newPasswordTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(validatePasswordTextBox.Text))
                    {
                        UserModel userModel = UserManagement.SelectUserById(int.Parse(metroLabel5.Text));
                        if (UserManagement.ValidateUserPassword(userModel.UserName, oldPasswordTextBox.Text))
                        {
                            if (validatePasswordTextBox.Text.Equals(validatePasswordTextBox.Text))
                            {
                                if (UserManagement.UpdateUserPasswordById(int.Parse(metroLabel5.Text), newPasswordTextBox.Text))
                                {
                                    MetroMessageBox.Show(this, $"Contraseña modificada de manera exitosa.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    metroTabControl1.SelectedTab = userTabPage;
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        } else
                        {
                            MetroMessageBox.Show(this, "La contraseña actual no es valida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MetroMessageBox.Show(this, "La contraseña antigua no puede estar vacía", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
