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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.offsetGridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.depositButton = new MetroFramework.Controls.MetroButton();
            this.addDepositTile = new MetroFramework.Controls.MetroTile();
            this.depositTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.newResidueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.creditAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cashAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.searchTextBox.Location = new System.Drawing.Point(598, 63);
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
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offsetGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.offsetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.offsetGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.offsetGridView.EnableHeadersVisualStyles = false;
            this.offsetGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.offsetGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.offsetGridView.Location = new System.Drawing.Point(442, 109);
            this.offsetGridView.MultiSelect = false;
            this.offsetGridView.Name = "offsetGridView";
            this.offsetGridView.ReadOnly = true;
            this.offsetGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offsetGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.offsetGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.offsetGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.offsetGridView.Size = new System.Drawing.Size(371, 245);
            this.offsetGridView.TabIndex = 5;
            this.offsetGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offsetGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.depositButton);
            this.groupBox1.Controls.Add(this.addDepositTile);
            this.groupBox1.Controls.Add(this.depositTextBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.newResidueTextBox);
            this.groupBox1.Controls.Add(this.creditAmountTextBox);
            this.groupBox1.Controls.Add(this.cashAmountTextBox);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(23, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Apartado";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(20, 196);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(113, 39);
            this.depositButton.TabIndex = 17;
            this.depositButton.Text = "Calcular Saldo";
            this.depositButton.UseSelectable = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // addDepositTile
            // 
            this.addDepositTile.ActiveControl = null;
            this.addDepositTile.Location = new System.Drawing.Point(253, 253);
            this.addDepositTile.Name = "addDepositTile";
            this.addDepositTile.Size = new System.Drawing.Size(133, 40);
            this.addDepositTile.TabIndex = 16;
            this.addDepositTile.Text = "Realizar Deposito";
            this.addDepositTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addDepositTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDepositTile.UseSelectable = true;
            this.addDepositTile.UseTileImage = true;
            this.addDepositTile.Click += new System.EventHandler(this.addDepositTile_Click);
            // 
            // depositTextBox
            // 
            // 
            // 
            // 
            this.depositTextBox.CustomButton.Image = null;
            this.depositTextBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.depositTextBox.CustomButton.Name = "";
            this.depositTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.depositTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.depositTextBox.CustomButton.TabIndex = 1;
            this.depositTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.depositTextBox.CustomButton.UseSelectable = true;
            this.depositTextBox.CustomButton.Visible = false;
            this.depositTextBox.DisplayIcon = true;
            this.depositTextBox.Enabled = false;
            this.depositTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.depositTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.depositTextBox.Lines = new string[] {
        "0"};
            this.depositTextBox.Location = new System.Drawing.Point(148, 41);
            this.depositTextBox.MaxLength = 32767;
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.PasswordChar = '\0';
            this.depositTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.depositTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.depositTextBox.SelectedText = "";
            this.depositTextBox.SelectionLength = 0;
            this.depositTextBox.SelectionStart = 0;
            this.depositTextBox.ShortcutsEnabled = true;
            this.depositTextBox.Size = new System.Drawing.Size(193, 39);
            this.depositTextBox.TabIndex = 15;
            this.depositTextBox.Text = "0";
            this.depositTextBox.UseSelectable = true;
            this.depositTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.depositTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Saldo Actual";
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
            this.newResidueTextBox.Location = new System.Drawing.Point(148, 196);
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
            this.creditAmountTextBox.Location = new System.Drawing.Point(148, 142);
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
            this.cashAmountTextBox.Location = new System.Drawing.Point(148, 91);
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
            this.cashAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cashAmountTextBox.UseSelectable = true;
            this.cashAmountTextBox.WaterMark = "Ingrese el monto en efectivo";
            this.cashAmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cashAmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(18, 142);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(104, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Monto a crédito";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 91);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Monto en Efectivo";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(670, 360);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(143, 43);
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "Terminar Apartado";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmExistingOffset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.metroTile1);
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
        private MetroFramework.Controls.MetroTextBox creditAmountTextBox;
        private MetroFramework.Controls.MetroTextBox cashAmountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox newResidueTextBox;
        private MetroFramework.Controls.MetroTile addDepositTile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroTextBox depositTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton depositButton;
    }
}