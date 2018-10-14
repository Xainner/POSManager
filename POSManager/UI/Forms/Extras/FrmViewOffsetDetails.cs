using BusinessLibrary.Models;
using LogicLibrary.Management;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Extras
{
    public partial class FrmViewOffsetDetails : MetroForm
    {
        string num;

        public FrmViewOffsetDetails(string numOffset)
        {
            InitializeComponent();
            num = numOffset;
        }

        private void FrmViewOffsetDetails_Load(object sender, EventArgs e)
        {
            OffSetDetailsModel offSetDetails = OffsetDetailsManagement.SelectDetailOffsetByNumOffset(num);

            List<ProductXOffsetModel> productXOffset = OffsetDetailsManagement.SelectProducXOffsetByNumOffset(num);

            List<DepositXOffsetModel> depositXOffset = OffsetDetailsManagement.SelectDepositByNumOffset(num);

            metroLabel4.Text = num.ToString();
            employeeTextBox.Text = (EmployeeManagement.SelectEmployeeById(offSetDetails.IdEmployee)).Name;
            clientTextBox.Text = offSetDetails.Client;
            currencyTypeTextBox.Text = offSetDetails.CurrencyType;
            endDateTextBox.Text = offSetDetails.EndDate.ToString();
            endDateTextBox.Text = offSetDetails.EndDate.ToString();
            discountTextBox.Text = offSetDetails.Discount.ToString();
            taxesTextBox.Text = offSetDetails.Taxes.ToString();
            totalTextBox.Text = offSetDetails.Total.ToString();
            subTotalTextBox.Text = offSetDetails.SubTotal.ToString();

            productsGridView.Columns.Add("Id", "Factura");
            productsGridView.Columns.Add("product", "Producto");
            productsGridView.Columns.Add("quantity", "Cantidad");

            productsGridView.Columns["product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (ProductXOffsetModel item in productXOffset)
            {
                ProductModel product = ProductManagement.SelectProductByID(item.IdProduct.ToString());
                productsGridView.Rows.Add(item.IdDetailOffsetInvoice, product.Description, item.Quantity);
            }

            offsetGridView.Columns.Add("IdFact", "Factura");
            offsetGridView.Columns.Add("name", "Nombre");
            offsetGridView.Columns.Add("payment", "Pagos");

            offsetGridView.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DepositXOffsetModel item2 in depositXOffset)
            {
                offsetGridView.Rows.Add(item2.IdDetailOffsetInvoice, item2.Name, item2.Deposit);
            }
            
        }

        private void FrmViewOffsetDetails_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
