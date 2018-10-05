namespace UI.UserControls
{
    partial class UCBusiness
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.businessIdLabel = new MetroFramework.Controls.MetroLabel();
            this.rotateRightLink = new MetroFramework.Controls.MetroLink();
            this.rotateLeftLink = new MetroFramework.Controls.MetroLink();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.selectLogoButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generalDirectionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.exactDirectionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.juridicIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.telephoneTextBox = new MetroFramework.Controls.MetroTextBox();
            this.webPageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.societyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fantasyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.businessGridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.businessIdLabel);
            this.groupBox1.Controls.Add(this.rotateRightLink);
            this.groupBox1.Controls.Add(this.rotateLeftLink);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.selectLogoButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.generalDirectionTextBox);
            this.groupBox1.Controls.Add(this.exactDirectionTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.juridicIdTextBox);
            this.groupBox1.Controls.Add(this.telephoneTextBox);
            this.groupBox1.Controls.Add(this.webPageTextBox);
            this.groupBox1.Controls.Add(this.societyNameTextBox);
            this.groupBox1.Controls.Add(this.fantasyNameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de los Negocios";
            // 
            // businessIdLabel
            // 
            this.businessIdLabel.AutoSize = true;
            this.businessIdLabel.Location = new System.Drawing.Point(6, 203);
            this.businessIdLabel.Name = "businessIdLabel";
            this.businessIdLabel.Size = new System.Drawing.Size(39, 19);
            this.businessIdLabel.TabIndex = 15;
            this.businessIdLabel.Text = "Vacío";
            this.businessIdLabel.Visible = false;
            // 
            // rotateRightLink
            // 
            this.rotateRightLink.Image = global::UI.Properties.Resources.Rotate_Right_16px1;
            this.rotateRightLink.Location = new System.Drawing.Point(896, 228);
            this.rotateRightLink.Name = "rotateRightLink";
            this.rotateRightLink.Size = new System.Drawing.Size(26, 23);
            this.rotateRightLink.TabIndex = 14;
            this.rotateRightLink.UseSelectable = true;
            this.rotateRightLink.Click += new System.EventHandler(this.rotateRightLink_Click);
            // 
            // rotateLeftLink
            // 
            this.rotateLeftLink.Image = global::UI.Properties.Resources.Rotate_Left_16px1;
            this.rotateLeftLink.Location = new System.Drawing.Point(761, 228);
            this.rotateLeftLink.Name = "rotateLeftLink";
            this.rotateLeftLink.Size = new System.Drawing.Size(26, 23);
            this.rotateLeftLink.TabIndex = 14;
            this.rotateLeftLink.UseSelectable = true;
            this.rotateLeftLink.Click += new System.EventHandler(this.rotateLeftLink_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(249, 228);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 228);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(87, 228);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 228);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // selectLogoButton
            // 
            this.selectLogoButton.Location = new System.Drawing.Point(793, 228);
            this.selectLogoButton.Name = "selectLogoButton";
            this.selectLogoButton.Size = new System.Drawing.Size(97, 23);
            this.selectLogoButton.TabIndex = 13;
            this.selectLogoButton.Text = "Seleccionar logo";
            this.selectLogoButton.UseSelectable = true;
            this.selectLogoButton.Click += new System.EventHandler(this.selectLogoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(734, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // generalDirectionTextBox
            // 
            // 
            // 
            // 
            this.generalDirectionTextBox.CustomButton.Image = null;
            this.generalDirectionTextBox.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.generalDirectionTextBox.CustomButton.Name = "";
            this.generalDirectionTextBox.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.generalDirectionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.generalDirectionTextBox.CustomButton.TabIndex = 1;
            this.generalDirectionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.generalDirectionTextBox.CustomButton.UseSelectable = true;
            this.generalDirectionTextBox.CustomButton.Visible = false;
            this.generalDirectionTextBox.DisplayIcon = true;
            this.generalDirectionTextBox.Icon = global::UI.Properties.Resources.Map_16px;
            this.generalDirectionTextBox.Lines = new string[0];
            this.generalDirectionTextBox.Location = new System.Drawing.Point(506, 119);
            this.generalDirectionTextBox.MaxLength = 32767;
            this.generalDirectionTextBox.Multiline = true;
            this.generalDirectionTextBox.Name = "generalDirectionTextBox";
            this.generalDirectionTextBox.PasswordChar = '\0';
            this.generalDirectionTextBox.PromptText = "Ingrese la dirección general";
            this.generalDirectionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.generalDirectionTextBox.SelectedText = "";
            this.generalDirectionTextBox.SelectionLength = 0;
            this.generalDirectionTextBox.SelectionStart = 0;
            this.generalDirectionTextBox.ShortcutsEnabled = true;
            this.generalDirectionTextBox.Size = new System.Drawing.Size(222, 88);
            this.generalDirectionTextBox.TabIndex = 8;
            this.generalDirectionTextBox.UseSelectable = true;
            this.generalDirectionTextBox.WaterMark = "Ingrese la dirección general";
            this.generalDirectionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.generalDirectionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // exactDirectionTextBox
            // 
            // 
            // 
            // 
            this.exactDirectionTextBox.CustomButton.Image = null;
            this.exactDirectionTextBox.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.exactDirectionTextBox.CustomButton.Name = "";
            this.exactDirectionTextBox.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.exactDirectionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.exactDirectionTextBox.CustomButton.TabIndex = 1;
            this.exactDirectionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.exactDirectionTextBox.CustomButton.UseSelectable = true;
            this.exactDirectionTextBox.CustomButton.Visible = false;
            this.exactDirectionTextBox.DisplayIcon = true;
            this.exactDirectionTextBox.Icon = global::UI.Properties.Resources.Map_Marker_16px;
            this.exactDirectionTextBox.Lines = new string[0];
            this.exactDirectionTextBox.Location = new System.Drawing.Point(160, 121);
            this.exactDirectionTextBox.MaxLength = 32767;
            this.exactDirectionTextBox.Multiline = true;
            this.exactDirectionTextBox.Name = "exactDirectionTextBox";
            this.exactDirectionTextBox.PasswordChar = '\0';
            this.exactDirectionTextBox.PromptText = "Dirección exacta";
            this.exactDirectionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.exactDirectionTextBox.SelectedText = "";
            this.exactDirectionTextBox.SelectionLength = 0;
            this.exactDirectionTextBox.SelectionStart = 0;
            this.exactDirectionTextBox.ShortcutsEnabled = true;
            this.exactDirectionTextBox.Size = new System.Drawing.Size(222, 88);
            this.exactDirectionTextBox.TabIndex = 4;
            this.exactDirectionTextBox.UseSelectable = true;
            this.exactDirectionTextBox.WaterMark = "Dirección exacta";
            this.exactDirectionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.exactDirectionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = null;
            this.emailTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
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
            this.emailTextBox.Location = new System.Drawing.Point(506, 90);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "Ingrese el correo electrónico";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(222, 23);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.WaterMark = "Ingrese el correo electrónico";
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // juridicIdTextBox
            // 
            // 
            // 
            // 
            this.juridicIdTextBox.CustomButton.Image = null;
            this.juridicIdTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.juridicIdTextBox.CustomButton.Name = "";
            this.juridicIdTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.juridicIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.juridicIdTextBox.CustomButton.TabIndex = 1;
            this.juridicIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.juridicIdTextBox.CustomButton.UseSelectable = true;
            this.juridicIdTextBox.CustomButton.Visible = false;
            this.juridicIdTextBox.DisplayIcon = true;
            this.juridicIdTextBox.Icon = global::UI.Properties.Resources.Identification_Documents_16px;
            this.juridicIdTextBox.Lines = new string[0];
            this.juridicIdTextBox.Location = new System.Drawing.Point(160, 90);
            this.juridicIdTextBox.MaxLength = 32767;
            this.juridicIdTextBox.Name = "juridicIdTextBox";
            this.juridicIdTextBox.PasswordChar = '\0';
            this.juridicIdTextBox.PromptText = "Ingrese la cédula jurídica";
            this.juridicIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.juridicIdTextBox.SelectedText = "";
            this.juridicIdTextBox.SelectionLength = 0;
            this.juridicIdTextBox.SelectionStart = 0;
            this.juridicIdTextBox.ShortcutsEnabled = true;
            this.juridicIdTextBox.Size = new System.Drawing.Size(222, 23);
            this.juridicIdTextBox.TabIndex = 3;
            this.juridicIdTextBox.UseSelectable = true;
            this.juridicIdTextBox.WaterMark = "Ingrese la cédula jurídica";
            this.juridicIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.juridicIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // telephoneTextBox
            // 
            // 
            // 
            // 
            this.telephoneTextBox.CustomButton.Image = null;
            this.telephoneTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.telephoneTextBox.CustomButton.Name = "";
            this.telephoneTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.telephoneTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telephoneTextBox.CustomButton.TabIndex = 1;
            this.telephoneTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telephoneTextBox.CustomButton.UseSelectable = true;
            this.telephoneTextBox.CustomButton.Visible = false;
            this.telephoneTextBox.DisplayIcon = true;
            this.telephoneTextBox.Icon = global::UI.Properties.Resources.Phone_16px;
            this.telephoneTextBox.Lines = new string[0];
            this.telephoneTextBox.Location = new System.Drawing.Point(506, 60);
            this.telephoneTextBox.MaxLength = 32767;
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.PasswordChar = '\0';
            this.telephoneTextBox.PromptText = "Ingrese el número teléfonico";
            this.telephoneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telephoneTextBox.SelectedText = "";
            this.telephoneTextBox.SelectionLength = 0;
            this.telephoneTextBox.SelectionStart = 0;
            this.telephoneTextBox.ShortcutsEnabled = true;
            this.telephoneTextBox.Size = new System.Drawing.Size(222, 23);
            this.telephoneTextBox.TabIndex = 6;
            this.telephoneTextBox.UseSelectable = true;
            this.telephoneTextBox.WaterMark = "Ingrese el número teléfonico";
            this.telephoneTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telephoneTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // webPageTextBox
            // 
            // 
            // 
            // 
            this.webPageTextBox.CustomButton.Image = null;
            this.webPageTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.webPageTextBox.CustomButton.Name = "";
            this.webPageTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.webPageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.webPageTextBox.CustomButton.TabIndex = 1;
            this.webPageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.webPageTextBox.CustomButton.UseSelectable = true;
            this.webPageTextBox.CustomButton.Visible = false;
            this.webPageTextBox.DisplayIcon = true;
            this.webPageTextBox.Icon = global::UI.Properties.Resources.Website_16px;
            this.webPageTextBox.Lines = new string[0];
            this.webPageTextBox.Location = new System.Drawing.Point(506, 28);
            this.webPageTextBox.MaxLength = 32767;
            this.webPageTextBox.Name = "webPageTextBox";
            this.webPageTextBox.PasswordChar = '\0';
            this.webPageTextBox.PromptText = "Ingrese la dirección web";
            this.webPageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.webPageTextBox.SelectedText = "";
            this.webPageTextBox.SelectionLength = 0;
            this.webPageTextBox.SelectionStart = 0;
            this.webPageTextBox.ShortcutsEnabled = true;
            this.webPageTextBox.Size = new System.Drawing.Size(222, 23);
            this.webPageTextBox.TabIndex = 5;
            this.webPageTextBox.UseSelectable = true;
            this.webPageTextBox.WaterMark = "Ingrese la dirección web";
            this.webPageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.webPageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // societyNameTextBox
            // 
            // 
            // 
            // 
            this.societyNameTextBox.CustomButton.Image = null;
            this.societyNameTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.societyNameTextBox.CustomButton.Name = "";
            this.societyNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.societyNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.societyNameTextBox.CustomButton.TabIndex = 1;
            this.societyNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.societyNameTextBox.CustomButton.UseSelectable = true;
            this.societyNameTextBox.CustomButton.Visible = false;
            this.societyNameTextBox.DisplayIcon = true;
            this.societyNameTextBox.Icon = global::UI.Properties.Resources.User_Groups_16px;
            this.societyNameTextBox.Lines = new string[0];
            this.societyNameTextBox.Location = new System.Drawing.Point(160, 60);
            this.societyNameTextBox.MaxLength = 32767;
            this.societyNameTextBox.Name = "societyNameTextBox";
            this.societyNameTextBox.PasswordChar = '\0';
            this.societyNameTextBox.PromptText = "Ingrese el nombre de la sociedad";
            this.societyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.societyNameTextBox.SelectedText = "";
            this.societyNameTextBox.SelectionLength = 0;
            this.societyNameTextBox.SelectionStart = 0;
            this.societyNameTextBox.ShortcutsEnabled = true;
            this.societyNameTextBox.Size = new System.Drawing.Size(222, 23);
            this.societyNameTextBox.TabIndex = 2;
            this.societyNameTextBox.UseSelectable = true;
            this.societyNameTextBox.WaterMark = "Ingrese el nombre de la sociedad";
            this.societyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.societyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fantasyNameTextBox
            // 
            // 
            // 
            // 
            this.fantasyNameTextBox.CustomButton.Image = null;
            this.fantasyNameTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.fantasyNameTextBox.CustomButton.Name = "";
            this.fantasyNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fantasyNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fantasyNameTextBox.CustomButton.TabIndex = 1;
            this.fantasyNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fantasyNameTextBox.CustomButton.UseSelectable = true;
            this.fantasyNameTextBox.CustomButton.Visible = false;
            this.fantasyNameTextBox.DisplayIcon = true;
            this.fantasyNameTextBox.Icon = global::UI.Properties.Resources.Shop_16px;
            this.fantasyNameTextBox.Lines = new string[0];
            this.fantasyNameTextBox.Location = new System.Drawing.Point(160, 28);
            this.fantasyNameTextBox.MaxLength = 32767;
            this.fantasyNameTextBox.Name = "fantasyNameTextBox";
            this.fantasyNameTextBox.PasswordChar = '\0';
            this.fantasyNameTextBox.PromptText = "Ingrese el nombre de fantasía";
            this.fantasyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fantasyNameTextBox.SelectedText = "";
            this.fantasyNameTextBox.SelectionLength = 0;
            this.fantasyNameTextBox.SelectionStart = 0;
            this.fantasyNameTextBox.ShortcutsEnabled = true;
            this.fantasyNameTextBox.Size = new System.Drawing.Size(222, 23);
            this.fantasyNameTextBox.TabIndex = 1;
            this.fantasyNameTextBox.UseSelectable = true;
            this.fantasyNameTextBox.WaterMark = "Ingrese el nombre de fantasía";
            this.fantasyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fantasyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(388, 121);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Dirección General";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 121);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(104, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Dirección Exacta";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(388, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Correo Electrónico";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(388, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Teléfono";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(388, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Página Web";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Cédula Jurídica";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(150, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Nombre de la Sociedad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre de Fantasía";
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.DisplayIcon = true;
            this.searchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(683, 266);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Ingrese el negocio a buscar";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.ShowButton = true;
            this.searchTextBox.Size = new System.Drawing.Size(265, 23);
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Ingrese el negocio a buscar";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.searchTextBox_ButtonClick);
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // businessGridView
            // 
            this.businessGridView.AllowUserToAddRows = false;
            this.businessGridView.AllowUserToDeleteRows = false;
            this.businessGridView.AllowUserToResizeRows = false;
            this.businessGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.businessGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.businessGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.businessGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.businessGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.businessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.businessGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.businessGridView.EnableHeadersVisualStyles = false;
            this.businessGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.businessGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.businessGridView.Location = new System.Drawing.Point(3, 295);
            this.businessGridView.Name = "businessGridView";
            this.businessGridView.ReadOnly = true;
            this.businessGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.businessGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.businessGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.businessGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessGridView.Size = new System.Drawing.Size(945, 289);
            this.businessGridView.TabIndex = 15;
            this.businessGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessGridView_CellClick);
            // 
            // UCBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.businessGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCBusiness";
            this.Size = new System.Drawing.Size(951, 587);
            this.Load += new System.EventHandler(this.UCBusiness_Load);
            this.Leave += new System.EventHandler(this.UCBusiness_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox generalDirectionTextBox;
        private MetroFramework.Controls.MetroTextBox exactDirectionTextBox;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox juridicIdTextBox;
        private MetroFramework.Controls.MetroTextBox telephoneTextBox;
        private MetroFramework.Controls.MetroTextBox webPageTextBox;
        private MetroFramework.Controls.MetroTextBox societyNameTextBox;
        private MetroFramework.Controls.MetroTextBox fantasyNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroButton selectLogoButton;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroGrid businessGridView;
        private MetroFramework.Controls.MetroLink rotateRightLink;
        private MetroFramework.Controls.MetroLink rotateLeftLink;
        private MetroFramework.Controls.MetroLabel businessIdLabel;
    }
}
