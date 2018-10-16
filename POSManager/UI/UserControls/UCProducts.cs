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
using LogicLibrary;
using UI.Utilities;
using MetroFramework;

namespace UI.UserControls
{
    public partial class UCProducts : MetroUserControl
    {
        string tempImage;

        List<CategoryModel> categoryModels;
        List<SubCategoryModel> subCategoryModels;
        List<ProductModel> productModels;

        public UCProducts()
        {
            InitializeComponent();
        }

        public void CleanProduct()
        {
            codeTextBox.Text = "";
            StyleTextBox.Text = "";
            brandComboBox.Text = "";
            descriptionTextBox.Text = "";
            categoryComboBox.Text = "";
            subCategoryComboBox.Text = "";
            estableQuantityTextBox.Text = "";
            variableQuantityTextBox.Text = "";
            priceTextBox.Text = "";
            lowerPorcentTextBox.Text = "";
            ImgpictureBox.Image = Properties.Resources.Empty;
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            categoryModels = CategoryManagement.SelectAllCategories();
            subCategoryModels = SubCategoryManagement.SelectAllSubCategories();


            productmetroGrid.DataSource = ProductManagement.SelectAllProducts();
            brandComboBox.DataSource = BrandManagement.SelectAllBrands();
            brandComboBox.DisplayMember = "Name";

            WireUpCategoryComboBox();
            WireUpSubCategoryComboBox();
            WireUpProdcutGridView();
        }

        private void WireUpProdcutGridView()
        {
            productModels = ProductManagement.SelectAllProducts();
            productmetroGrid.MultiSelect = false;
            productmetroGrid.DataSource = productModels;

            productmetroGrid.Columns["idProduct"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["Style"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["idBrand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["idsubCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["normalPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["lowerPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["estableQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["variableQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["Ivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productmetroGrid.Columns["existingInvoice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            productmetroGrid.Columns["idProduct"].HeaderText = "Id";
            productmetroGrid.Columns["Code"].HeaderText = "Código";
            productmetroGrid.Columns["Style"].HeaderText = "Estilo";
            productmetroGrid.Columns["idBrand"].HeaderText = "Marca";
            productmetroGrid.Columns["idsubCategory"].HeaderText = "SubCategoría";
            productmetroGrid.Columns["Description"].HeaderText = "Descripción";
            productmetroGrid.Columns["normalPrice"].HeaderText = "Precio";
            productmetroGrid.Columns["lowerPrice"].HeaderText = "Porcentaje Desc";
            productmetroGrid.Columns["estableQuantity"].HeaderText = "Cantidad Fija";
            productmetroGrid.Columns["variableQuantity"].HeaderText = "Cantidad Entrada";
            productmetroGrid.Columns["Image"].HeaderText = "Image";
            productmetroGrid.Columns["Ivi"].HeaderText = "Impuesto";
            productmetroGrid.Columns["existingInvoice"].HeaderText = "Fact Existente";

            productmetroGrid.Columns.RemoveAt(12);
        }

        private void WireUpCategoryComboBox()
        {
            categoryComboBox.DataSource = categoryModels;
            categoryComboBox.DisplayMember = "Name";
        }

        private void WireUpSubCategoryComboBox()
        {
            subCategoryComboBox.DataSource = subCategoryModels;
            subCategoryComboBox.DisplayMember = "Name";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BrandModel brand = (BrandModel)brandComboBox.SelectedItem;
            SubCategoryModel subcategory = (SubCategoryModel)subCategoryComboBox.SelectedItem;
            bool taxes = true;

            if (exentoCheckBox.Checked)
            {
                taxes = false;
            }

            try
            {
                if (!string.IsNullOrEmpty(codeTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(descriptionTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(estableQuantityTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(variableQuantityTextBox.Text))
                            {
                                if (!string.IsNullOrEmpty(priceTextBox.Text))
                                {
                                    if (ProductManagement.InsertProduct(codeTextBox.Text, StyleTextBox.Text, brand.IdBrand.ToString(), descriptionTextBox.Text, subcategory.IdSubCategory.ToString(), 
                                        priceTextBox.Text, lowerPorcentTextBox.Text, estableQuantityTextBox.Text, variableQuantityTextBox.Text, 
                                        ImageManagement.ImageToByte(ImageManagement.TemporaryImage(ImgpictureBox.Image)), taxes, true))
                                    {
                                        FrmMain.Instance.ToolStripLabel.Text = "Producto agregado de manera exitosa.";
                                        CleanProduct();
                                        WireUpProdcutGridView();
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar el producto. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El precio no puede ser vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La cantidad de entrada no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "La cantidad fija no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La descripción no puede ser vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El Código no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string id = productmetroGrid.CurrentRow.Cells[0].Value.ToString();
                BrandModel brand = (BrandModel)brandComboBox.SelectedItem;
                SubCategoryModel subcategory = (SubCategoryModel)subCategoryComboBox.SelectedItem;
                bool taxes = true;

                if (exentoCheckBox.Checked)
                {
                    taxes = false;
                }

                try
                {
                    if (!string.IsNullOrEmpty(codeTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(descriptionTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(estableQuantityTextBox.Text))
                            {
                                if (!string.IsNullOrEmpty(variableQuantityTextBox.Text))
                                {
                                    if (!string.IsNullOrEmpty(priceTextBox.Text))
                                    {
                                        if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar el Producto?", "Modificar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                        {
                                            if (ProductManagement.UpdateProductById(id, codeTextBox.Text, StyleTextBox.Text, brand.IdBrand.ToString(), descriptionTextBox.Text, subcategory.IdSubCategory.ToString(),
                                                priceTextBox.Text, lowerPorcentTextBox.Text, estableQuantityTextBox.Text, variableQuantityTextBox.Text,
                                                ImageManagement.ImageToByte(ImageManagement.TemporaryImage(ImgpictureBox.Image)), taxes, true))
                                            {
                                                FrmMain.Instance.ToolStripLabel.Text = "Producto modificado de manera exitosa.";
                                                CleanProduct();
                                                WireUpProdcutGridView();
                                            }
                                            else
                                            {
                                                MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, "El precio no puede ser vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "La cantidad de entrada no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La cantidad fija no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "La descripción no puede ser vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El Código no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = productmetroGrid.CurrentRow.Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(codeTextBox.Text) && !string.IsNullOrEmpty(lowerPorcentTextBox.Text))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar el Producto?", "Eliminar Prodcuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (ProductManagement.DeleteProductById(id))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Negocio eliminado de manera exitosa.";
                            WireUpProdcutGridView();
                            CleanProduct();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una negocio para poder eliminarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                FrmMain.Instance.ToolStripLabel.Text = ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                CleanProduct();
            }
            catch (Exception ex)
            {

                FrmMain.Instance.ToolStripLabel.Text = ex.Message;
            }
        }

        private void photoButton_Click(object sender, EventArgs e)
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
                    ImgpictureBox.Load(tempImage);
                }
            }
        }

        private void rotateLeftLink_Click(object sender, EventArgs e)
        {
            RotateFlipType rp = RotateFlipType.Rotate90FlipXY;
            Image image = ImgpictureBox.Image;
            image.RotateFlip(rp);
            ImgpictureBox.Image = image;
        }

        private void rotateRightLink_Click(object sender, EventArgs e)
        {
            RotateFlipType rp = RotateFlipType.Rotate90FlipNone;
            Image image = ImgpictureBox.Image;
            image.RotateFlip(rp);
            ImgpictureBox.Image = image;
        }

        private void lowerDiscountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(priceTextBox.Text) && !string.IsNullOrEmpty(lowerDiscountTextBox.Text))
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        decimal lowerQuantity = decimal.Parse(lowerDiscountTextBox.Text);
                        decimal price = decimal.Parse(priceTextBox.Text);

                        decimal result = (lowerQuantity * 100) / price;

                        decimal total = 100 - result;

                        lowerPorcentTextBox.Text = total.ToString();
                    }
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "El precio y descuento minimo no pueden ser vacios.";
                }
            }
            catch (Exception ex)
            {

                FrmMain.Instance.ToolStripLabel.Text = ex.Message;
            }
        }

        private void productmetroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (productmetroGrid.SelectedRows[0] != null)
                {
                    ProductModel productModel = ProductManagement.SelectProductByCode(productmetroGrid.CurrentRow.Cells[1].Value.ToString());

                    codeTextBox.Text = productModel.Code;
                    StyleTextBox.Text = productModel.Style;
                    descriptionTextBox.Text = productModel.Description;
                    priceTextBox.Text = productModel.normalPrice.ToString();
                    lowerPorcentTextBox.Text = productModel.lowerPrice.ToString();
                    estableQuantityTextBox.Text = productModel.estableQuantity.ToString();
                    variableQuantityTextBox.Text = productModel.variableQuantity.ToString();

                    foreach (BrandModel item in brandComboBox.Items)
                    {
                        int idBrand = productModel.idBrand;
                        if (item.IdBrand == idBrand)
                        {
                            brandComboBox.SelectedItem = item;
                        }
                    }

                    foreach (SubCategoryModel item in subCategoryComboBox.Items)
                    {
                        int idSubCat = productModel.idsubCategory;

                        if (item.IdSubCategory == idSubCat)
                        {
                            subCategoryComboBox.SelectedItem = item;

                            foreach (CategoryModel item2 in categoryComboBox.Items)
                            {
                                if (item2.IdCategory == item.IdCategory)
                                {
                                    categoryComboBox.SelectedItem = item2;
                                }
                            }
                        }
                    }

                    ImgpictureBox.Image = ImageManagement.ByteToImage(productModel.Image);

                    if (productModel.Ivi)
                    {
                        gravadoCheckBox.Select();
                    }
                    else
                    {
                        exentoCheckBox.Select();
                    }
                }
            }
            catch (Exception ex)
            {

                FrmMain.Instance.ToolStripLabel.Text = ex.Message;
            }
        }
    }
}
