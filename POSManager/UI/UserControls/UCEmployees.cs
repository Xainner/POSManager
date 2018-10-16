using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using BusinessLibrary.Models;
using LogicLibrary.Management;
using MetroFramework;

namespace UI.UserControls
{
    public partial class UCEmployees : MetroUserControl
    {
        //---------GLOBALS---------\\
        List<EmployeeModel> clientModels;

        //---------FORM---------\\
        public UCEmployees()
        {
            InitializeComponent();
        }

        private void UCClients_Load(object sender, EventArgs e)
        {
            FrmMain.Instance.ToolStripLabel.Text = "Área de empleados.";
            WireUpClientsGridView();
        }

        private void UCClients_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------CUSTOM METHODS---------\\

        private void Clear()
        {
            nameTextBox.Text = string.Empty;
            lastnameTextBox.Text = string.Empty;
            identificationTextBox.Text = string.Empty;
            searchTextBox.Text = string.Empty;
            clientIdLabel.Text = "Vacío";
        }

        private void WireUpClientsGridView()
        {
            clientModels = EmployeeManagement.SelectAllEmployees();
            clientsGridView.MultiSelect = false;
            clientsGridView.DataSource = clientModels;

            clientsGridView.Columns["IdEmployee"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsGridView.Columns["Lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsGridView.Columns["IdentificationType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsGridView.Columns["Identification"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsGridView.Columns["BornDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsGridView.Columns["RegistrationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            clientsGridView.Columns["IdEmployee"].HeaderText = "Id";
            clientsGridView.Columns["Name"].HeaderText = "Nombre";
            clientsGridView.Columns["Lastname"].HeaderText = "Apellidos";
            clientsGridView.Columns["IdentificationType"].HeaderText = "Tipo de Identificación";
            clientsGridView.Columns["Identification"].HeaderText = "Identificación";
            clientsGridView.Columns["BornDate"].HeaderText = "Fecha de Nacimiento";
            clientsGridView.Columns["RegistrationDate"].HeaderText = "Fecha de Registro";
        }

        private void SearchClients()
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                clientsGridView.DataSource = ClientManagement.SelectClientsByName(searchTextBox.Text);
            }
            else
            {
                WireUpClientsGridView();
            }
        }
        //---------EVENTS---------\\

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void searchTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchClients();
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchClients();
        }

        private void clientsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientsGridView.SelectedRows[0] != null)
            {
                clientIdLabel.Text = clientsGridView.CurrentRow.Cells[0].Value.ToString();
                nameTextBox.Text = clientsGridView.CurrentRow.Cells[1].Value.ToString();
                lastnameTextBox.Text = clientsGridView.CurrentRow.Cells[2].Value.ToString();
                identificationTextBox.Text = clientsGridView.CurrentRow.Cells[4].Value.ToString();
                bornDateDateTime.Text = clientsGridView.CurrentRow.Cells[6].Value.ToString();

                foreach (string idTypes in idTypeComboBox.Items)
                {
                    if (idTypes.Equals(clientsGridView.CurrentRow.Cells[3].Value.ToString()))
                    {
                        idTypeComboBox.SelectedItem = idTypes;
                        break;
                    }
                }
            }
        }

        //---------CRUD---------\\


        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(nameTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(lastnameTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(identificationTextBox.Text) && EmployeeManagement.SelectIdentification(identificationTextBox.Text) == null)
                        {
                            if (MetroMessageBox.Show(this, $"¿Seguro que desea agregar al empleado: { nameTextBox.Text }?", "Modificar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                if (EmployeeManagement.InsertEmployee(nameTextBox.Text, lastnameTextBox.Text, idTypeComboBox.SelectedItem.ToString(),
                                    identificationTextBox.Text, bornDateDateTime.Value))
                                {
                                    FrmMain.Instance.ToolStripLabel.Text = "empleado agregado de manera exitosa.";
                                    Clear();
                                    clientIdLabel.Text = "Vacío";
                                    WireUpClientsGridView();
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar al empleado: { nameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "La identificación no puede ser vacía, ni repetida", "Campo vacío o Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El apellido del empleado no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El nombre del empleado no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!clientIdLabel.Text.Equals("Vacío"))
                {
                    if (!string.IsNullOrEmpty(nameTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(lastnameTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(identificationTextBox.Text) && EmployeeManagement.SelectIdentification(identificationTextBox.Text) == null)
                            {
                                if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar al empleado: { clientsGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    if (EmployeeManagement.UpdateEmployeeById(int.Parse(clientIdLabel.Text), nameTextBox.Text, lastnameTextBox.Text, idTypeComboBox.SelectedItem.ToString(),
                                        identificationTextBox.Text, bornDateDateTime.Value))
                                    {
                                        FrmMain.Instance.ToolStripLabel.Text = "empleado modificado de manera exitosa.";
                                        Clear();
                                        clientIdLabel.Text = "Vacío";
                                        WireUpClientsGridView();
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar al empleado: { nameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La identificación no puede ser vacía, ni repetida", "Campo vacío o Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El apellido del empleado no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El nombre del empleado no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un empleado para poder modificarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!clientIdLabel.Text.Equals("Vacío"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar al empleado: { nameTextBox.Text }?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (EmployeeManagement.DeleteEmployeeById(int.Parse(clientIdLabel.Text)))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "empleado eliminado de manera exitosa.";
                            Clear();
                            clientIdLabel.Text = "Vacío";
                            WireUpClientsGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar al empleado: { nameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un empleado para poder eliminarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
