namespace UI.UserControls
{
    partial class UCClients
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientIdLabel = new MetroFramework.Controls.MetroLabel();
            this.idTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.bornDateDateTime = new MetroFramework.Controls.MetroDateTime();
            this.identificationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.lastnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.clientsGridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.clientIdLabel);
            this.groupBox1.Controls.Add(this.idTypeComboBox);
            this.groupBox1.Controls.Add(this.bornDateDateTime);
            this.groupBox1.Controls.Add(this.identificationTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.lastnameTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(411, 64);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(39, 19);
            this.clientIdLabel.TabIndex = 7;
            this.clientIdLabel.Text = "Vacío";
            this.clientIdLabel.Visible = false;
            // 
            // idTypeComboBox
            // 
            this.idTypeComboBox.FormattingEnabled = true;
            this.idTypeComboBox.ItemHeight = 23;
            this.idTypeComboBox.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte",
            "Permiso de trabajo",
            "Residencia",
            "Cédula Jurídica"});
            this.idTypeComboBox.Location = new System.Drawing.Point(724, 54);
            this.idTypeComboBox.Name = "idTypeComboBox";
            this.idTypeComboBox.Size = new System.Drawing.Size(212, 29);
            this.idTypeComboBox.TabIndex = 5;
            this.idTypeComboBox.UseSelectable = true;
            // 
            // bornDateDateTime
            // 
            this.bornDateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bornDateDateTime.Location = new System.Drawing.Point(167, 83);
            this.bornDateDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.bornDateDateTime.Name = "bornDateDateTime";
            this.bornDateDateTime.Size = new System.Drawing.Size(212, 29);
            this.bornDateDateTime.TabIndex = 3;
            // 
            // identificationTextBox
            // 
            // 
            // 
            // 
            this.identificationTextBox.CustomButton.Image = null;
            this.identificationTextBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.identificationTextBox.CustomButton.Name = "";
            this.identificationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.identificationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.identificationTextBox.CustomButton.TabIndex = 1;
            this.identificationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.identificationTextBox.CustomButton.UseSelectable = true;
            this.identificationTextBox.CustomButton.Visible = false;
            this.identificationTextBox.DisplayIcon = true;
            this.identificationTextBox.Icon = global::UI.Properties.Resources.Identification_Documents_16px;
            this.identificationTextBox.Lines = new string[0];
            this.identificationTextBox.Location = new System.Drawing.Point(724, 89);
            this.identificationTextBox.MaxLength = 32767;
            this.identificationTextBox.Name = "identificationTextBox";
            this.identificationTextBox.PasswordChar = '\0';
            this.identificationTextBox.PromptText = "Ingrese el número de identificación";
            this.identificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.identificationTextBox.SelectedText = "";
            this.identificationTextBox.SelectionLength = 0;
            this.identificationTextBox.SelectionStart = 0;
            this.identificationTextBox.ShortcutsEnabled = true;
            this.identificationTextBox.Size = new System.Drawing.Size(212, 23);
            this.identificationTextBox.TabIndex = 6;
            this.identificationTextBox.UseSelectable = true;
            this.identificationTextBox.WaterMark = "Ingrese el número de identificación";
            this.identificationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.identificationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = null;
            this.emailTextBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = 1;
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = false;
            this.emailTextBox.DisplayIcon = true;
            this.emailTextBox.Icon = global::UI.Properties.Resources.Email_16px;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(724, 25);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "Ingrese el correo electrónico";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(212, 23);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.WaterMark = "Ingrese el correo electrónico";
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastnameTextBox
            // 
            // 
            // 
            // 
            this.lastnameTextBox.CustomButton.Image = null;
            this.lastnameTextBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.lastnameTextBox.CustomButton.Name = "";
            this.lastnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastnameTextBox.CustomButton.TabIndex = 1;
            this.lastnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastnameTextBox.CustomButton.UseSelectable = true;
            this.lastnameTextBox.CustomButton.Visible = false;
            this.lastnameTextBox.DisplayIcon = true;
            this.lastnameTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.lastnameTextBox.Lines = new string[0];
            this.lastnameTextBox.Location = new System.Drawing.Point(167, 54);
            this.lastnameTextBox.MaxLength = 32767;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.PasswordChar = '\0';
            this.lastnameTextBox.PromptText = "Ingrese los apellidos del cliente";
            this.lastnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastnameTextBox.SelectedText = "";
            this.lastnameTextBox.SelectionLength = 0;
            this.lastnameTextBox.SelectionStart = 0;
            this.lastnameTextBox.ShortcutsEnabled = true;
            this.lastnameTextBox.Size = new System.Drawing.Size(212, 23);
            this.lastnameTextBox.TabIndex = 2;
            this.lastnameTextBox.UseSelectable = true;
            this.lastnameTextBox.WaterMark = "Ingrese los apellidos del cliente";
            this.lastnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.DisplayIcon = true;
            this.nameTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(167, 25);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PromptText = "Ingrese el nombre del cliente";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(212, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMark = "Ingrese el nombre del cliente";
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 83);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Fecha de Nacimiento";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Apellidos";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(550, 89);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Identificación";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(550, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Tipo de Identificación";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(550, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Correo Electrónico";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(3, 141);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(84, 141);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(165, 141);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(246, 141);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.DisplayIcon = true;
            this.searchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(675, 141);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Ingrese el cliente a buscar";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.ShowButton = true;
            this.searchTextBox.Size = new System.Drawing.Size(273, 23);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Ingrese el cliente a buscar";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.searchTextBox_ButtonClick);
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.clientsGridView.EnableHeadersVisualStyles = false;
            this.clientsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGridView.Location = new System.Drawing.Point(3, 170);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.clientsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGridView.Size = new System.Drawing.Size(945, 324);
            this.clientsGridView.TabIndex = 3;
            this.clientsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsGridView_CellClick);
            // 
            // UCClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientsGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCClients";
            this.Size = new System.Drawing.Size(951, 497);
            this.Load += new System.EventHandler(this.UCClients_Load);
            this.Leave += new System.EventHandler(this.UCClients_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox idTypeComboBox;
        private MetroFramework.Controls.MetroDateTime bornDateDateTime;
        private MetroFramework.Controls.MetroTextBox identificationTextBox;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox lastnameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroGrid clientsGridView;
        private MetroFramework.Controls.MetroLabel clientIdLabel;
    }
}
