﻿using BusinessLibrary.Models;
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
using UI.Utilities;

namespace UI.Forms
{
    public partial class FrmNewOffset : MetroFramework.Forms.MetroForm
    {
        //---------GLOBALS---------\\
        public static ClientModel ClientModel { get; set; }
        public static EmployeeModel EmployeeModel { get; set; }
        public decimal discounts = 0;

        public FrmNewOffset()
        {
            InitializeComponent();
        }

        private void FrmNewOffset_Load(object sender, EventArgs e)
        {
            WireUpProductsGridView();
            currentTimeTimer.Start();
            metroLabel14.Text = DateTime.Now.ToString();
            int id = OffsetDetailsManagement.SelectLastOffsetNumber();
            metroLabel4.Text = (id + 1).ToString();
            metroComboBox1.SelectedIndex = 0;
        }

        private void CleanNewOffset()
        {
            employeeTextBox.Text = " ";
            clientTextBox.Text = " ";
            codeTextBox.Text = " ";
            cashAmountTextBox.Text = " ";
            creditAmountTextBox.Text = " ";
            depositTextBox.Text = " ";
            discountTextBox.Text = " ";
            subTotalTextBox.Text = " ";
            taxesTextBox.Text = " ";
            totalTextBox.Text = " ";
           
            productsGridView.Rows.Clear();
        }

        private void CleanDeposit()
        {
            currentResidueTextbox.Text = " ";
            offsetCashTextbox.Text = " ";
            offsetCreditTextbox.Text = " ";
            newResidueTextBox.Text = " ";
            
        }

        private void WireUpProductsGridView()
        {
            productsGridView.Columns.Add("code", "Código");
            productsGridView.Columns.Add("description", "Descripción");
            productsGridView.Columns.Add("subcategory", "Sub-Categoría");
            productsGridView.Columns.Add("quantity", "Cantidad");
            productsGridView.Columns.Add("price", "Precio P/U");
            productsGridView.Columns.Add("paymentAmount", "Monto");
            productsGridView.Columns.Add("discount", "Descuento (%)");
            productsGridView.Columns.Add("taxType", "Tipo de Impuesto");
            productsGridView.Columns.Add("taxes", "I.V.I");
            productsGridView.Columns.Add("id", "Id");
            productsGridView.Columns.Add("discount2", "Descuento (#)");

            foreach (DataGridViewColumn dataGridViewColumn in productsGridView.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewColumn.ReadOnly = true;
            }

            foreach (DataGridViewColumn dataGridViewColumn in offsetGridView.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewColumn.ReadOnly = true;
            }

            productsGridView.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            productsGridView.Columns[3].ReadOnly = false;
            productsGridView.Columns[6].ReadOnly = false;

            productsGridView.Columns[9].Visible = false;
            productsGridView.Columns[10].Visible = true;

            productsGridView.MultiSelect = false;
        }

        private void FrmNewOffset_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------CUSTOM METHODS---------\\

        private bool SearchDuplicates(string productCode)
        {
            for (int i = 0; i < productsGridView.RowCount; i++)
            {
                string code = productsGridView.Rows[i].Cells[0].Value.ToString();
                decimal price = decimal.Parse(productsGridView.Rows[i].Cells[4].Value.ToString());
                if (productCode == code)
                {
                    int quantity = int.Parse(productsGridView.Rows[i].Cells[3].Value.ToString());
                    quantity++;
                    productsGridView.Rows[i].Cells[3].Value = quantity;
                    ModifyProductDetails();
                    return true;
                }
            }
            return false;
        }

        private void ModifyProductDetails(DataGridViewRow dataGridViewRow)
        {
            int quantity = int.Parse(dataGridViewRow.Cells[3].Value.ToString());
            decimal amount = quantity * decimal.Parse(dataGridViewRow.Cells[4].Value.ToString());
            decimal discount = int.Parse(dataGridViewRow.Cells[6].Value.ToString());

            decimal otrotest2 = amount * (discount / 100);
            amount = (amount - (amount * (discount / 100)));

            discounts -= decimal.Parse(dataGridViewRow.Cells[10].Value.ToString());

            if (discounts == 0)
            {
                discountTextBox.Text = "0";
            }

            if (decimal.Parse(discountTextBox.Text) != 0)
            {
                dataGridViewRow.Cells[10].Value = otrotest2;
                discounts += otrotest2;
                discountTextBox.Text = discounts.ToString("#.##");
            }
            else
            {
                dataGridViewRow.Cells[10].Value = otrotest2;
                discounts += otrotest2;
                decimal otroTest = decimal.Parse(dataGridViewRow.Cells[10].Value.ToString());
                discountTextBox.Text = discounts.ToString("#.##");
                if (discounts == 0)
                {
                    discountTextBox.Text = "0";
                }
            }

            string tax;
            if (dataGridViewRow.Cells[7].Value.ToString().Equals("G"))
            {
                tax = "0.13";
            }
            else
            {
                tax = "0";
            }

            decimal subTotal = amount - (decimal.Parse(tax) * amount);

            decimal taxes = amount - subTotal;
            dataGridViewRow.Cells[5].Value = amount.ToString("#.##");
            dataGridViewRow.Cells[8].Value = taxes.ToString("#.##");

            CalculateInvoiceDetails();
        }

        private void ModifyProductDetails()
        {
            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                int quantity = int.Parse(dataGridViewRow.Cells[3].Value.ToString());
                decimal amount = quantity * decimal.Parse(dataGridViewRow.Cells[4].Value.ToString());
                decimal discount = int.Parse(dataGridViewRow.Cells[6].Value.ToString());

                amount = (amount - (amount * (discount / 100)));

                string tax = "0.13";
                decimal subTotal = amount - (decimal.Parse(tax) * amount);

                decimal taxes = amount - subTotal;
                dataGridViewRow.Cells[5].Value = amount.ToString("#.##");
                dataGridViewRow.Cells[8].Value = taxes.ToString("#.##");
            }
        }

        private void CalculateInvoiceDetails()
        {
            decimal amount = 0;
            decimal taxes = 0;

            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                if (dataGridViewRow.Cells[5].Value.ToString() != "")
                {
                    amount += decimal.Parse(dataGridViewRow.Cells[5].Value.ToString());
                    if (dataGridViewRow.Cells[7].Value.ToString().Equals("G"))
                    {
                        taxes += decimal.Parse(dataGridViewRow.Cells[8].Value.ToString());
                    }
                }
                else
                {
                    amount = 0;
                    taxes = 0;
                }

            }

            decimal subTotal = amount - taxes;
            decimal total = amount;

            if (subTotal != 0)
            {
                subTotalTextBox.Text = subTotal.ToString("#.##");

            }
            else
            {
                subTotalTextBox.Text = "0";
            }
            if (taxes != 0)
            {
                taxesTextBox.Text = taxes.ToString("#.##");

            }
            else
            {
                subTotalTextBox.Text = "0";
            }
            if (total != 0)
            {
                totalTextBox.Text = total.ToString("#.##");
            }
            else
            {
                subTotalTextBox.Text = "0";
            }
        }

        private void ValidateTaxes()
        {
            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                if (dataGridViewRow.Cells[7].Value.ToString().Equals("E"))
                {
                    dataGridViewRow.Cells[8].Value = 0;
                }
            }
        }

        private void ValidateChange()
        {
            decimal cashAmount = decimal.Parse(cashAmountTextBox.Text);
            decimal totalPayment = decimal.Parse(totalTextBox.Text);
            decimal residue = totalPayment - cashAmount;

            if (residue >= 0 && cashAmount <= totalPayment)
            {
                depositTextBox.Text = residue.ToString("#.##");
            }
            else
            {
                cashAmountTextBox.Text = "";
                depositTextBox.Text = "";
                MetroMessageBox.Show(this, "Debe ingresar un monto valido.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (residue == 0)
            {
                depositTextBox.Text = "0";
            }
        }

        private void ValidateChangeCredit()
        {
            decimal creditAmount = decimal.Parse(creditAmountTextBox.Text);
            decimal totalPayment = decimal.Parse(totalTextBox.Text);
            decimal residue = totalPayment - creditAmount;

            if (residue >= 0 && creditAmount <= totalPayment)
            {
                depositTextBox.Text = residue.ToString("#.##");
            }
            else
            {
                cashAmountTextBox.Text = "";
                depositTextBox.Text = "";
                MetroMessageBox.Show(this, "Debe ingresar un monto valido.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (residue == 0)
            {
                depositTextBox.Text = "0";
            }
        }

        private void ValidateChangeOffset()
        {
            decimal cashAmount = decimal.Parse(offsetCashTextbox.Text);
            decimal deposit = decimal.Parse(currentResidueTextbox.Text);
            decimal residue = deposit - cashAmount;

            if (residue >= 0 && cashAmount <= deposit)
            {
                newResidueTextBox.Text = residue.ToString("#.##");
            }
            else
            {
                offsetCashTextbox.Text = "";
                newResidueTextBox.Text = "";
                MetroMessageBox.Show(this, "Debe ingresar un monto valido.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (residue == 0)
            {
                newResidueTextBox.Text = "0";
            }
        }

        private void ValidateChangeOffsetCredit()
        {
            decimal creditAmount = decimal.Parse(offsetCreditTextbox.Text);
            decimal deposit = decimal.Parse(currentResidueTextbox.Text);
            decimal residue = deposit - creditAmount;

            if (residue >= 0 && creditAmount <= deposit)
            {
                newResidueTextBox.Text = residue.ToString("#.##");
            }
            else
            {
                offsetCashTextbox.Text = "";
                newResidueTextBox.Text = "";
                MetroMessageBox.Show(this, "Debe ingresar un monto valido.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (residue == 0)
            {
                newResidueTextBox.Text = "0";
            }
        }

        private void reloadLatestInvoiceNumber_Tick(object sender, EventArgs e)
        {
            int id = OffsetDetailsManagement.SelectLastOffsetNumber();
            metroLabel4.Text = (id + 1).ToString();
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            metroLabel14.Text = DateTime.Now.ToString();
        }

        private void cashAmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            creditAmountTextBox.Text = "";

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ValidateChange();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void creditAmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            cashAmountTextBox.Text = "";

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ValidateChangeCredit();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void offsetCashTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            offsetCreditTextbox.Text = "";

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ValidateChangeOffset();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void offsetCreditTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            offsetCashTextbox.Text = "";

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ValidateChangeOffsetCredit();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cashAmountTextBox.Text))
                {
                    ValidateChange();
                }

                if (!string.IsNullOrEmpty(creditAmountTextBox.Text))
                {
                    ValidateChangeCredit();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void employeeTextBox_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (CustomDialogs.SearchEmployee(1) == DialogResult.OK)
                {
                    employeeTextBox.Text = $" { EmployeeModel.Name } { EmployeeModel.Lastname}";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void clientTextBox_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (CustomDialogs.SearchClient(1) == DialogResult.OK)
                {
                    clientTextBox.Text = $" { ClientModel.Name } { ClientModel.Lastname}";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void productsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ModifyProductDetails(productsGridView.CurrentRow);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProductModel productModel = ProductManagement.SelectProductByCode(codeTextBox.Text);

                    string code = productModel.Code;
                    string description = productModel.Description;

                    //string subCategory = (SubCategoryManagement.SelectSubCategoryById(productModel.idsubCategory).Name);
                    string subCategory = "Temporal";

                    if (!SearchDuplicates(code))
                    {
                        int quantity = 1;
                        decimal price = productModel.normalPrice;
                        decimal paymentAmount = price;
                        decimal discount = 0;
                        decimal taxes = 0;
                        char taxType = 'G';
                        if (productModel.Ivi)
                        {
                            taxType = 'E';
                        }
                        productsGridView.Rows.Add(code, description, subCategory, quantity, price, paymentAmount, discount, taxType, taxes, productModel.idProduct, 0);
                    }

                    ModifyProductDetails();
                    CalculateInvoiceDetails();
                    ValidateTaxes();
                    
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
                MetroMessageBox.Show(this, "No se encontro el codigo ingresado", "Codigo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //---------CRUD---------\\

        private void addOffsetTile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(depositTextBox.Text) && !string.IsNullOrEmpty(employeeTextBox.Text)
                    && !string.IsNullOrEmpty(clientTextBox.Text) && !string.IsNullOrEmpty(totalTextBox.Text))
                {
                    decimal discount = decimal.Parse(discountTextBox.Text);
                    decimal taxes = decimal.Parse(taxesTextBox.Text);
                    decimal subTotal = decimal.Parse(subTotalTextBox.Text);
                    decimal total = decimal.Parse(totalTextBox.Text);
                    decimal cashAmount = 0;
                    decimal cardAmount = 0;
                    string currencyType = metroComboBox1.SelectedItem.ToString();
                    decimal totalPayment = decimal.Parse(totalTextBox.Text);
                    int employeeId = EmployeeModel.IdEmployee;
                    string client = clientTextBox.Text;
                    int mainBusinessId = BusinessManagement.SelectMainBusinessId();
                    string endDate = endDateTime.Text;
                    decimal deposit = decimal.Parse(depositTextBox.Text);

                    if (cashAmountTextBox.Text != "")
                    {
                        cashAmount = decimal.Parse(cashAmountTextBox.Text);
                    }

                    if (creditAmountTextBox.Text != "")
                    {
                        cardAmount = decimal.Parse(creditAmountTextBox.Text);
                    }

                    List<int> productsIds = new List<int>();
                    List<int> quantities = new List<int>();

                    foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                    {
                        productsIds.Add(int.Parse(dataGridViewRow.Cells[9].Value.ToString()));
                        quantities.Add(int.Parse(dataGridViewRow.Cells[3].Value.ToString()));
                    }

                    OffsetDetailsManagement.InsertOffsetInvoiceDetails(client, employeeId, mainBusinessId, endDate, currencyType,
                        cashAmount, cardAmount, discount, subTotal, total, taxes, deposit, productsIds, quantities);

                    toolStripStatusLabel1.Text = "El Apartado ha sido agregado correctamente.";
                    CleanNewOffset();
                }
                else
                {
                    MetroMessageBox.Show(this, "Se encontraron campos vacios", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(searchTextBox.Text))
                {
                    List<DepositXOffsetModel> depositModel;
                    depositModel = OffsetDetailsManagement.MultipleValueSearch(searchTextBox.Text);

                    if (depositModel != null)
                    {
                        offsetGridView.DataSource = depositModel;
                        offsetGridView.Columns.RemoveAt(2);
                        offsetGridView.Columns[0].HeaderText = "Num Fact.";
                        offsetGridView.Columns[1].HeaderText = "Nombre";
                        offsetGridView.Columns[2].HeaderText = "Saldo Actual";
                    }
                }
                else
                {
                    offsetGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void offsetGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (offsetGridView.SelectedRows[0] != null)
                {
                    currentResidueTextbox.Text = offsetGridView.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (offsetCashTextbox.Text != "" && !string.IsNullOrEmpty(currentResidueTextbox.Text))
                {
                    ValidateChangeOffset();
                }

                if (offsetCreditTextbox.Text != "" && !string.IsNullOrEmpty(currentResidueTextbox.Text))
                {
                    ValidateChangeOffsetCredit();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void addDepositTile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!currentResidueTextbox.Text.Equals("0,00"))
                {
                    if (!string.IsNullOrEmpty(newResidueTextBox.Text) && !string.IsNullOrEmpty(currentResidueTextbox.Text))
                    {
                        string id = offsetGridView.CurrentRow.Cells[0].Value.ToString();
                        string name = offsetGridView.CurrentRow.Cells[1].Value.ToString();
                        decimal deposit = decimal.Parse(newResidueTextBox.Text);

                        if (OffsetDetailsManagement.InsertOffsetDeposit(id, name, deposit))
                        {
                            toolStripStatusLabel1.Text = "El deposito ha sido agregado correctamente.";
                            CleanDeposit();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Se encontraron campos vacios", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El apartado ya ha sido completado", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }
    }
}
