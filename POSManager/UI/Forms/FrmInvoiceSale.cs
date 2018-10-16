using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLibrary.Models;
using LogicLibrary.Management;
using MetroFramework.Forms;
using UI.Utilities;
using MetroFramework;

namespace UI.Forms
{
    public partial class FrmInvoiceSale : MetroForm
    {
        //---------GLOBALS---------\\
        public static ClientModel ClientModel { get; set; }
        public static EmployeeModel EmployeeModel { get; set; }
        public decimal discounts = 0;
        

        //---------FORM---------\\

        public FrmInvoiceSale()
        {
            InitializeComponent();
        }

        private void FrmInvoiceSale_Load(object sender, EventArgs e)
        {
            WireUpProductsGridView();
            currentTimeTimer.Start();
            metroLabel14.Text = DateTime.Now.ToString();
            int id = ExternalInvoiceSaleManagement.SelectLastInvoiceNumber();
            metroLabel4.Text = (id + 1).ToString();
            metroComboBox1.SelectedIndex = 0;
            toolStripStatusLabel1.Text = "Área de facturación.";
        }

        private void FrmInvoiceSale_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
               
        //---------CUSTOM METHODS---------\\

        private bool SearchDuplicates(string code)
        {
            try
            {
                foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                {
                    if (code.Equals(dataGridViewRow.Cells[0].Value.ToString()))
                    {
                        int quantity = int.Parse(dataGridViewRow.Cells[3].Value.ToString());
                        dataGridViewRow.Cells[3].Value = (quantity + 1);

                        ModifyProductDetails(dataGridViewRow);

                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
                return false;
            }
        }

        private void ModifyProductDetails(DataGridViewRow dataGridViewRow)
        {
            try
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
                    discountTextBox.Text = discounts.ToString("#,##");
                }
                else
                {
                    dataGridViewRow.Cells[10].Value = otrotest2;
                    discounts += otrotest2;
                    decimal otroTest = decimal.Parse(dataGridViewRow.Cells[10].Value.ToString());
                    discountTextBox.Text = discounts.ToString("#,##");
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
                dataGridViewRow.Cells[5].Value = amount.ToString("#,##");
                dataGridViewRow.Cells[8].Value = taxes.ToString("#,##");

                CalculateInvoiceDetails();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void ModifyProductDetails()
        {
            try
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
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void WireUpProductsGridView()
        {
            try
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

                productsGridView.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                productsGridView.Columns[3].ReadOnly = false;
                productsGridView.Columns[6].ReadOnly = false;

                productsGridView.Columns[9].Visible = false;
                productsGridView.Columns[10].Visible = false;

                productsGridView.MultiSelect = false;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void CalculateInvoiceDetails()
        {
            try
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
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void ValidateTaxes()
        {
            try
            {
                foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                {
                    if (dataGridViewRow.Cells[7].Value.ToString().Equals("E"))
                    {
                        dataGridViewRow.Cells[8].Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void ValidateChange()
        {
            try
            {
                decimal cashAmount = decimal.Parse(cashAmountTextBox.Text);
                decimal totalPayment = decimal.Parse(totalTextBox.Text);
                decimal change = cashAmount - totalPayment;
                if (change >= 0)
                {
                    if (change != 0)
                    {
                        changeTextBox.Text = change.ToString("#.##");
                    }
                    else
                    {
                        changeTextBox.Text = "0";
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe ingresar un monto valido.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        //---------EVENTS---------\\

        private void reloadLatestInvoiceNumber_Tick(object sender, EventArgs e)
        {
            try
            {
                int id = ExternalInvoiceSaleManagement.SelectLastInvoiceNumber();
                metroLabel4.Text = (id + 1).ToString();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                metroLabel14.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void cashAmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
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

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cashAmountTextBox.Text) && !string.IsNullOrEmpty(totalTextBox.Text))
                {
                    ValidateChange();
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe ingresar un monto valido.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (CustomDialogs.SearchEmployee(0) == DialogResult.OK)
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
                if (CustomDialogs.SearchClient(0) == DialogResult.OK)
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
                if (!productsGridView.CurrentRow.Cells[0].Value.ToString().Equals("100"))
                {
                    ModifyProductDetails(productsGridView.CurrentRow);
                }
                else
                {
                    MetroMessageBox.Show(this, "No se permite un descuento del 100%.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                    codeTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        //---------CRUD---------\\
        private void generateSaleInvoiceTile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cashAmountTextBox.Text) || !string.IsNullOrEmpty(creditAmountTextBox.Text))
                {
                    decimal discount = decimal.Parse(discountTextBox.Text);
                    decimal taxes = decimal.Parse(taxesTextBox.Text);
                    decimal subTotal = decimal.Parse(subTotalTextBox.Text);
                    decimal total = decimal.Parse(totalTextBox.Text);
                    decimal cashAmount = decimal.Parse(cashAmountTextBox.Text);
                    decimal cardAmount = 0;
                    string currencyType = metroComboBox1.SelectedItem.ToString();
                    decimal totalPayment = decimal.Parse(totalTextBox.Text);
                    int employeeId = EmployeeModel.IdEmployee;
                    int clientId = 0;
                    int mainBusinessId = BusinessManagement.SelectMainBusinessId();
                    if (ClientModel != null)
                    {
                        clientId = ClientModel.IdClient;
                    }
                    List<int> productsIds = new List<int>();
                    foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                    {
                        productsIds.Add(int.Parse(dataGridViewRow.Cells[9].Value.ToString()));
                    }

                    List<int> productquantity = new List<int>();
                    foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                    {
                        productquantity.Add(int.Parse(dataGridViewRow.Cells[3].Value.ToString()));
                    }

                    List<decimal> productAmounts = new List<decimal>();
                    foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                    {
                        productAmounts.Add(decimal.Parse(dataGridViewRow.Cells[5].Value.ToString()));
                    }

                    List<decimal> productPrices = new List<decimal>();
                    foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                    {
                        productPrices.Add(decimal.Parse(dataGridViewRow.Cells[4].Value.ToString()));
                    }

                    List<decimal> productsDiscounts = new List<decimal>();
                    foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                    {
                        productsDiscounts.Add(decimal.Parse(dataGridViewRow.Cells[6].Value.ToString()));
                    }
                    ExternalInvoiceSaleManagement.InsertExternalInvoiceSaleDetails(discount, taxes, subTotal, total, cashAmount, cardAmount, currencyType, mainBusinessId, clientId, employeeId, productsIds, productquantity, productPrices, productAmounts, productsDiscounts);
                    clearButton.PerformClick();
                    toolStripStatusLabel1.Text = "Factura realizada con éxito";
                } else
                {
                    MetroMessageBox.Show(this, "Debe ingresar un monto.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productsGridView.Rows.Clear();
            codeTextBox.Text = string.Empty;
            clientTextBox.Text = string.Empty;
            employeeTextBox.Text = string.Empty;
            changeTextBox.Text = string.Empty;
            cashAmountTextBox.Text = string.Empty;
            creditAmountTextBox.Text = string.Empty;
        }

        private void FrmInvoiceSale_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                try
                {
                    if (!string.IsNullOrEmpty(cashAmountTextBox.Text) || !string.IsNullOrEmpty(creditAmountTextBox.Text))
                    {
                        decimal discount = decimal.Parse(discountTextBox.Text);
                        decimal taxes = decimal.Parse(taxesTextBox.Text);
                        decimal subTotal = decimal.Parse(subTotalTextBox.Text);
                        decimal total = decimal.Parse(totalTextBox.Text);
                        decimal cashAmount = decimal.Parse(cashAmountTextBox.Text);
                        decimal cardAmount = 0;
                        string currencyType = metroComboBox1.SelectedItem.ToString();
                        decimal totalPayment = decimal.Parse(totalTextBox.Text);
                        int employeeId = EmployeeModel.IdEmployee;
                        int clientId = 0;
                        int mainBusinessId = BusinessManagement.SelectMainBusinessId();
                        if (ClientModel != null)
                        {
                            clientId = ClientModel.IdClient;
                        }
                        List<int> productsIds = new List<int>();
                        foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                        {
                            productsIds.Add(int.Parse(dataGridViewRow.Cells[9].Value.ToString()));
                        }

                        List<int> productquantity = new List<int>();
                        foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                        {
                            productquantity.Add(int.Parse(dataGridViewRow.Cells[3].Value.ToString()));
                        }

                        List<decimal> productAmounts = new List<decimal>();
                        foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                        {
                            productAmounts.Add(decimal.Parse(dataGridViewRow.Cells[5].Value.ToString()));
                        }

                        List<decimal> productPrices = new List<decimal>();
                        foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                        {
                            productPrices.Add(decimal.Parse(dataGridViewRow.Cells[4].Value.ToString()));
                        }

                        List<decimal> productsDiscounts = new List<decimal>();
                        foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                        {
                            productsDiscounts.Add(decimal.Parse(dataGridViewRow.Cells[6].Value.ToString()));
                        }
                        InternalManagement.InsertInternalInvoiceSaleDetails(discount, taxes, subTotal, total, cashAmount, cardAmount, currencyType, mainBusinessId, clientId, employeeId, productsIds, productquantity, productPrices, productAmounts, productsDiscounts);
                        clearButton.PerformClick();
                        toolStripStatusLabel1.Text = "Factura realizada con éxito";
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Debe ingresar un monto.", "Monto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Error";
                }
            }
        }
    }
}
