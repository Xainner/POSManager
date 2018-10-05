using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary.Models;
using LogicLibrary.Management;
using MetroFramework.Forms;
using MetroFramework;

namespace UI.Forms
{
    public partial class FrmPositionsAndSalaries : MetroForm
    {
        //---------GLOBALS---------\\
        List<SalaryModel> salaryModels;
        List<PositionModel> positionModels;

        public FrmPositionsAndSalaries()
        {
            InitializeComponent();
        }

        private void FrmPositionsAndSalaries_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Área de Categorías y SubCategorías.";
            WireUpSalariesGridView();
            WireUpSalariesComboBox();
        }

        private void FrmPositionsAndSalaries_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------SALARY---------\\

        //---------CUSTOM METHODS---------\\

        private void WireUpSalariesGridView()
        {
            salaryModels = SalaryManagement.SelectAllSalaries();
            salariesGridView.MultiSelect = false;
            salariesGridView.DataSource = salaryModels;

            salariesGridView.Columns["IdSalary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            salariesGridView.Columns["SalaryAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            salariesGridView.Columns["RegistrationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            salariesGridView.Columns["IdSalary"].HeaderText = "Id";
            salariesGridView.Columns["SalaryAmount"].HeaderText = "Monto del Salario";
            salariesGridView.Columns["RegistrationDate"].HeaderText = "Fecha de Registro";
        }
        

        private void SearchSalaries()
        {
            if (decimal.TryParse(salarySearchTextBox.Text, out decimal amount))
            {
                if (!string.IsNullOrEmpty(salarySearchTextBox.Text))
                {
                    salariesGridView.DataSource = SalaryManagement.SelectSalariesByAmount(amount);
                }
                else
                {
                    WireUpSalariesGridView();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "El valor ingresado no es un valor valido para un salario.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------EVENTS---------\\

        private void clearSalaryButton_Click(object sender, EventArgs e)
        {
            salaryTextBox.Text = string.Empty;
            salaryIdLabel.Text = "0";
            salarySearchTextBox.Text = string.Empty;
            WireUpSalariesGridView();
        }

        private void salarySearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchSalaries();
        }

        private void salarySearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                SearchSalaries();
            } else
            {
                WireUpSalariesGridView();
            }
        }

        private void salariesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (salariesGridView.SelectedRows[0] != null)
            {
                salaryIdLabel.Text = salariesGridView.CurrentRow.Cells[0].Value.ToString();
                salaryTextBox.Text = salariesGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //---------CRUD---------\\

        private void createSalaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(salaryTextBox.Text))
                {
                    if (decimal.TryParse(salaryTextBox.Text, out decimal amount))
                    {
                        if (SalaryManagement.SelectSalaryByAmount(amount) == null)
                        {
                            if (SalaryManagement.InsertSalary(amount))
                            {
                                toolStripStatusLabel1.Text = "Salario agregado de manera exitosa.";
                                salaryTextBox.Text = string.Empty;
                                salaryIdLabel.Text = "0";
                                WireUpSalariesGridView();
                                WireUpSalariesComboBox();
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Ya existe un salario con el monto ingresado.", "Salario repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El valor ingresado no es un valor valido para un salario.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del monto del salario no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void deleteSalaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!salaryIdLabel.Text.Equals("0"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar el salario: { salaryTextBox.Text }?", "Eliminar salario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (SalaryManagement.DeleteSalaryById(int.Parse(salaryIdLabel.Text)))
                        {
                            toolStripStatusLabel1.Text = "Salario eliminada de manera exitosa.";
                            salaryTextBox.Text = string.Empty;
                            salaryIdLabel.Text = "0";
                            WireUpSalariesGridView();
                            WireUpSalariesComboBox();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar el salario: { salaryTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un salario para poder eliminarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void updateSalaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!salaryIdLabel.Text.Equals("0"))
                {
                    if (!string.IsNullOrEmpty(salaryTextBox.Text))
                    {
                        if (decimal.TryParse(salaryTextBox.Text, out decimal amount))
                        {
                            if (SalaryManagement.SelectSalaryByAmount(amount) == null)
                            {
                                if (SalaryManagement.UpdateSalaryById(int.Parse(salaryIdLabel.Text), amount))
                                {
                                    toolStripStatusLabel1.Text = "Salario modificado de manera exitosa.";
                                    salaryTextBox.Text = string.Empty;
                                    salaryIdLabel.Text = "0";
                                    WireUpSalariesGridView();
                                    //WireUpCategorieComboBox();
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Ya existe un salario con el monto ingresado.", "Salario repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El valor ingresado no es un valor valido para un salario.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El campo del monto del salario no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un salario para poder eliminarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        //---------POSITION---------\\

        //---------CUSTOM METHODS---------\\

        private void WireUpSalariesComboBox()
        {
            salariesComboBox.DataSource = salaryModels;
            salariesComboBox.DisplayMember = "SalaryAmount";
        }

        private void WireUpPositionsGridView()
        {
            positionModels = PositionManagement.SelectAllPositions();
            positionsGridView.MultiSelect = false;
            positionsGridView.DataSource = positionModels;

            positionsGridView.Columns["IdPosition"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            positionsGridView.Columns["IdSalary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            positionsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            positionsGridView.Columns["IdPosition"].HeaderText = "Id";
            positionsGridView.Columns["IdSalary"].HeaderText = "Id Salario";
            positionsGridView.Columns["Name"].HeaderText = "Nombre";
        }

        private void WireUpPositionsGridView(List<PositionModel> positionModels)
        {
            positionsGridView.MultiSelect = false;
            positionsGridView.DataSource = positionModels;

            positionsGridView.Columns["IdPosition"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            positionsGridView.Columns["IdSalary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            positionsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            positionsGridView.Columns["IdPosition"].HeaderText = "Id";
            positionsGridView.Columns["IdSalary"].HeaderText = "Id Salario";
            positionsGridView.Columns["Name"].HeaderText = "Nombre";
        }

        private void SearchPositions()
        {
            if (!string.IsNullOrEmpty(searchPositionTextBox.Text))
            {
                positionsGridView.DataSource = SubCategoryManagement.SelectSubCategoriesByName(searchPositionTextBox.Text);
            }
            else
            {
                WireUpPositionsGridView();
            }
        }

        //---------EVENTS---------\\

        private void positionsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (positionsGridView.SelectedRows[0] != null)
            {
                positionIdLabel.Text = positionsGridView.CurrentRow.Cells[0].Value.ToString();
                positionTextBox.Text = positionsGridView.CurrentRow.Cells[1].Value.ToString();
                foreach (SalaryModel salaryModel in salariesComboBox.Items)
                {
                    int id = int.Parse(positionsGridView.CurrentRow.Cells[2].Value.ToString());
                    if (salaryModel.IdSalary.Equals(id))
                    {
                        salariesComboBox.SelectedItem = salaryModel;
                        break;
                    }
                }
            }
        }

        private void salariesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalaryModel salaryModel = (SalaryModel)salariesComboBox.SelectedItem;
            List<PositionModel> salaryModels = PositionManagement.SelectPositionsBySalaryId(salaryModel.IdSalary);
            WireUpPositionsGridView(salaryModels);
        }

        private void clearPositionButton_Click(object sender, EventArgs e)
        {
            WireUpPositionsGridView();
            positionTextBox.Text = string.Empty;
            searchPositionTextBox.Text = string.Empty;
            positionIdLabel.Text = "0";
        }

        private void searchPositionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchPositions();
        }

        private void searchPositionTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchPositions();
        }

        //---------CRUD---------\\

        private void createPositionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(positionTextBox.Text))
                {
                    if (PositionManagement.SelectPositionByName(positionTextBox.Text) == null)
                    {
                        int idSalary = ((SalaryModel)salariesComboBox.SelectedItem).IdSalary;
                        if (PositionManagement.InsertPosition(idSalary, positionTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "Posición agregada de manera exitosa.";
                            positionTextBox.Text = string.Empty;
                            positionIdLabel.Text = "0";
                            WireUpPositionsGridView();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ya existe una posición con ese nombre.", "subcategoría repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la posición no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void updatePositionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!positionIdLabel.Text.Equals("0"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la posición: { positionTextBox.Text }?", "Modificar posición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int idSalary = ((SalaryModel)salariesComboBox.SelectedItem).IdSalary;
                        if (PositionManagement.UpdatePositionById(int.Parse(positionIdLabel.Text), idSalary, positionTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "Posición modificada de manera exitosa.";
                            positionTextBox.Text = string.Empty;
                            positionIdLabel.Text = "0";
                            WireUpPositionsGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la posición: { positionTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una posición para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void deletePositionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!positionIdLabel.Text.Equals("0"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la posición: { positionTextBox.Text }?", "Eliminar posición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (PositionManagement.DeletePositionById(int.Parse(positionIdLabel.Text)))
                        {
                            toolStripStatusLabel1.Text = "Posición eliminada de manera exitosa.";
                            positionTextBox.Text = string.Empty;
                            positionIdLabel.Text = "0";
                            WireUpPositionsGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la posición: { positionTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una posición para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
