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
using MetroFramework;
using LogicLibrary.Management;
using UI.Utilities;

namespace UI.UserControls
{
    public partial class UCBusiness : MetroUserControl
    {
        //---------GLOBALS---------\\
        List<BusinessModel> businessModels;
        string tempImage;

        //---------FORM---------\\

        public UCBusiness()
        {
            InitializeComponent();
        }

        private void UCBusiness_Load(object sender, EventArgs e)
        {
            FrmMain.Instance.ToolStripLabel.Text = "Área de negocios.";
            WireUpBusinessGridView();
        }

        private void UCBusiness_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------CUSTOM METHODS---------\\

        private void WireUpBusinessGridView()
        {
            businessModels = BusinessManagement.SelectAllBusiness();
            businessGridView.MultiSelect = false;
            businessGridView.DataSource = businessModels;

            businessGridView.Columns["IdBusiness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["FantasyName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["societyName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["legalCertification"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["Telephone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["webPage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            businessGridView.Columns["Main"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            businessGridView.Columns["IdBusiness"].HeaderText = "Id";
            businessGridView.Columns["FantasyName"].HeaderText = "Nombre de Fantasía";
            businessGridView.Columns["societyName"].HeaderText = "Nombre de Sociedad";
            businessGridView.Columns["legalCertification"].HeaderText = "Centificación Legal";
            businessGridView.Columns["Telephone"].HeaderText = "Número de Teléfono";
            businessGridView.Columns["Email"].HeaderText = "Dirección Electrónica";
            businessGridView.Columns["webPage"].HeaderText = "Página Web";
            businessGridView.Columns["Main"].HeaderText = "Tienda Principal";

            businessGridView.Columns.RemoveAt(5);
            businessGridView.Columns.RemoveAt(6);
        }

        private void Clear()
        {
            businessIdLabel.Text = "Vacío";
            businessIdLabel.Text = string.Empty;
            fantasyNameTextBox.Text = string.Empty;
            societyNameTextBox.Text = string.Empty;
            juridicIdTextBox.Text = string.Empty;
            exactDirectionTextBox.Text = string.Empty;
            webPageTextBox.Text = string.Empty;
            telephoneTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            generalDirectionTextBox.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void SearchBusiness()
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                businessGridView.DataSource = BusinessManagement.SelectBusinessesByName(searchTextBox.Text);
            }
            else
            {
                WireUpBusinessGridView();
            }
        }

        //---------EVENTS---------\\

        private void searchTextBox_ButtonClick(object sender, EventArgs e)
        {
            SearchBusiness();
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchBusiness();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

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

        private void rotateLeftLink_Click(object sender, EventArgs e)
        {
            RotateFlipType rp = RotateFlipType.Rotate90FlipXY;
            Image image = pictureBox1.Image;
            image.RotateFlip(rp);
            pictureBox1.Image = image;
        }

        private void rotateRightLink_Click(object sender, EventArgs e)
        {
            RotateFlipType rp = RotateFlipType.Rotate90FlipNone;
            Image image = pictureBox1.Image;
            image.RotateFlip(rp);
            pictureBox1.Image = image;
        }

        private void businessGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (businessGridView.SelectedRows[0] != null)
            {
                BusinessModel businessModel = BusinessManagement.SelectBusinessById(int.Parse(businessGridView.CurrentRow.Cells[0].Value.ToString()));
                businessIdLabel.Text = businessModel.IdBusiness.ToString();
                fantasyNameTextBox.Text = businessModel.FantasyName;
                societyNameTextBox.Text = businessModel.SocietyName;
                juridicIdTextBox.Text = businessModel.LegalCertification;
                exactDirectionTextBox.Text = businessModel.MainAddress;
                webPageTextBox.Text = businessModel.WebPage;
                telephoneTextBox.Text = businessModel.Telephone;
                emailTextBox.Text = businessModel.Email;
                generalDirectionTextBox.Text = businessModel.GeneralAddress;
                pictureBox1.Image = ImageManagement.ByteToImage(businessModel.Logo);
            }
        }
        //---------CRUD---------\\

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!businessIdLabel.Text.Equals("Vacío"))
                {
                    if (!string.IsNullOrEmpty(fantasyNameTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(telephoneTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(exactDirectionTextBox.Text))
                            {
                                if (pictureBox1.Image != null)
                                {
                                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar el negocio: { fantasyNameTextBox.Text }?", "Modificar negocio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        if (BusinessManagement.UpdateBusinessById(int.Parse(businessIdLabel.Text), fantasyNameTextBox.Text, telephoneTextBox.Text, exactDirectionTextBox.Text, generalDirectionTextBox.Text, emailTextBox.Text, webPageTextBox.Text, ImageManagement.ImageToByte(ImageManagement.TemporaryImage(pictureBox1.Image))))
                                        {
                                            FrmMain.Instance.ToolStripLabel.Text = "Negocio modificado de manera exitosa.";
                                            Clear();
                                            businessIdLabel.Text = "Vacío";
                                            WireUpBusinessGridView();
                                        }
                                        else
                                        {
                                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar el negocio: { fantasyNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El logo del negocio no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La dirección exacta no puede estár vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El número de teléfono no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else
                    {
                        MetroMessageBox.Show(this, "El nombre de fantasía no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una negocio para poder modificarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
