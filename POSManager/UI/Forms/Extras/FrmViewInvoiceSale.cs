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
    public partial class FrmViewInvoiceSale : MetroForm
    {
        ExternalInvoiceSaleDetailsModel ExternalInvoiceSaleDetailsModel;

        int id;
        public FrmViewInvoiceSale(int receiptId)
        {
            InitializeComponent();
            id = receiptId;
        }

        private void FrmInvoiceSale_Load(object sender, EventArgs e)
        {
            ExternalInvoiceSaleDetailsModel = ExternalInvoiceSaleManagement.SelectInvoiceById2(id);
            List<ProductXQuantityModel> productXQuantityModels = ExternalInvoiceSaleManagement.SelectProductsInvoiceXInvoiceId(id);

            metroLabel4.Text = id.ToString();

            metroComboBox1.SelectedItem = ExternalInvoiceSaleDetailsModel.CurrencyType;

            productsGridView.Columns.Add("description", "Descripción");
            productsGridView.Columns.Add("quantity", "Cantidad");
            productsGridView.Columns.Add("price", "Precio P/U");
            productsGridView.Columns.Add("paymentAmount", "Monto");
            productsGridView.Columns.Add("discount", "Descuento (%)");

            productsGridView.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productsGridView.Columns["discount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (ProductXQuantityModel item in productXQuantityModels)
            {
                productsGridView.Rows.Add(item.description, item.quantity, item.price, item.price, item.discount, item.discount);
            }

            toolStripStatusLabel1.Text = "Área de facturación.";

            cashAmountTextBox.Text = ExternalInvoiceSaleDetailsModel.CashDeposit.ToString();
            creditAmountTextBox.Text = ExternalInvoiceSaleDetailsModel.CardDeposit.ToString();
            subTotalTextBox.Text = ExternalInvoiceSaleDetailsModel.SubTotal.ToString();
            discountTextBox.Text = ExternalInvoiceSaleDetailsModel.TotalDiscount.ToString();
            taxesTextBox.Text = ExternalInvoiceSaleDetailsModel.IviAmount.ToString();
            totalTextBox.Text = ExternalInvoiceSaleDetailsModel.Total.ToString();

            employeeTextBox.Text = (EmployeeManagement.SelectEmployeeById(ExternalInvoiceSaleDetailsModel.IdEmployee)).Name;

            if (ExternalInvoiceSaleDetailsModel.IdClient != 0)
            {
                clientTextBox.Text = (ClientManagement.SelectClientById(ExternalInvoiceSaleDetailsModel.IdClient)).Name;
            }
        }

        private void FrmInvoiceSale_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
