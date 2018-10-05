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
using LogicLibrary.Management;
using MetroFramework.Forms;
using UI.Forms.SearchForms;
using UI.Utilities;

namespace UI.Forms
{
    public partial class FrmInvoiceSale : MetroForm
    {
        //---------GLOBALS---------\\
        List<ProductModel> productModels = new List<ProductModel>();
        public static ClientModel ClientModel { get; set; }
        public static EmployeeModel EmployeeModel { get; set; }

        //---------FORM---------\\

        public FrmInvoiceSale()
        {
            InitializeComponent();
        }

        private void FrmInvoiceSale_Load(object sender, EventArgs e)
        {
            WireUpProductsGridView();
            metroLabel14.Text = DateTime.Today.ToString();
            metroLabel4.Text = "";
        }

        private void FrmInvoiceSale_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
               
        //---------CUSTOM METHODS---------\\

        private bool SearchDuplicates(string code)
        {
            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                if (code.Equals(dataGridViewRow.Cells[0].Value.ToString()))
                {
                    int quantity = int.Parse(dataGridViewRow.Cells[3].Value.ToString());
                    dataGridViewRow.Cells[3].Value = (quantity + 1);
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

            amount = (amount - (amount * (discount / 100)));

            string tax = "0.13";
            decimal subTotal = amount - (decimal.Parse(tax) * amount);

            decimal taxes = amount - subTotal;
            dataGridViewRow.Cells[5].Value = amount.ToString("#.##");
            dataGridViewRow.Cells[7].Value = taxes.ToString("#.##");

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

            foreach (DataGridViewColumn dataGridViewColumn in productsGridView.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewColumn.ReadOnly = true;
            }

            productsGridView.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            productsGridView.Columns[3].ReadOnly = false;
            productsGridView.Columns[6].ReadOnly = false;

            productsGridView.MultiSelect = false;
        }

        private void CalculateInvoiceDetails()
        {
            decimal discounts = 0;
            decimal amount = 0;
            decimal taxes = 0;

            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                amount += decimal.Parse(dataGridViewRow.Cells[5].Value.ToString());
                taxes += decimal.Parse(dataGridViewRow.Cells[8].Value.ToString());
            }

            decimal subTotal = amount - taxes;
            decimal total = amount;

            discountTextBox.Text = discounts.ToString("#.##");
            subTotalTextBox.Text = subTotal.ToString("#.##");
            taxesTextBox.Text = taxes.ToString("#.##");
            totalTextBox.Text = total.ToString("#.##");
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

        //---------EVENTS---------\\

        private void employeeTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (CustomDialogs.SearchEmployee() == DialogResult.OK)
            {
                employeeTextBox.Text = $" { EmployeeModel.Name } { EmployeeModel.LastName}";
            }
        }

        private void clientTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (CustomDialogs.SearchClient() == DialogResult.OK)
            {
                clientTextBox.Text = $" { ClientModel.Name } { ClientModel.Lastname}";
            }
        }

        private void productsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ModifyProductDetails(productsGridView.CurrentRow);
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductModel productModel = ProductManagement.SelectProductByCode(codeTextBox.Text);
                string code = productModel.Code;
                string description = productModel.Description;

                string subCategory = (SubCategoryManagement.SelectSubCategoryById(productModel.idsubCategory).Name);

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
                    productsGridView.Rows.Add(code, description, subCategory, quantity, price, paymentAmount, discount, taxType, taxes);
                }
                ModifyProductDetails();
                CalculateInvoiceDetails();
                ValidateTaxes();
            }
        }

        
        //---------CRUD---------\\
    }
}
