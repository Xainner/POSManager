using BusinessLibrary.Models;
using LogicLibrary.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class FrmExistingOffset : MetroFramework.Forms.MetroForm
    {
        //---------GLOBALS---------\\
        List<OffSetDetailsModel> offSetDetails;

        //---------FORM---------\\

        public FrmExistingOffset()
        {
            InitializeComponent();
        }

        private void FrmExistingOffset_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Área de Apartados Agregados.";
            WireUpOffsetDataGridView();
        }

        //---------CUSTOM METHODS---------\\
        private void WireUpOffsetDataGridView()
        {
            offsetGridView.DataSource = OffsetDetailsManagement.SelectAllOffsetDetails();
        }

        private void SearchBrands()
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                offsetGridView.DataSource = OffsetDetailsManagement.SelectOffsetDetailByInvoice(searchTextBox.Text);
            }
            else
            {
                WireUpOffsetDataGridView();
            }
        }

        private void offsetGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (offsetGridView.SelectedRows[0] != null)
                {
                    clientTextBox.Text = offsetGridView.CurrentRow.Cells[2].Value.ToString();
                    employeeTextBox.Text = offsetGridView.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
