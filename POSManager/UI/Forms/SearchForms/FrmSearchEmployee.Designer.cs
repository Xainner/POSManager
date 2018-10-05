namespace UI.Forms.SearchForms
{
    partial class FrmSearchEmployee
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.getEmployeeButton = new MetroFramework.Controls.MetroButton();
            this.employeeSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.employeesGridView = new MetroFramework.Controls.MetroGrid();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Información del empleado";
            // 
            // getEmployeeButton
            // 
            this.getEmployeeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.getEmployeeButton.Location = new System.Drawing.Point(362, 377);
            this.getEmployeeButton.Name = "getEmployeeButton";
            this.getEmployeeButton.Size = new System.Drawing.Size(123, 23);
            this.getEmployeeButton.TabIndex = 9;
            this.getEmployeeButton.Text = "Obtener Empleado";
            this.getEmployeeButton.UseSelectable = true;
            this.getEmployeeButton.Click += new System.EventHandler(this.getEmployeeButton_Click);
            // 
            // employeeSearchTextBox
            // 
            // 
            // 
            // 
            this.employeeSearchTextBox.CustomButton.Image = null;
            this.employeeSearchTextBox.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.employeeSearchTextBox.CustomButton.Name = "";
            this.employeeSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.employeeSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employeeSearchTextBox.CustomButton.TabIndex = 1;
            this.employeeSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeeSearchTextBox.CustomButton.UseSelectable = true;
            this.employeeSearchTextBox.CustomButton.Visible = false;
            this.employeeSearchTextBox.DisplayIcon = true;
            this.employeeSearchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.employeeSearchTextBox.Lines = new string[0];
            this.employeeSearchTextBox.Location = new System.Drawing.Point(194, 63);
            this.employeeSearchTextBox.MaxLength = 32767;
            this.employeeSearchTextBox.Name = "employeeSearchTextBox";
            this.employeeSearchTextBox.PasswordChar = '\0';
            this.employeeSearchTextBox.PromptText = "Ingrese la información del empleado";
            this.employeeSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeSearchTextBox.SelectedText = "";
            this.employeeSearchTextBox.SelectionLength = 0;
            this.employeeSearchTextBox.SelectionStart = 0;
            this.employeeSearchTextBox.ShortcutsEnabled = true;
            this.employeeSearchTextBox.ShowClearButton = true;
            this.employeeSearchTextBox.Size = new System.Drawing.Size(291, 23);
            this.employeeSearchTextBox.TabIndex = 8;
            this.employeeSearchTextBox.UseSelectable = true;
            this.employeeSearchTextBox.WaterMark = "Ingrese la información del empleado";
            this.employeeSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.employeeSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.employeeSearchTextBox_KeyUp);
            // 
            // employeesGridView
            // 
            this.employeesGridView.AllowUserToAddRows = false;
            this.employeesGridView.AllowUserToDeleteRows = false;
            this.employeesGridView.AllowUserToResizeRows = false;
            this.employeesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employeesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employeesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.employeesGridView.EnableHeadersVisualStyles = false;
            this.employeesGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.employeesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employeesGridView.Location = new System.Drawing.Point(23, 92);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.ReadOnly = true;
            this.employeesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.employeesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employeesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesGridView.Size = new System.Drawing.Size(462, 279);
            this.employeesGridView.TabIndex = 7;
            // 
            // FrmSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.getEmployeeButton);
            this.Controls.Add(this.employeeSearchTextBox);
            this.Controls.Add(this.employeesGridView);
            this.Name = "FrmSearchEmployee";
            this.Text = "Búsqueda rápida de empleados";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton getEmployeeButton;
        private MetroFramework.Controls.MetroTextBox employeeSearchTextBox;
        private MetroFramework.Controls.MetroGrid employeesGridView;
    }
}