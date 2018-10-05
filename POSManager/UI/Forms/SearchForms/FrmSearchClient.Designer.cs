namespace UI.Forms.SearchForms
{
    partial class FrmSearchClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientsGridView = new MetroFramework.Controls.MetroGrid();
            this.clientSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.getClientButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToAddRows = false;
            this.clientsGridView.AllowUserToDeleteRows = false;
            this.clientsGridView.AllowUserToResizeRows = false;
            this.clientsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clientsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.clientsGridView.EnableHeadersVisualStyles = false;
            this.clientsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGridView.Location = new System.Drawing.Point(23, 92);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.clientsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGridView.Size = new System.Drawing.Size(462, 279);
            this.clientsGridView.TabIndex = 0;
            // 
            // clientSearchTextBox
            // 
            // 
            // 
            // 
            this.clientSearchTextBox.CustomButton.Image = null;
            this.clientSearchTextBox.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.clientSearchTextBox.CustomButton.Name = "";
            this.clientSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientSearchTextBox.CustomButton.TabIndex = 1;
            this.clientSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientSearchTextBox.CustomButton.UseSelectable = true;
            this.clientSearchTextBox.CustomButton.Visible = false;
            this.clientSearchTextBox.DisplayIcon = true;
            this.clientSearchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.clientSearchTextBox.Lines = new string[0];
            this.clientSearchTextBox.Location = new System.Drawing.Point(171, 63);
            this.clientSearchTextBox.MaxLength = 32767;
            this.clientSearchTextBox.Name = "clientSearchTextBox";
            this.clientSearchTextBox.PasswordChar = '\0';
            this.clientSearchTextBox.PromptText = "Ingrese la información del cliente";
            this.clientSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientSearchTextBox.SelectedText = "";
            this.clientSearchTextBox.SelectionLength = 0;
            this.clientSearchTextBox.SelectionStart = 0;
            this.clientSearchTextBox.ShortcutsEnabled = true;
            this.clientSearchTextBox.ShowClearButton = true;
            this.clientSearchTextBox.Size = new System.Drawing.Size(314, 23);
            this.clientSearchTextBox.TabIndex = 2;
            this.clientSearchTextBox.UseSelectable = true;
            this.clientSearchTextBox.WaterMark = "Ingrese la información del cliente";
            this.clientSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.clientSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.clientSearchTextBox_KeyUp);
            // 
            // getClientButton
            // 
            this.getClientButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.getClientButton.Location = new System.Drawing.Point(387, 377);
            this.getClientButton.Name = "getClientButton";
            this.getClientButton.Size = new System.Drawing.Size(98, 23);
            this.getClientButton.TabIndex = 3;
            this.getClientButton.Text = "Obtener Cliente";
            this.getClientButton.UseSelectable = true;
            this.getClientButton.Click += new System.EventHandler(this.getClientButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Información del cliente";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmSearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.getClientButton);
            this.Controls.Add(this.clientSearchTextBox);
            this.Controls.Add(this.clientsGridView);
            this.Name = "FrmSearchClient";
            this.Text = "Búsqueda rápida de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid clientsGridView;
        private MetroFramework.Controls.MetroTextBox clientSearchTextBox;
        private MetroFramework.Controls.MetroButton getClientButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}