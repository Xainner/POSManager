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
using System.Runtime.InteropServices;
using System.IO;
using UI.Forms.Extras;

namespace UI.Forms
{
    public partial class FrmAdministrator : MetroForm
    {
        //---------GLOBALS---------\\
        List<UserModel> userManagementModels;
        List<UserModel> userRolesModels;
        List<ExternalInvoiceSaleDetailsModel> invoices;
        List<ProductXQuantityModel> productsInvoices;
        List<OffSetDetailsModel> offSet;

        int id;

        //---------FORM---------\\

        public FrmAdministrator(int idOld)
        {
            InitializeComponent();
            id = idOld;
        }

        private void FrmAdministrator_Load(object sender, EventArgs e)
        {
            WireUpUserManagementListBox();
            WireUpUserRolesListBox();
            toolStripStatusLabel1.Text = "Área de usuarios.";
            metroTabControl1.SelectedTab = metroTabPage1;
            inicioFecha.Enabled = false;
            metroButton1.Enabled = false;
            finalFecha.Enabled = false;
            firstDateTime.Enabled = false;
            secondDateTime.Enabled = false;
            searchOffsetButton.Enabled = false;
            comboBoxRangos.SelectedIndex = 0;
            rangosProductos.SelectedIndex = 0;
            invoices = ExternalInvoiceSaleManagement.SelectInvoices();
            metroGrid1.DataSource = invoices;
            offSet = OffsetDetailsManagement.SelectAllOffsetDetails();
            offsetmetroGrid.DataSource = offSet;
            offsetmetroGrid.Columns.RemoveAt(3);
            offsetmetroGrid.Columns.RemoveAt(3);
        }

        private void FrmAdministrator_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------USER MANAGEMENT---------\\

        //---------CUSTOM METHODS---------\\

        private void WireUpUserManagementListBox()
        {
            userManagementModels = UserManagement.SelectAllUsers();
            userManagementListBox.DataSource = userManagementModels;
            userManagementListBox.DisplayMember = "UserName";
        }

        private void ClearUserManagement()
        {
            userNameTextBox.Text = string.Empty;
            userNameTextBox.Enabled = true;
            passwordTextBox.Text = string.Empty;
            validatePasswordTextBox.Text = string.Empty;
            userManagementIdLabel.Text = "Seleccione un usuario";
            userTypeRadioButton.Enabled = true;
            userTypeRadioButton.Checked = true;
        }

        private void userManagementSearchUsers()
        {
            if (!string.IsNullOrEmpty(userNameTextBox.Text))
            {
                userManagementListBox.DataSource = UserManagement.SelectUsersByUserName(userManagementSearchTextBox.Text);
            }
            else
            {
                WireUpUserManagementListBox();
            }
        }

        private void UpdateUserRoledById()
        {
            if (!userManagementIdLabel.Text.Equals("Seleccione un usuario"))
            {
                if (userTypeRadioButton.Checked)
                {
                    UserManagement.UpdateUserRoledById(int.Parse(userManagementIdLabel.Text), 1);
                }
                else
                {
                    UserManagement.UpdateUserRoledById(int.Parse(userManagementIdLabel.Text), 0);
                }
                WireUpUserManagementListBox();
            }
        }

        //---------EVENTS---------\\

        private void adminTypeRadioButton_Click(object sender, EventArgs e)
        {
            UpdateUserRoledById();
        }

        private void userTypeRadioButton_Click(object sender, EventArgs e)
        {
            UpdateUserRoledById();
        }

        private void userManagementListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserModel userModel = (UserModel)userManagementListBox.SelectedItem;
            if (userModel != null)
            {
                userNameTextBox.Text = userModel.UserName;
                userManagementIdLabel.Text = userModel.Id.ToString();
                userNameTextBox.Enabled = false;
                if (userModel.Role != 0)
                {
                    userTypeRadioButton.Checked = true;
                } else
                {
                    adminTypeRadioButton.Checked = true;
                    userTypeRadioButton.Enabled = false;
                }
            }
        }

        private void userManagementSearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            userManagementSearchUsers();
        }

        private void userManagementSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            userManagementSearchUsers();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearUserManagement();
        }

        //---------CRUD---------\\

        private void createButton_Click(object sender, EventArgs e)
        {
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
                                if (UserManagement.SelectUserByUserName(userNameTextBox.Text) == null)
                                {
                                    int role;
                                    if (userTypeRadioButton.Checked)
                                    {
                                        role = 1;
                                    } else
                                    {
                                        role = 0;
                                    }
                                    if (UserManagement.InsertUser(userNameTextBox.Text, role, passwordTextBox.Text))
                                    {
                                        toolStripStatusLabel1.Text = "Usuario registrado de manera exitosa.";
                                        ClearUserManagement();
                                        WireUpUserManagementListBox();
                                        WireUpUserRolesListBox();
                                    } else
                                    {
                                        MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar el usuario: { userNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Ya existe un usuario con ese nombre, por favor verifique sus datos.", "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            } else
                            {
                                MetroMessageBox.Show(this, "Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        } else
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
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!userManagementIdLabel.Text.Equals("Seleccione un usuario"))
                {
                    if (!string.IsNullOrEmpty(passwordTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(validatePasswordTextBox.Text))
                        {
                            if (validatePasswordTextBox.Text.Equals(passwordTextBox.Text))
                            {
                                if (UserManagement.UpdateUserPasswordById(int.Parse(userManagementIdLabel.Text), passwordTextBox.Text))
                                {
                                    toolStripStatusLabel1.Text = "Usuario modificado de manera exitosa.";
                                    ClearUserManagement();
                                    WireUpUserManagementListBox();
                                    WireUpUserRolesListBox();
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar el usuario: { userNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MetroMessageBox.Show(this, "Debe seleccionar un usuario para poder modificarlo", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(userManagementIdLabel.Text) != id)
                {
                    if (!userManagementIdLabel.Text.Equals("Seleccione un usuario"))
                    {
                        if (UserManagement.DeleteUserById(int.Parse(userManagementIdLabel.Text)))
                        {
                            toolStripStatusLabel1.Text = "Usuario eliminado de manera exitosa.";
                            ClearUserManagement();
                            WireUpUserManagementListBox();
                            WireUpUserRolesListBox();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar el usuario: { userNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Debe seleccionar un usuario para poder eliminarlo.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    MetroMessageBox.Show(this, $"No se puede eliminar el usuario actual: { userNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //---------USER ROLES---------\\

        //---------CUSTOM METHODS---------\\

        private void WireUpUserRolesListBox()
        {
            userRolesModels = UserManagement.SelectUsersByRole(1);
            userRolesListBox.DataSource = userRolesModels;
            userRolesListBox.DisplayMember = "UserName";
        }

        private void userRoleSearchUsers()
        {
            if (!string.IsNullOrEmpty(userRolesSearchTextBox.Text))
            {
                userRolesListBox.DataSource = UserManagement.SelectUsersByUserName(userRolesSearchTextBox.Text, 1);
            }
            else
            {
                WireUpUserRolesListBox();
            }
        }

        //---------EVENTS---------\\
        private void userRolesSearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            userRoleSearchUsers();
        }

        private void userRolesSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            userRoleSearchUsers();
        }

        private void updateRolesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar los permisos de: { userRolesUserNameLabel.Text }?", "Modificar Permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    List<RolesModel> rolesModels = new List<RolesModel>();

                    RolesModel brandRole = new RolesModel();
                    brandRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (brandsCheckBox.Checked)
                    {
                        brandRole.Enabled = 1;
                        brandRole.IdRole = 1;
                    }
                    brandRole.IdRole = 1;
                    rolesModels.Add(brandRole);

                    RolesModel clientRole = new RolesModel();
                    clientRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (clientsCheckBox.Checked)
                    {
                        clientRole.Enabled = 1;

                    }
                    clientRole.IdRole = 2;
                    rolesModels.Add(clientRole);

                    RolesModel positionsnAndSalariesRole = new RolesModel();
                    positionsnAndSalariesRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (positionsAndSalariesCheckBox.Checked)
                    {
                        positionsnAndSalariesRole.Enabled = 1;
                        positionsnAndSalariesRole.IdRole = 3;

                    }
                    positionsnAndSalariesRole.IdRole = 3;
                    rolesModels.Add(positionsnAndSalariesRole);

                    RolesModel categoriesAndSubCategories = new RolesModel();
                    categoriesAndSubCategories.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (categoriesAndSubcategoriesCheckBox.Checked)
                    {
                        categoriesAndSubCategories.Enabled = 1;
                        categoriesAndSubCategories.IdRole = 4;

                    }
                    categoriesAndSubCategories.IdRole = 4;
                    rolesModels.Add(categoriesAndSubCategories);

                    RolesModel employeesRole = new RolesModel();
                    employeesRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (employeesCheckBox.Checked)
                    {
                        employeesRole.Enabled = 1;
                        employeesRole.IdRole = 5;

                    }
                    employeesRole.IdRole = 5;
                    rolesModels.Add(employeesRole);

                    RolesModel businessRole = new RolesModel();
                    businessRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (businessCheckBox.Checked)
                    {
                        businessRole.Enabled = 1;
                        businessRole.IdRole = 6;

                    }
                    businessRole.IdRole = 6;
                    rolesModels.Add(businessRole);

                    RolesModel productsRole = new RolesModel();
                    productsRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (productsCheckBox.Checked)
                    {
                        productsRole.Enabled = 1;
                        productsRole.IdRole = 7;

                    }
                    productsRole.IdRole = 7;
                    rolesModels.Add(productsRole);

                    RolesModel invoiceSaleRole = new RolesModel();
                    invoiceSaleRole.IdUser = ((UserModel)userRolesListBox.SelectedItem).Id;
                    if (invoiceSaleCheckBox.Checked)
                    {
                        invoiceSaleRole.Enabled = 1;
                        invoiceSaleRole.IdRole = 8;
                    }
                    invoiceSaleRole.IdRole = 8;
                    rolesModels.Add(invoiceSaleRole);

                    if (RolesManagement.UpdateUserRolesById(rolesModels))
                    {
                        toolStripStatusLabel1.Text = "Permisos modificados de manera exitosa.";
                        userRolesSearchTextBox.Text = string.Empty;
                        WireUpUserRolesListBox();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar los permisos: { userRolesUserNameLabel.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void userRolesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserModel userModel = (UserModel)userRolesListBox.SelectedItem;
            userRolesUserNameLabel.Text = userModel.UserName;
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

        private void comboBoxRangos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRangos.SelectedIndex == 1)
            {
                inicioFecha.Enabled = true;
                finalFecha.Enabled = true;
                metroButton1.Enabled = true;
            } else
            {
                inicioFecha.Enabled = false;
                finalFecha.Enabled = false;
                metroButton1.Enabled = false;
            }
            switch (comboBoxRangos.SelectedIndex)
            {
                case 0:
                    invoices = ExternalInvoiceSaleManagement.SelectInvoicesByDay(DateTime.Today);
                    break;                  
            }
            metroGrid1.DataSource = invoices;
            GetTotal();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            invoices = ExternalInvoiceSaleManagement.SelectInvoicesByDate(inicioFecha.Value, finalFecha.Value);
            metroGrid1.DataSource = invoices;
            GetTotal();
        }

        private void GetTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in metroGrid1.Rows)
            {
                total += decimal.Parse(item.Cells[11].Value.ToString());
            }
            totalTextBox.Text = total.ToString("#.##");
        }

        ///PRODUCTS

        private void buscarFechaProductos_Click(object sender, EventArgs e)
        {
            productsInvoices = ExternalInvoiceSaleManagement.SelectProductsByDate(inicioFechaProductos.Value, finFechaProductos.Value);
            metroGrid2.DataSource = productsInvoices;
        }

        private void rangosProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rangosProductos.SelectedIndex == 1)
            {
                inicioFechaProductos.Enabled = true;
                finFechaProductos.Enabled = true;
                buscarFechaProductos.Enabled = true;
            }
            else
            {
                inicioFechaProductos.Enabled = false;
                finFechaProductos.Enabled = false;
                buscarFechaProductos.Enabled = false;
            }
            switch (rangosProductos.SelectedIndex)
            {
                case 0:
                    productsInvoices = ExternalInvoiceSaleManagement.SelectProductsByDay(DateTime.Today);
                    break;
            }
            metroGrid2.DataSource = productsInvoices;
        }

        private void ExportProductsButton_Click(object sender, EventArgs e)
        {
            if (metroGrid2.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "CustomerDetail";

                for (int i = 1; i < metroGrid2.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = metroGrid2.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < metroGrid2.Rows.Count; i++)
                {
                    for (int j = 0; j < metroGrid2.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = metroGrid2.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "Productos";
                saveFileDialoge.DefaultExt = "xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
        }

        private void ExportInvoiceButton_Click(object sender, EventArgs e)
        {
            if (metroGrid1.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "CustomerDetail";

                for (int i = 1; i < metroGrid1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = metroGrid1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    for (int j = 0; j < metroGrid1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = metroGrid1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "Facturas";
                saveFileDialoge.DefaultExt = "xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialoge.FileName))
                    {
                        File.Delete(saveFileDialoge.FileName);
                    }
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (metroGrid1.CurrentRow != null)
                {
                    FrmViewInvoiceSale frmViewInvoiceSale = new FrmViewInvoiceSale(int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                    frmViewInvoiceSale.Show();
                }
            }
            catch (Exception ex)
            {

                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        //-----------------------------AREA DE APARTADOS ---------------------------------

        private void GetPaymentsOffset()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in offsetmetroGrid.Rows)
            {
                total += decimal.Parse(item.Cells[9].Value.ToString());
            }
            totalOffsetTextBox.Text = total.ToString("#.##");
        }

        private void offsetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime morning = DateTime.Today;
            DateTime night = DateTime.Today;

            if (offsetComboBox.SelectedIndex == 1)
            {
                firstDateTime.Enabled = true;
                secondDateTime.Enabled = true;
                searchOffsetButton.Enabled = true;
            }
            else
            {
                firstDateTime.Enabled = false;
                secondDateTime.Enabled = false;
                searchOffsetButton.Enabled = false;
            }
            switch (offsetComboBox.SelectedIndex)
            {
                case 0:
                    offSet = OffsetDetailsManagement.SelectOffsetByDay(morning.ToString("dd-MM-yyyy 00:00:00"), night.ToString("dd-MM-yyyy 23:59:59"));
                    offsetmetroGrid.DataSource = offSet;
                    offsetmetroGrid.Columns.RemoveAt(3);
                    offsetmetroGrid.Columns.RemoveAt(3);
                    GetPaymentsOffset();
                    break;
            }

        }

        private void searchOffsetButton_Click(object sender, EventArgs e)
        {
            DateTime first = firstDateTime.Value;
            DateTime second = secondDateTime.Value;

            offSet = OffsetDetailsManagement.SelectOffsetByDate(first.ToString("dd-MM-yyyy 00:00:00"), second.ToString("dd-MM-yyyy 23:59:59"));
            offsetmetroGrid.DataSource = offSet;
            offsetmetroGrid.Columns.RemoveAt(3);
            offsetmetroGrid.Columns.RemoveAt(3);
            GetPaymentsOffset();
        }

        private void offsetmetroGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (offsetmetroGrid.CurrentRow != null)
                {
                    FrmViewOffsetDetails frmViewOffsetDetails = new FrmViewOffsetDetails(offsetmetroGrid.CurrentRow.Cells[0].Value.ToString());
                    frmViewOffsetDetails.Show();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private void ExportOffsetButton_Click(object sender, EventArgs e)
        {
            if (offsetmetroGrid.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "CustomerDetail";

                for (int i = 1; i < offsetmetroGrid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = offsetmetroGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < offsetmetroGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < offsetmetroGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = offsetmetroGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "Apartados";
                saveFileDialoge.DefaultExt = "xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialoge.FileName))
                    {
                        File.Delete(saveFileDialoge.FileName);
                    }
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
        }
    }
}
