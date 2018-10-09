namespace UI.Forms
{
    partial class FrmExistingOffset
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.offsetGridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.generateSaleInvoiceTile = new MetroFramework.Controls.MetroTile();
            this.newResidueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.creditAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cashAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.employeeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.clientTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.residueTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.offsetGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.DisplayIcon = true;
            this.searchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(684, 63);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Ingrese número de apartado";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.ShowButton = true;
            this.searchTextBox.ShowClearButton = true;
            this.searchTextBox.Size = new System.Drawing.Size(215, 23);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Ingrese número de apartado";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // offsetGridView
            // 
            this.offsetGridView.AllowUserToAddRows = false;
            this.offsetGridView.AllowUserToDeleteRows = false;
            this.offsetGridView.AllowUserToResizeRows = false;
            this.offsetGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.offsetGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offsetGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.offsetGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offsetGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.offsetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.offsetGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.offsetGridView.EnableHeadersVisualStyles = false;
            this.offsetGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.offsetGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.offsetGridView.Location = new System.Drawing.Point(23, 92);
            this.offsetGridView.MultiSelect = false;
            this.offsetGridView.Name = "offsetGridView";
            this.offsetGridView.ReadOnly = true;
            this.offsetGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offsetGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.offsetGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.offsetGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.offsetGridView.Size = new System.Drawing.Size(876, 222);
            this.offsetGridView.TabIndex = 5;
            this.offsetGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offsetGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.generateSaleInvoiceTile);
            this.groupBox1.Controls.Add(this.residueTextBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.newResidueTextBox);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.creditAmountTextBox);
            this.groupBox1.Controls.Add(this.cashAmountTextBox);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.employeeTextBox);
            this.groupBox1.Controls.Add(this.clientTextBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Apartado";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(706, 19);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(136, 67);
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "Terminar Apartado";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // generateSaleInvoiceTile
            // 
            this.generateSaleInvoiceTile.ActiveControl = null;
            this.generateSaleInvoiceTile.Location = new System.Drawing.Point(706, 104);
            this.generateSaleInvoiceTile.Name = "generateSaleInvoiceTile";
            this.generateSaleInvoiceTile.Size = new System.Drawing.Size(136, 67);
            this.generateSaleInvoiceTile.TabIndex = 16;
            this.generateSaleInvoiceTile.Text = "Realizar Deposito";
            this.generateSaleInvoiceTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generateSaleInvoiceTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateSaleInvoiceTile.UseSelectable = true;
            this.generateSaleInvoiceTile.UseTileImage = true;
            // 
            // newResidueTextBox
            // 
            // 
            // 
            // 
            this.newResidueTextBox.CustomButton.Image = null;
            this.newResidueTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.newResidueTextBox.CustomButton.Name = "";
            this.newResidueTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.newResidueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newResidueTextBox.CustomButton.TabIndex = 1;
            this.newResidueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newResidueTextBox.CustomButton.UseSelectable = true;
            this.newResidueTextBox.CustomButton.Visible = false;
            this.newResidueTextBox.DisplayIcon = true;
            this.newResidueTextBox.Enabled = false;
            this.newResidueTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.newResidueTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.newResidueTextBox.Lines = new string[] {
        "0"};
            this.newResidueTextBox.Location = new System.Drawing.Point(465, 138);
            this.newResidueTextBox.MaxLength = 32767;
            this.newResidueTextBox.Name = "newResidueTextBox";
            this.newResidueTextBox.PasswordChar = '\0';
            this.newResidueTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newResidueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newResidueTextBox.SelectedText = "";
            this.newResidueTextBox.SelectionLength = 0;
            this.newResidueTextBox.SelectionStart = 0;
            this.newResidueTextBox.ShortcutsEnabled = true;
            this.newResidueTextBox.Size = new System.Drawing.Size(193, 39);
            this.newResidueTextBox.TabIndex = 15;
            this.newResidueTextBox.Text = "0";
            this.newResidueTextBox.UseSelectable = true;
            this.newResidueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newResidueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(344, 138);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(84, 19);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Nuevo Saldo";
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
            this.creditAmountTextBox.Location = new System.Drawing.Point(465, 81);
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
            this.creditAmountTextBox.TabIndex = 11;
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
            this.cashAmountTextBox.Location = new System.Drawing.Point(465, 23);
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
            this.cashAmountTextBox.TabIndex = 10;
            this.cashAmountTextBox.UseSelectable = true;
            this.cashAmountTextBox.WaterMark = "Ingrese el monto en efectivo";
            this.cashAmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cashAmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(344, 85);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(104, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Monto a crédito";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(344, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Monto en Efectivo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Vendedor";
            // 
            // employeeTextBox
            // 
            // 
            // 
            // 
            this.employeeTextBox.CustomButton.Image = null;
            this.employeeTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.employeeTextBox.CustomButton.Name = "";
            this.employeeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.employeeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employeeTextBox.CustomButton.TabIndex = 1;
            this.employeeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeeTextBox.CustomButton.UseSelectable = true;
            this.employeeTextBox.CustomButton.Visible = false;
            this.employeeTextBox.DisplayIcon = true;
            this.employeeTextBox.Enabled = false;
            this.employeeTextBox.Lines = new string[0];
            this.employeeTextBox.Location = new System.Drawing.Point(100, 81);
            this.employeeTextBox.MaxLength = 32767;
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.PasswordChar = '\0';
            this.employeeTextBox.PromptText = "Nombre del Vendedor";
            this.employeeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeTextBox.SelectedText = "";
            this.employeeTextBox.SelectionLength = 0;
            this.employeeTextBox.SelectionStart = 0;
            this.employeeTextBox.ShortcutsEnabled = true;
            this.employeeTextBox.Size = new System.Drawing.Size(193, 23);
            this.employeeTextBox.TabIndex = 6;
            this.employeeTextBox.UseSelectable = true;
            this.employeeTextBox.WaterMark = "Nombre del Vendedor";
            this.employeeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientTextBox
            // 
            // 
            // 
            // 
            this.clientTextBox.CustomButton.Image = null;
            this.clientTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.clientTextBox.CustomButton.Name = "";
            this.clientTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientTextBox.CustomButton.TabIndex = 1;
            this.clientTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientTextBox.CustomButton.UseSelectable = true;
            this.clientTextBox.CustomButton.Visible = false;
            this.clientTextBox.DisplayIcon = true;
            this.clientTextBox.Enabled = false;
            this.clientTextBox.Lines = new string[0];
            this.clientTextBox.Location = new System.Drawing.Point(100, 32);
            this.clientTextBox.MaxLength = 32767;
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.PasswordChar = '\0';
            this.clientTextBox.PromptText = "Nombre del Cliente";
            this.clientTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientTextBox.SelectedText = "";
            this.clientTextBox.SelectionLength = 0;
            this.clientTextBox.SelectionStart = 0;
            this.clientTextBox.ShortcutsEnabled = true;
            this.clientTextBox.Size = new System.Drawing.Size(193, 23);
            this.clientTextBox.TabIndex = 5;
            this.clientTextBox.UseSelectable = true;
            this.clientTextBox.WaterMark = "Nombre del Cliente";
            this.clientTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nombre";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Saldo Actual";
            // 
            // residueTextBox
            // 
            // 
            // 
            // 
            this.residueTextBox.CustomButton.Image = null;
            this.residueTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.residueTextBox.CustomButton.Name = "";
            this.residueTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.residueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.residueTextBox.CustomButton.TabIndex = 1;
            this.residueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.residueTextBox.CustomButton.UseSelectable = true;
            this.residueTextBox.CustomButton.Visible = false;
            this.residueTextBox.DisplayIcon = true;
            this.residueTextBox.Enabled = false;
            this.residueTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.residueTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.residueTextBox.Lines = new string[] {
        "0"};
            this.residueTextBox.Location = new System.Drawing.Point(100, 132);
            this.residueTextBox.MaxLength = 32767;
            this.residueTextBox.Name = "residueTextBox";
            this.residueTextBox.PasswordChar = '\0';
            this.residueTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.residueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.residueTextBox.SelectedText = "";
            this.residueTextBox.SelectionLength = 0;
            this.residueTextBox.SelectionStart = 0;
            this.residueTextBox.ShortcutsEnabled = true;
            this.residueTextBox.Size = new System.Drawing.Size(193, 39);
            this.residueTextBox.TabIndex = 15;
            this.residueTextBox.Text = "0";
            this.residueTextBox.UseSelectable = true;
            this.residueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.residueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmExistingOffset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.offsetGridView);
            this.Controls.Add(this.searchTextBox);
            this.Name = "FrmExistingOffset";
            this.Text = "Apartados Existentes";
            this.Load += new System.EventHandler(this.FrmExistingOffset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offsetGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroGrid offsetGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox employeeTextBox;
        private MetroFramework.Controls.MetroTextBox clientTextBox;
        private MetroFramework.Controls.MetroTextBox creditAmountTextBox;
        private MetroFramework.Controls.MetroTextBox cashAmountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox newResidueTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile generateSaleInvoiceTile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroTextBox residueTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}