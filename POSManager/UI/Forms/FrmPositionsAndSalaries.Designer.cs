namespace UI.Forms
{
    partial class FrmPositionsAndSalaries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salariesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.searchPositionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.positionsGridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.clearPositionButton = new MetroFramework.Controls.MetroButton();
            this.positionIdLabel = new MetroFramework.Controls.MetroLabel();
            this.deletePositionButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.updatePositionButton = new MetroFramework.Controls.MetroButton();
            this.positionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.createPositionButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salarySearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.salariesGridView = new MetroFramework.Controls.MetroGrid();
            this.clearSalaryButton = new MetroFramework.Controls.MetroButton();
            this.deleteSalaryButton = new MetroFramework.Controls.MetroButton();
            this.updateSalaryButton = new MetroFramework.Controls.MetroButton();
            this.createSalaryButton = new MetroFramework.Controls.MetroButton();
            this.salaryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.salaryIdLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salariesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salariesComboBox);
            this.groupBox2.Controls.Add(this.searchPositionTextBox);
            this.groupBox2.Controls.Add(this.positionsGridView);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.clearPositionButton);
            this.groupBox2.Controls.Add(this.positionIdLabel);
            this.groupBox2.Controls.Add(this.deletePositionButton);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.updatePositionButton);
            this.groupBox2.Controls.Add(this.positionTextBox);
            this.groupBox2.Controls.Add(this.createPositionButton);
            this.groupBox2.Location = new System.Drawing.Point(397, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 405);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puestos";
            // 
            // salariesComboBox
            // 
            this.salariesComboBox.FormattingEnabled = true;
            this.salariesComboBox.ItemHeight = 23;
            this.salariesComboBox.Location = new System.Drawing.Point(168, 26);
            this.salariesComboBox.Name = "salariesComboBox";
            this.salariesComboBox.Size = new System.Drawing.Size(194, 29);
            this.salariesComboBox.TabIndex = 3;
            this.salariesComboBox.UseSelectable = true;
            this.salariesComboBox.SelectedIndexChanged += new System.EventHandler(this.salariesComboBox_SelectedIndexChanged);
            // 
            // searchPositionTextBox
            // 
            // 
            // 
            // 
            this.searchPositionTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.searchPositionTextBox.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.searchPositionTextBox.CustomButton.Name = "";
            this.searchPositionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchPositionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchPositionTextBox.CustomButton.TabIndex = 1;
            this.searchPositionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchPositionTextBox.CustomButton.UseSelectable = true;
            this.searchPositionTextBox.DisplayIcon = true;
            this.searchPositionTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.searchPositionTextBox.Lines = new string[0];
            this.searchPositionTextBox.Location = new System.Drawing.Point(134, 137);
            this.searchPositionTextBox.MaxLength = 32767;
            this.searchPositionTextBox.Name = "searchPositionTextBox";
            this.searchPositionTextBox.PasswordChar = '\0';
            this.searchPositionTextBox.PromptText = "Ingrese un puesto a buscar";
            this.searchPositionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchPositionTextBox.SelectedText = "";
            this.searchPositionTextBox.SelectionLength = 0;
            this.searchPositionTextBox.SelectionStart = 0;
            this.searchPositionTextBox.ShortcutsEnabled = true;
            this.searchPositionTextBox.ShowButton = true;
            this.searchPositionTextBox.Size = new System.Drawing.Size(228, 23);
            this.searchPositionTextBox.TabIndex = 5;
            this.searchPositionTextBox.UseSelectable = true;
            this.searchPositionTextBox.WaterMark = "Ingrese un puesto a buscar";
            this.searchPositionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchPositionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchPositionTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.searchPositionTextBox_ButtonClick);
            this.searchPositionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchPositionTextBox_KeyUp);
            // 
            // positionsGridView
            // 
            this.positionsGridView.AllowUserToAddRows = false;
            this.positionsGridView.AllowUserToDeleteRows = false;
            this.positionsGridView.AllowUserToResizeRows = false;
            this.positionsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.positionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.positionsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.positionsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.positionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.positionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.positionsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.positionsGridView.EnableHeadersVisualStyles = false;
            this.positionsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.positionsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.positionsGridView.Location = new System.Drawing.Point(6, 166);
            this.positionsGridView.Name = "positionsGridView";
            this.positionsGridView.ReadOnly = true;
            this.positionsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.positionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.positionsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.positionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.positionsGridView.Size = new System.Drawing.Size(356, 233);
            this.positionsGridView.TabIndex = 3;
            this.positionsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.positionsGridView_CellClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 26);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(20, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Id";
            // 
            // clearPositionButton
            // 
            this.clearPositionButton.Location = new System.Drawing.Point(287, 99);
            this.clearPositionButton.Name = "clearPositionButton";
            this.clearPositionButton.Size = new System.Drawing.Size(75, 23);
            this.clearPositionButton.TabIndex = 2;
            this.clearPositionButton.Text = "Limpiar";
            this.clearPositionButton.UseSelectable = true;
            this.clearPositionButton.Click += new System.EventHandler(this.clearPositionButton_Click);
            // 
            // positionIdLabel
            // 
            this.positionIdLabel.AutoSize = true;
            this.positionIdLabel.Location = new System.Drawing.Point(32, 26);
            this.positionIdLabel.Name = "positionIdLabel";
            this.positionIdLabel.Size = new System.Drawing.Size(16, 19);
            this.positionIdLabel.TabIndex = 0;
            this.positionIdLabel.Text = "0";
            // 
            // deletePositionButton
            // 
            this.deletePositionButton.Location = new System.Drawing.Point(168, 99);
            this.deletePositionButton.Name = "deletePositionButton";
            this.deletePositionButton.Size = new System.Drawing.Size(75, 23);
            this.deletePositionButton.TabIndex = 2;
            this.deletePositionButton.Text = "Eliminar";
            this.deletePositionButton.UseSelectable = true;
            this.deletePositionButton.Click += new System.EventHandler(this.deletePositionButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Posición";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(113, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Salario";
            // 
            // updatePositionButton
            // 
            this.updatePositionButton.Location = new System.Drawing.Point(87, 99);
            this.updatePositionButton.Name = "updatePositionButton";
            this.updatePositionButton.Size = new System.Drawing.Size(75, 23);
            this.updatePositionButton.TabIndex = 2;
            this.updatePositionButton.Text = "Modificar";
            this.updatePositionButton.UseSelectable = true;
            this.updatePositionButton.Click += new System.EventHandler(this.updatePositionButton_Click);
            // 
            // positionTextBox
            // 
            // 
            // 
            // 
            this.positionTextBox.CustomButton.Image = null;
            this.positionTextBox.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.positionTextBox.CustomButton.Name = "";
            this.positionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.positionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.positionTextBox.CustomButton.TabIndex = 1;
            this.positionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.positionTextBox.CustomButton.UseSelectable = true;
            this.positionTextBox.CustomButton.Visible = false;
            this.positionTextBox.DisplayIcon = true;
            this.positionTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.positionTextBox.Lines = new string[0];
            this.positionTextBox.Location = new System.Drawing.Point(68, 60);
            this.positionTextBox.MaxLength = 32767;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.PasswordChar = '\0';
            this.positionTextBox.PromptText = "Ingrese el nombre de la posición";
            this.positionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.positionTextBox.SelectedText = "";
            this.positionTextBox.SelectionLength = 0;
            this.positionTextBox.SelectionStart = 0;
            this.positionTextBox.ShortcutsEnabled = true;
            this.positionTextBox.Size = new System.Drawing.Size(294, 23);
            this.positionTextBox.TabIndex = 4;
            this.positionTextBox.UseSelectable = true;
            this.positionTextBox.WaterMark = "Ingrese el nombre de la posición";
            this.positionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.positionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createPositionButton
            // 
            this.createPositionButton.Location = new System.Drawing.Point(6, 99);
            this.createPositionButton.Name = "createPositionButton";
            this.createPositionButton.Size = new System.Drawing.Size(75, 23);
            this.createPositionButton.TabIndex = 2;
            this.createPositionButton.Text = "Agregar";
            this.createPositionButton.UseSelectable = true;
            this.createPositionButton.Click += new System.EventHandler(this.createPositionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salarySearchTextBox);
            this.groupBox1.Controls.Add(this.salariesGridView);
            this.groupBox1.Controls.Add(this.clearSalaryButton);
            this.groupBox1.Controls.Add(this.deleteSalaryButton);
            this.groupBox1.Controls.Add(this.updateSalaryButton);
            this.groupBox1.Controls.Add(this.createSalaryButton);
            this.groupBox1.Controls.Add(this.salaryTextBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.salaryIdLabel);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 405);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salarios";
            // 
            // salarySearchTextBox
            // 
            // 
            // 
            // 
            this.salarySearchTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.salarySearchTextBox.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.salarySearchTextBox.CustomButton.Name = "";
            this.salarySearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.salarySearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salarySearchTextBox.CustomButton.TabIndex = 1;
            this.salarySearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salarySearchTextBox.CustomButton.UseSelectable = true;
            this.salarySearchTextBox.DisplayIcon = true;
            this.salarySearchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.salarySearchTextBox.Lines = new string[0];
            this.salarySearchTextBox.Location = new System.Drawing.Point(134, 137);
            this.salarySearchTextBox.MaxLength = 32767;
            this.salarySearchTextBox.Name = "salarySearchTextBox";
            this.salarySearchTextBox.PasswordChar = '\0';
            this.salarySearchTextBox.PromptText = "Ingrese una cantidad a buscar";
            this.salarySearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salarySearchTextBox.SelectedText = "";
            this.salarySearchTextBox.SelectionLength = 0;
            this.salarySearchTextBox.SelectionStart = 0;
            this.salarySearchTextBox.ShortcutsEnabled = true;
            this.salarySearchTextBox.ShowButton = true;
            this.salarySearchTextBox.Size = new System.Drawing.Size(228, 23);
            this.salarySearchTextBox.TabIndex = 2;
            this.salarySearchTextBox.UseSelectable = true;
            this.salarySearchTextBox.WaterMark = "Ingrese una cantidad a buscar";
            this.salarySearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salarySearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.salarySearchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.salarySearchTextBox_ButtonClick);
            this.salarySearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.salarySearchTextBox_KeyUp);
            // 
            // salariesGridView
            // 
            this.salariesGridView.AllowUserToAddRows = false;
            this.salariesGridView.AllowUserToDeleteRows = false;
            this.salariesGridView.AllowUserToResizeRows = false;
            this.salariesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salariesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salariesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salariesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salariesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.salariesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salariesGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.salariesGridView.EnableHeadersVisualStyles = false;
            this.salariesGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.salariesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salariesGridView.Location = new System.Drawing.Point(6, 166);
            this.salariesGridView.Name = "salariesGridView";
            this.salariesGridView.ReadOnly = true;
            this.salariesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salariesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.salariesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salariesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salariesGridView.Size = new System.Drawing.Size(356, 233);
            this.salariesGridView.TabIndex = 3;
            this.salariesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salariesGridView_CellClick);
            // 
            // clearSalaryButton
            // 
            this.clearSalaryButton.Location = new System.Drawing.Point(287, 99);
            this.clearSalaryButton.Name = "clearSalaryButton";
            this.clearSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.clearSalaryButton.TabIndex = 2;
            this.clearSalaryButton.Text = "Limpiar";
            this.clearSalaryButton.UseSelectable = true;
            this.clearSalaryButton.Click += new System.EventHandler(this.clearSalaryButton_Click);
            // 
            // deleteSalaryButton
            // 
            this.deleteSalaryButton.Location = new System.Drawing.Point(168, 99);
            this.deleteSalaryButton.Name = "deleteSalaryButton";
            this.deleteSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSalaryButton.TabIndex = 2;
            this.deleteSalaryButton.Text = "Eliminar";
            this.deleteSalaryButton.UseSelectable = true;
            this.deleteSalaryButton.Click += new System.EventHandler(this.deleteSalaryButton_Click);
            // 
            // updateSalaryButton
            // 
            this.updateSalaryButton.Location = new System.Drawing.Point(87, 99);
            this.updateSalaryButton.Name = "updateSalaryButton";
            this.updateSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.updateSalaryButton.TabIndex = 2;
            this.updateSalaryButton.Text = "Modificar";
            this.updateSalaryButton.UseSelectable = true;
            this.updateSalaryButton.Click += new System.EventHandler(this.updateSalaryButton_Click);
            // 
            // createSalaryButton
            // 
            this.createSalaryButton.Location = new System.Drawing.Point(6, 99);
            this.createSalaryButton.Name = "createSalaryButton";
            this.createSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.createSalaryButton.TabIndex = 2;
            this.createSalaryButton.Text = "Agregar";
            this.createSalaryButton.UseSelectable = true;
            this.createSalaryButton.Click += new System.EventHandler(this.createSalaryButton_Click);
            // 
            // salaryTextBox
            // 
            // 
            // 
            // 
            this.salaryTextBox.CustomButton.Image = null;
            this.salaryTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.salaryTextBox.CustomButton.Name = "";
            this.salaryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.salaryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryTextBox.CustomButton.TabIndex = 1;
            this.salaryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryTextBox.CustomButton.UseSelectable = true;
            this.salaryTextBox.CustomButton.Visible = false;
            this.salaryTextBox.DisplayIcon = true;
            this.salaryTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.salaryTextBox.Lines = new string[0];
            this.salaryTextBox.Location = new System.Drawing.Point(140, 60);
            this.salaryTextBox.MaxLength = 32767;
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.PasswordChar = '\0';
            this.salaryTextBox.PromptText = "Ingrese la cantidad del salario";
            this.salaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryTextBox.SelectedText = "";
            this.salaryTextBox.SelectionLength = 0;
            this.salaryTextBox.SelectionStart = 0;
            this.salaryTextBox.ShortcutsEnabled = true;
            this.salaryTextBox.Size = new System.Drawing.Size(222, 23);
            this.salaryTextBox.TabIndex = 1;
            this.salaryTextBox.UseSelectable = true;
            this.salaryTextBox.WaterMark = "Ingrese la cantidad del salario";
            this.salaryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Cantidad del Salario";
            // 
            // salaryIdLabel
            // 
            this.salaryIdLabel.AutoSize = true;
            this.salaryIdLabel.Location = new System.Drawing.Point(32, 26);
            this.salaryIdLabel.Name = "salaryIdLabel";
            this.salaryIdLabel.Size = new System.Drawing.Size(16, 19);
            this.salaryIdLabel.TabIndex = 0;
            this.salaryIdLabel.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id";
            // 
            // FrmPositionsAndSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPositionsAndSalaries";
            this.Text = "Puestos y Salarios";
            this.Load += new System.EventHandler(this.FrmPositionsAndSalaries_Load);
            this.Leave += new System.EventHandler(this.FrmPositionsAndSalaries_Leave);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salariesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox searchPositionTextBox;
        private MetroFramework.Controls.MetroGrid positionsGridView;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton clearPositionButton;
        private MetroFramework.Controls.MetroLabel positionIdLabel;
        private MetroFramework.Controls.MetroButton deletePositionButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton updatePositionButton;
        private MetroFramework.Controls.MetroTextBox positionTextBox;
        private MetroFramework.Controls.MetroButton createPositionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox salarySearchTextBox;
        private MetroFramework.Controls.MetroGrid salariesGridView;
        private MetroFramework.Controls.MetroButton clearSalaryButton;
        private MetroFramework.Controls.MetroButton deleteSalaryButton;
        private MetroFramework.Controls.MetroButton updateSalaryButton;
        private MetroFramework.Controls.MetroButton createSalaryButton;
        private MetroFramework.Controls.MetroTextBox salaryTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel salaryIdLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox salariesComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}