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
using LogicLibrary;
using MetroFramework.Forms;
using MetroFramework;
using LogicLibrary.Management;

namespace UI.Forms
{
    public partial class FrmCategoriesAndSubCategories : MetroForm
    {
        //---------GLOBALS---------\\
        List<CategoryModel> categoryModels;
        List<SubCategoryModel> subCategoryModels;

        //---------FORM---------\\
        public FrmCategoriesAndSubCategories()
        {
            InitializeComponent();
        }

        private void FrmCategoriesAndSubCategories_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Área de Categorías y SubCategorías.";
            WireUpCategoriesDataGridView();
            WireUpSubCategoriesDataGridView();
            WireUpCategorieComboBox();
        }

        private void FrmCategoriesAndSubCategories_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------CATEGORY---------\\

        //---------CUSTOM METHODS---------\\

        private void WireUpCategoriesDataGridView()
        {
            categoryModels = CategoryManagement.SelectAllCategories();
            categoriesGridView.MultiSelect = false;
            categoriesGridView.DataSource = categoryModels;

            categoriesGridView.Columns["idCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            categoriesGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoriesGridView.Columns["idCategory"].HeaderText = "Id";
            categoriesGridView.Columns["Name"].HeaderText = "Nombre";
        }

        private void SearchCategories()
        {
            if (!string.IsNullOrEmpty(categorySearchTextBox.Text))
            {
                categoriesGridView.DataSource = CategoryManagement.SelectCategoriesByName(categorySearchTextBox.Text);
            }
            else
            {
                WireUpCategoriesDataGridView();
            }
        }

        //---------EVENTS---------\\

        private void categorySearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchCategories();
        }

        private void categorySearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchCategories();
        }

        private void categoriesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoriesGridView.SelectedRows[0] != null)
            {
                categoryIdLabel.Text = categoriesGridView.CurrentRow.Cells[0].Value.ToString();
                categoryNameTextBox.Text = categoriesGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //---------CRUD---------\\

        private void createCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(categoryNameTextBox.Text))
                {
                    if (CategoryManagement.SelectCategoryByName(categoryNameTextBox.Text) == null)
                    {
                        if (CategoryManagement.InsertCategory(categoryNameTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "Categoría agregada de manera exitosa.";
                            categoryNameTextBox.Text = string.Empty;
                            categoryIdLabel.Text = "Seleccione una";
                            WireUpCategoriesDataGridView();
                            WireUpCategorieComboBox();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ya existe una categoría con ese nombre.", "Categoría repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la categoría no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!categoryIdLabel.Text.Equals("Seleccione una"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la categoría: { categoriesGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (CategoryManagement.UpdateCategoryById(int.Parse(categoryIdLabel.Text), categoryNameTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "Categoría modificada de manera exitosa.";
                            categoryNameTextBox.Text = string.Empty;
                            categoryIdLabel.Text = "Seleccione una";
                            WireUpCategoriesDataGridView();
                            WireUpCategorieComboBox();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la categoría: { categoryNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una categoría para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!categoryIdLabel.Text.Equals("Seleccione una"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la categoría: { categoryNameTextBox.Text }?", "Eliminar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (CategoryManagement.DeleteCategoryById(int.Parse(categoryIdLabel.Text)))
                        {
                            toolStripStatusLabel1.Text = "Categoría eliminada de manera exitosa.";
                            categoryNameTextBox.Text = string.Empty;
                            categoryIdLabel.Text = "Seleccione una";
                            WireUpCategoriesDataGridView();
                            WireUpCategorieComboBox();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la categoría: { categoryNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una categoría para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        //---------SUBCATEGORY---------\\

        //---------CUSTOM METHODS---------\\

        private void WireUpCategorieComboBox()
        {
            categoriesComboBox.DataSource = categoryModels;
            categoriesComboBox.DisplayMember = "Name";
        }

        private void WireUpSubCategoriesDataGridView()
        {
            subCategoryModels = SubCategoryManagement.SelectAllSubCategories();
            subCategoriesGridView.MultiSelect = false;
            subCategoriesGridView.DataSource = subCategoryModels;

            subCategoriesGridView.Columns["idSubCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            subCategoriesGridView.Columns["idCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            subCategoriesGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subCategoriesGridView.Columns["idSubCategory"].HeaderText = "Id";
            subCategoriesGridView.Columns["idCategory"].HeaderText = "Id Categoría";
            subCategoriesGridView.Columns["Name"].HeaderText = "Nombre";
        }

        private void WireUpSubCategoriesDataGridView(List<SubCategoryModel> subCategoryModels)
        {
            subCategoriesGridView.MultiSelect = false;
            subCategoriesGridView.DataSource = subCategoryModels;

            subCategoriesGridView.Columns["idSubCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            subCategoriesGridView.Columns["idCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            subCategoriesGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subCategoriesGridView.Columns["idSubCategory"].HeaderText = "Id";
            subCategoriesGridView.Columns["idCategory"].HeaderText = "Id Categoría";
            subCategoriesGridView.Columns["Name"].HeaderText = "Nombre";
        }

        private void SearchSubCategories()
        {
            if (!string.IsNullOrEmpty(subCategorySearchTextBox.Text))
            {
                subCategoriesGridView.DataSource = SubCategoryManagement.SelectSubCategoriesByName(subCategorySearchTextBox.Text);
            }
            else
            {
                WireUpSubCategoriesDataGridView();
            }
        }

        //---------EVENTS---------\\

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryModel categoryModel = (CategoryModel)categoriesComboBox.SelectedItem;
            List<SubCategoryModel> subCategoryModels = SubCategoryManagement.SelectSubCategoriesByCategoryId(categoryModel.IdCategory);
            WireUpSubCategoriesDataGridView(subCategoryModels);
        }

        private void subCategorySearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchSubCategories();
        }

        private void subCategorySearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchSubCategories();
        }

        private void subCategoriesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subCategoriesGridView.SelectedRows[0] != null)
            {
                subCategoryIdLabel.Text = subCategoriesGridView.CurrentRow.Cells[0].Value.ToString();
                subCategoryNameTextBox.Text = subCategoriesGridView.CurrentRow.Cells[2].Value.ToString();
                foreach (CategoryModel categoryModel in categoriesComboBox.Items)
                {
                    if (categoryModel.Name.Equals(subCategoryNameTextBox.Text))
                    {
                        categoriesComboBox.SelectedItem = categoryModel;
                        break;
                    }
                }
            }
        }

        //---------CRUD---------\\
        private void createSubCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(subCategoryNameTextBox.Text))
                {
                    if (SubCategoryManagement.SelectSubCategoryByName(subCategoryNameTextBox.Text) == null)
                    {
                        CategoryModel categoryModel = (CategoryModel)categoriesComboBox.SelectedItem;
                        if (SubCategoryManagement.InsertSubCategory(categoryModel.IdCategory, subCategoryNameTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "SubCategoría agregada de manera exitosa.";
                            subCategoryNameTextBox.Text = string.Empty;
                            subCategoryIdLabel.Text = "Seleccione";
                            WireUpSubCategoriesDataGridView();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ya existe una subcategoría con ese nombre.", "subcategoría repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la subcategoría no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void updateSubCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!subCategoryIdLabel.Text.Equals("Seleccione"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la subcategoría: { subCategoryNameTextBox.Text }?", "Modificar subcategoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int idCat = ((CategoryModel)categoriesComboBox.SelectedItem).IdCategory;
                        if (SubCategoryManagement.UpdateSubCategoryById(int.Parse(categoryIdLabel.Text), idCat, subCategoryNameTextBox.Text))
                        {
                            toolStripStatusLabel1.Text = "SubCategoría modificada de manera exitosa.";
                            subCategoryNameTextBox.Text = string.Empty;
                            subCategoryIdLabel.Text = "Seleccione";
                            WireUpSubCategoriesDataGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la subcategoría: { subCategoryNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una subcategoría para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void deleteSubCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!subCategoryIdLabel.Text.Equals("Seleccione"))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la subcategoría: { subCategoryNameTextBox.Text }?", "Eliminar subcategoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (SubCategoryManagement.DeleteSubCategoryById(int.Parse(categoryIdLabel.Text)))
                        {
                            toolStripStatusLabel1.Text = "SubCategoría eliminada de manera exitosa.";
                            subCategoryNameTextBox.Text = string.Empty;
                            subCategoryIdLabel.Text = "Seleccione";
                            WireUpSubCategoriesDataGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la subcategoría: { subCategoryNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una subcategoría para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
