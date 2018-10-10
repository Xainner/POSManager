using BusinessLibrary.Models;
using LogicLibrary.Management;
using MetroFramework;
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
            offsetGridView.DataSource = OffsetDetailsManagement.SelectAllOffsetDeposit();
        }

        private void SearchDeposits()
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

        private void ValidateChange()
        {
            decimal cashAmount = decimal.Parse(cashAmountTextBox.Text);
            decimal deposit = decimal.Parse(depositTextBox.Text);
            decimal residue = cashAmount - deposit;

            if (residue != 0)
            {
                residue = Math.Abs(residue);
                newResidueTextBox.Text = residue.ToString("#,##");
            }
            else
            {
                depositTextBox.Text = "0";
            }
        }

        private void offsetGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (offsetGridView.SelectedRows[0] != null)
                {
                    depositTextBox.Text = offsetGridView.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cashAmountTextBox.Text) && !string.IsNullOrEmpty(depositTextBox.Text))
                {
                    ValidateChange();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void addDepositTile_Click(object sender, EventArgs e)
        {
            string id = offsetGridView.CurrentRow.Cells[0].Value.ToString();
            string name = offsetGridView.CurrentRow.Cells[1].Value.ToString();
            decimal deposit = decimal.Parse(newResidueTextBox.Text);

            try
            {
                if (OffsetDetailsManagement.InsertOffsetDeposit(id, name, deposit))
                {
                    MetroMessageBox.Show(this, "Ingresado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchDeposits();
        }
    }
}
