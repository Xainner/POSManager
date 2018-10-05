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
using BusinessLibrary.Models;
using LogicLibrary.Management;

namespace UI.Forms
{
    public partial class FrmBrands : MetroForm
    {

        //---------GLOBALS---------\\
        List<BrandModel> brandModels;

        //---------FORM---------\\

        public FrmBrands()
        {
            InitializeComponent();
        }

        private void FrmBrands_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Área de marcas.";
            WireUpBrandsDataGridView();
        }

        private void FrmBrands_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------CUSTOM METHODS---------\\
        private void WireUpBrandsDataGridView()
        {
            brandModels = BrandManagement.SelectAllBrands();
            brandsGridView.MultiSelect = false;
            brandsGridView.DataSource = brandModels;

            brandsGridView.Columns["idBrand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            brandsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brandsGridView.Columns["idBrand"].HeaderText = "Id";
            brandsGridView.Columns["Name"].HeaderText = "Nombre";
        }

        private void SearchBrands()
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                brandsGridView.DataSource = BrandManagement.SelectBrandsByName(searchTextBox.Text);
            }
            else
            {
                WireUpBrandsDataGridView();
            }
        }

        //---------EVENTS---------\\

        private void searchTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchBrands();
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchBrands();
        }

        private void brandsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (brandsGridView.SelectedRows[0] != null)
            {
                idLabel.Text = brandsGridView.CurrentRow.Cells[0].Value.ToString();
                brandNameTextBox.Text = brandsGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //---------CRUD---------\\

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(brandNameTextBox.Text))
                {
                    if (BrandManagement.SelectBrandByName(brandNameTextBox.Text) == null)
                    {
                        if (BrandManagement.InsertBrand(brandNameTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "Marca agregada de manera exitosa.";
                            brandNameTextBox.Text = string.Empty;
                            idLabel.Text = "Seleccione una";
                            WireUpBrandsDataGridView();
                        } else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar la marca: { brandNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else
                    {
                        MetroMessageBox.Show(this, "Ya existe una marca con ese nombre.", "Marca repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la marca no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!idLabel.Text.Equals("Seleccione una"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la marca: { brandsGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (BrandManagement.UpdateBrandById(int.Parse(idLabel.Text), brandNameTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "Marca modificada de manera exitosa.";
                            brandNameTextBox.Text = string.Empty;
                            idLabel.Text = "Seleccione una";
                            WireUpBrandsDataGridView();
                        } else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la marca: { brandNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una marca para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!idLabel.Text.Equals("Seleccione una"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la marca: { brandNameTextBox.Text }?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (BrandManagement.DeleteBrandById(int.Parse(idLabel.Text)))
                        {
                            toolStripStatusLabel1.Text = "Marca eliminada de manera exitosa.";
                            brandNameTextBox.Text = string.Empty;
                            idLabel.Text = "Seleccione una";
                            WireUpBrandsDataGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la marca: { brandNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una marca para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
