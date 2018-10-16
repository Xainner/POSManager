namespace UI.Forms
{
    partial class FrmInvoiceSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.employeeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.clientTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.productsGridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeButton = new MetroFramework.Controls.MetroButton();
            this.generateSaleInvoiceTile = new MetroFramework.Controls.MetroTile();
            this.taxesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.subTotalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.discountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.changeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.totalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.creditAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cashAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.reloadLatestInvoiceNumber = new System.Windows.Forms.Timer(this.components);
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.employeeTextBox);
            this.groupBox1.Controls.Add(this.clientTextBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la Factura";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Colón",
            "Dolar",
            "Euro"});
            this.metroComboBox1.Location = new System.Drawing.Point(486, 22);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(85, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(373, 28);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(107, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Tipo de Moneda";
            // 
            // employeeTextBox
            // 
            // 
            // 
            // 
            this.employeeTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.employeeTextBox.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.employeeTextBox.CustomButton.Name = "";
            this.employeeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.employeeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employeeTextBox.CustomButton.TabIndex = 1;
            this.employeeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeeTextBox.CustomButton.UseSelectable = true;
            this.employeeTextBox.DisplayIcon = true;
            this.employeeTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.employeeTextBox.Lines = new string[0];
            this.employeeTextBox.Location = new System.Drawing.Point(99, 28);
            this.employeeTextBox.MaxLength = 32767;
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.PasswordChar = '\0';
            this.employeeTextBox.PromptText = "Ingrese el nombre del vendedor";
            this.employeeTextBox.ReadOnly = true;
            this.employeeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeTextBox.SelectedText = "";
            this.employeeTextBox.SelectionLength = 0;
            this.employeeTextBox.SelectionStart = 0;
            this.employeeTextBox.ShortcutsEnabled = true;
            this.employeeTextBox.ShowButton = true;
            this.employeeTextBox.Size = new System.Drawing.Size(221, 23);
            this.employeeTextBox.TabIndex = 1;
            this.employeeTextBox.UseSelectable = true;
            this.employeeTextBox.WaterMark = "Ingrese el nombre del vendedor";
            this.employeeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.employeeTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.employeeTextBox_ButtonClick);
            // 
            // clientTextBox
            // 
            // 
            // 
            // 
            this.clientTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.clientTextBox.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.clientTextBox.CustomButton.Name = "";
            this.clientTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientTextBox.CustomButton.TabIndex = 1;
            this.clientTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientTextBox.CustomButton.UseSelectable = true;
            this.clientTextBox.DisplayIcon = true;
            this.clientTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.clientTextBox.Lines = new string[0];
            this.clientTextBox.Location = new System.Drawing.Point(99, 62);
            this.clientTextBox.MaxLength = 32767;
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.PasswordChar = '\0';
            this.clientTextBox.PromptText = "Ingrese el nombre del cliente";
            this.clientTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientTextBox.SelectedText = "";
            this.clientTextBox.SelectionLength = 0;
            this.clientTextBox.SelectionStart = 0;
            this.clientTextBox.ShortcutsEnabled = true;
            this.clientTextBox.ShowButton = true;
            this.clientTextBox.Size = new System.Drawing.Size(221, 23);
            this.clientTextBox.TabIndex = 2;
            this.clientTextBox.UseSelectable = true;
            this.clientTextBox.WaterMark = "Ingrese el nombre del cliente";
            this.clientTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.clientTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.clientTextBox_ButtonClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(629, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(158, 25);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Número de Factura";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(815, 38);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(21, 25);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Cliente";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Vendedor";
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.ContextMenuStrip = this.metroContextMenu1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsGridView.EnableHeadersVisualStyles = false;
            this.productsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGridView.Location = new System.Drawing.Point(23, 197);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(876, 206);
            this.productsGridView.TabIndex = 4;
            this.productsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellEndEdit);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 168);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Código del Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeButton);
            this.groupBox2.Controls.Add(this.generateSaleInvoiceTile);
            this.groupBox2.Controls.Add(this.taxesTextBox);
            this.groupBox2.Controls.Add(this.subTotalTextBox);
            this.groupBox2.Controls.Add(this.discountTextBox);
            this.groupBox2.Controls.Add(this.changeTextBox);
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Controls.Add(this.creditAmountTextBox);
            this.groupBox2.Controls.Add(this.cashAmountTextBox);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Location = new System.Drawing.Point(23, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Pago";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(8, 143);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(113, 39);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calcular cambio";
            this.changeButton.UseSelectable = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // generateSaleInvoiceTile
            // 
            this.generateSaleInvoiceTile.ActiveControl = null;
            this.generateSaleInvoiceTile.Location = new System.Drawing.Point(714, 34);
            this.generateSaleInvoiceTile.Name = "generateSaleInvoiceTile";
            this.generateSaleInvoiceTile.Size = new System.Drawing.Size(136, 148);
            this.generateSaleInvoiceTile.TabIndex = 14;
            this.generateSaleInvoiceTile.Text = "Facturar";
            this.generateSaleInvoiceTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generateSaleInvoiceTile.TileImage = global::UI.Properties.Resources.Bill_56px;
            this.generateSaleInvoiceTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateSaleInvoiceTile.UseSelectable = true;
            this.generateSaleInvoiceTile.UseTileImage = true;
            this.generateSaleInvoiceTile.Click += new System.EventHandler(this.generateSaleInvoiceTile_Click);
            // 
            // taxesTextBox
            // 
            // 
            // 
            // 
            this.taxesTextBox.CustomButton.Image = null;
            this.taxesTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.taxesTextBox.CustomButton.Name = "";
            this.taxesTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.taxesTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.taxesTextBox.CustomButton.TabIndex = 1;
            this.taxesTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.taxesTextBox.CustomButton.UseSelectable = true;
            this.taxesTextBox.CustomButton.Visible = false;
            this.taxesTextBox.DisplayIcon = true;
            this.taxesTextBox.Enabled = false;
            this.taxesTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.taxesTextBox.Icon = global::UI.Properties.Resources.Tax_16px;
            this.taxesTextBox.Lines = new string[] {
        "0"};
            this.taxesTextBox.Location = new System.Drawing.Point(486, 114);
            this.taxesTextBox.MaxLength = 32767;
            this.taxesTextBox.Name = "taxesTextBox";
            this.taxesTextBox.PasswordChar = '\0';
            this.taxesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taxesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.taxesTextBox.SelectedText = "";
            this.taxesTextBox.SelectionLength = 0;
            this.taxesTextBox.SelectionStart = 0;
            this.taxesTextBox.ShortcutsEnabled = true;
            this.taxesTextBox.Size = new System.Drawing.Size(193, 39);
            this.taxesTextBox.TabIndex = 12;
            this.taxesTextBox.Text = "0";
            this.taxesTextBox.UseSelectable = true;
            this.taxesTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.taxesTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // subTotalTextBox
            // 
            // 
            // 
            // 
            this.subTotalTextBox.CustomButton.Image = null;
            this.subTotalTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.subTotalTextBox.CustomButton.Name = "";
            this.subTotalTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.subTotalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subTotalTextBox.CustomButton.TabIndex = 1;
            this.subTotalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subTotalTextBox.CustomButton.UseSelectable = true;
            this.subTotalTextBox.CustomButton.Visible = false;
            this.subTotalTextBox.DisplayIcon = true;
            this.subTotalTextBox.Enabled = false;
            this.subTotalTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.subTotalTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.subTotalTextBox.Lines = new string[] {
        "0"};
            this.subTotalTextBox.Location = new System.Drawing.Point(486, 68);
            this.subTotalTextBox.MaxLength = 32767;
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.PasswordChar = '\0';
            this.subTotalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subTotalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subTotalTextBox.SelectedText = "";
            this.subTotalTextBox.SelectionLength = 0;
            this.subTotalTextBox.SelectionStart = 0;
            this.subTotalTextBox.ShortcutsEnabled = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(193, 39);
            this.subTotalTextBox.TabIndex = 11;
            this.subTotalTextBox.Text = "0";
            this.subTotalTextBox.UseSelectable = true;
            this.subTotalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subTotalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // discountTextBox
            // 
            // 
            // 
            // 
            this.discountTextBox.CustomButton.Image = null;
            this.discountTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.discountTextBox.CustomButton.Name = "";
            this.discountTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.discountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountTextBox.CustomButton.TabIndex = 1;
            this.discountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountTextBox.CustomButton.UseSelectable = true;
            this.discountTextBox.CustomButton.Visible = false;
            this.discountTextBox.DisplayIcon = true;
            this.discountTextBox.Enabled = false;
            this.discountTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountTextBox.Icon = global::UI.Properties.Resources.Discount_16px;
            this.discountTextBox.Lines = new string[] {
        "0"};
            this.discountTextBox.Location = new System.Drawing.Point(486, 23);
            this.discountTextBox.MaxLength = 32767;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.PasswordChar = '\0';
            this.discountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountTextBox.SelectedText = "";
            this.discountTextBox.SelectionLength = 0;
            this.discountTextBox.SelectionStart = 0;
            this.discountTextBox.ShortcutsEnabled = true;
            this.discountTextBox.Size = new System.Drawing.Size(193, 39);
            this.discountTextBox.TabIndex = 10;
            this.discountTextBox.Text = "0";
            this.discountTextBox.UseSelectable = true;
            this.discountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // changeTextBox
            // 
            // 
            // 
            // 
            this.changeTextBox.CustomButton.Image = null;
            this.changeTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.changeTextBox.CustomButton.Name = "";
            this.changeTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.changeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.changeTextBox.CustomButton.TabIndex = 1;
            this.changeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.changeTextBox.CustomButton.UseSelectable = true;
            this.changeTextBox.CustomButton.Visible = false;
            this.changeTextBox.DisplayIcon = true;
            this.changeTextBox.Enabled = false;
            this.changeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.changeTextBox.Icon = global::UI.Properties.Resources.Cash_in_Hand_16px;
            this.changeTextBox.Lines = new string[0];
            this.changeTextBox.Location = new System.Drawing.Point(127, 143);
            this.changeTextBox.MaxLength = 32767;
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.PasswordChar = '\0';
            this.changeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.changeTextBox.SelectedText = "";
            this.changeTextBox.SelectionLength = 0;
            this.changeTextBox.SelectionStart = 0;
            this.changeTextBox.ShortcutsEnabled = true;
            this.changeTextBox.Size = new System.Drawing.Size(193, 39);
            this.changeTextBox.TabIndex = 7;
            this.changeTextBox.UseSelectable = true;
            this.changeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.changeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalTextBox
            // 
            // 
            // 
            // 
            this.totalTextBox.CustomButton.Image = null;
            this.totalTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.totalTextBox.CustomButton.Name = "";
            this.totalTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.totalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalTextBox.CustomButton.TabIndex = 1;
            this.totalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalTextBox.CustomButton.UseSelectable = true;
            this.totalTextBox.CustomButton.Visible = false;
            this.totalTextBox.DisplayIcon = true;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.totalTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.totalTextBox.Lines = new string[] {
        "0"};
            this.totalTextBox.Location = new System.Drawing.Point(486, 159);
            this.totalTextBox.MaxLength = 32767;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.PasswordChar = '\0';
            this.totalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalTextBox.SelectedText = "";
            this.totalTextBox.SelectionLength = 0;
            this.totalTextBox.SelectionStart = 0;
            this.totalTextBox.ShortcutsEnabled = true;
            this.totalTextBox.Size = new System.Drawing.Size(193, 39);
            this.totalTextBox.TabIndex = 13;
            this.totalTextBox.Text = "0";
            this.totalTextBox.UseSelectable = true;
            this.totalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // creditAmountTextBox
            // 
            // 
            // 
            // 
            this.creditAmountTextBox.CustomButton.Image = null;
            this.creditAmountTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.creditAmountTextBox.CustomButton.Name = "";
            this.creditAmountTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.creditAmountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.creditAmountTextBox.CustomButton.TabIndex = 1;
            this.creditAmountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.creditAmountTextBox.CustomButton.UseSelectable = true;
            this.creditAmountTextBox.CustomButton.Visible = false;
            this.creditAmountTextBox.DisplayIcon = true;
            this.creditAmountTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.creditAmountTextBox.Icon = global::UI.Properties.Resources.Credit_Card_16px;
            this.creditAmountTextBox.Lines = new string[0];
            this.creditAmountTextBox.Location = new System.Drawing.Point(127, 88);
            this.creditAmountTextBox.MaxLength = 32767;
            this.creditAmountTextBox.Name = "creditAmountTextBox";
            this.creditAmountTextBox.PasswordChar = '\0';
            this.creditAmountTextBox.PromptText = "Ingrese el monto en crédito";
            this.creditAmountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.creditAmountTextBox.SelectedText = "";
            this.creditAmountTextBox.SelectionLength = 0;
            this.creditAmountTextBox.SelectionStart = 0;
            this.creditAmountTextBox.ShortcutsEnabled = true;
            this.creditAmountTextBox.Size = new System.Drawing.Size(193, 39);
            this.creditAmountTextBox.TabIndex = 6;
            this.creditAmountTextBox.UseSelectable = true;
            this.creditAmountTextBox.WaterMark = "Ingrese el monto en crédito";
            this.creditAmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.creditAmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cashAmountTextBox
            // 
            // 
            // 
            // 
            this.cashAmountTextBox.CustomButton.Image = null;
            this.cashAmountTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.cashAmountTextBox.CustomButton.Name = "";
            this.cashAmountTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.cashAmountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cashAmountTextBox.CustomButton.TabIndex = 1;
            this.cashAmountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cashAmountTextBox.CustomButton.UseSelectable = true;
            this.cashAmountTextBox.CustomButton.Visible = false;
            this.cashAmountTextBox.DisplayIcon = true;
            this.cashAmountTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.cashAmountTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.cashAmountTextBox.Lines = new string[0];
            this.cashAmountTextBox.Location = new System.Drawing.Point(127, 30);
            this.cashAmountTextBox.MaxLength = 32767;
            this.cashAmountTextBox.Name = "cashAmountTextBox";
            this.cashAmountTextBox.PasswordChar = '\0';
            this.cashAmountTextBox.PromptText = "Ingrese el monto en efectivo";
            this.cashAmountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cashAmountTextBox.SelectedText = "";
            this.cashAmountTextBox.SelectionLength = 0;
            this.cashAmountTextBox.SelectionStart = 0;
            this.cashAmountTextBox.ShortcutsEnabled = true;
            this.cashAmountTextBox.Size = new System.Drawing.Size(193, 39);
            this.cashAmountTextBox.TabIndex = 5;
            this.cashAmountTextBox.UseSelectable = true;
            this.cashAmountTextBox.WaterMark = "Ingrese el monto en efectivo";
            this.cashAmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cashAmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cashAmountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cashAmountTextBox_KeyUp);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(386, 68);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(58, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "SubTotal";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 92);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(104, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Monto a crédito";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(386, 159);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(36, 19);
            this.metroLabel12.TabIndex = 0;
            this.metroLabel12.Text = "Total";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(386, 114);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(27, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "I.V.I";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(386, 23);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Descuento";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 34);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Monto en Efectivo";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(810, 630);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(697, 35);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(113, 25);
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "metroLabel14";
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Interval = 1000;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // reloadLatestInvoiceNumber
            // 
            this.reloadLatestInvoiceNumber.Enabled = true;
            this.reloadLatestInvoiceNumber.Interval = 5000;
            this.reloadLatestInvoiceNumber.Tick += new System.EventHandler(this.reloadLatestInvoiceNumber_Tick);
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.DisplayIcon = true;
            this.codeTextBox.Icon = global::UI.Properties.Resources.Barcode_16px;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(162, 168);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.PromptText = "Ingrese el código del producto";
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(216, 23);
            this.codeTextBox.TabIndex = 3;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMark = "Ingrese el código del producto";
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.codeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeTextBox_KeyUp);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteProductMenu});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(229, 48);
            // 
            // deleteProductMenu
            // 
            this.deleteProductMenu.Name = "deleteProductMenu";
            this.deleteProductMenu.Size = new System.Drawing.Size(228, 22);
            this.deleteProductMenu.Text = "Remover Producto de la Lista";
            this.deleteProductMenu.Click += new System.EventHandler(this.deleteProductMenu_Click);
            // 
            // FrmInvoiceSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 669);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FrmInvoiceSale";
            this.Text = "Factura de Venta";
            this.Load += new System.EventHandler(this.FrmInvoiceSale_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmInvoiceSale_KeyUp);
            this.Leave += new System.EventHandler(this.FrmInvoiceSale_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox clientTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox employeeTextBox;
        private MetroFramework.Controls.MetroGrid productsGridView;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox taxesTextBox;
        private MetroFramework.Controls.MetroTextBox subTotalTextBox;
        private MetroFramework.Controls.MetroTextBox discountTextBox;
        private MetroFramework.Controls.MetroTextBox changeTextBox;
        private MetroFramework.Controls.MetroTextBox totalTextBox;
        private MetroFramework.Controls.MetroTextBox creditAmountTextBox;
        private MetroFramework.Controls.MetroTextBox cashAmountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroTile generateSaleInvoiceTile;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton changeButton;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Timer reloadLatestInvoiceNumber;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem deleteProductMenu;
    }
}