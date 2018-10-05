namespace UI.Forms
{
    partial class FrmUser
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.userTabPage = new MetroFramework.Controls.MetroTabPage();
            this.rolesTile = new MetroFramework.Controls.MetroTile();
            this.changePasswordTile = new MetroFramework.Controls.MetroTile();
            this.passwordTabPage = new MetroFramework.Controls.MetroTabPage();
            this.goBackButton1 = new MetroFramework.Controls.MetroButton();
            this.changePasswordButton = new MetroFramework.Controls.MetroButton();
            this.oldPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.validatePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rolesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goBackButton2 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.businessCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.categoriesAndSubcategoriesCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.invoiceSaleCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.productsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.employeesCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.positionsAndSalariesCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.clientsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.brandsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControl1.SuspendLayout();
            this.userTabPage.SuspendLayout();
            this.passwordTabPage.SuspendLayout();
            this.rolesTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.userTabPage);
            this.metroTabControl1.Controls.Add(this.passwordTabPage);
            this.metroTabControl1.Controls.Add(this.rolesTabPage);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(331, 369);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // userTabPage
            // 
            this.userTabPage.Controls.Add(this.rolesTile);
            this.userTabPage.Controls.Add(this.changePasswordTile);
            this.userTabPage.HorizontalScrollbarBarColor = true;
            this.userTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.userTabPage.HorizontalScrollbarSize = 10;
            this.userTabPage.Location = new System.Drawing.Point(4, 38);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Size = new System.Drawing.Size(323, 327);
            this.userTabPage.TabIndex = 0;
            this.userTabPage.Text = "User";
            this.userTabPage.VerticalScrollbarBarColor = true;
            this.userTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.userTabPage.VerticalScrollbarSize = 10;
            // 
            // rolesTile
            // 
            this.rolesTile.ActiveControl = null;
            this.rolesTile.Location = new System.Drawing.Point(73, 141);
            this.rolesTile.Name = "rolesTile";
            this.rolesTile.Size = new System.Drawing.Size(176, 109);
            this.rolesTile.TabIndex = 2;
            this.rolesTile.Text = "Permisos";
            this.rolesTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rolesTile.TileImage = global::UI.Properties.Resources.Todo_List_56px;
            this.rolesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rolesTile.UseSelectable = true;
            this.rolesTile.UseTileImage = true;
            this.rolesTile.Click += new System.EventHandler(this.rolesTile_Click);
            // 
            // changePasswordTile
            // 
            this.changePasswordTile.ActiveControl = null;
            this.changePasswordTile.Location = new System.Drawing.Point(73, 26);
            this.changePasswordTile.Name = "changePasswordTile";
            this.changePasswordTile.Size = new System.Drawing.Size(176, 109);
            this.changePasswordTile.TabIndex = 3;
            this.changePasswordTile.Text = "Cambiar contraseña";
            this.changePasswordTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.changePasswordTile.TileImage = global::UI.Properties.Resources.Password_Reset_56px;
            this.changePasswordTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePasswordTile.UseSelectable = true;
            this.changePasswordTile.UseTileImage = true;
            this.changePasswordTile.Click += new System.EventHandler(this.changePasswordTile_Click);
            // 
            // passwordTabPage
            // 
            this.passwordTabPage.Controls.Add(this.goBackButton1);
            this.passwordTabPage.Controls.Add(this.changePasswordButton);
            this.passwordTabPage.Controls.Add(this.oldPasswordTextBox);
            this.passwordTabPage.Controls.Add(this.newPasswordTextBox);
            this.passwordTabPage.Controls.Add(this.validatePasswordTextBox);
            this.passwordTabPage.Controls.Add(this.metroLabel3);
            this.passwordTabPage.Controls.Add(this.metroLabel2);
            this.passwordTabPage.Controls.Add(this.metroLabel1);
            this.passwordTabPage.HorizontalScrollbarBarColor = true;
            this.passwordTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.passwordTabPage.HorizontalScrollbarSize = 10;
            this.passwordTabPage.Location = new System.Drawing.Point(4, 38);
            this.passwordTabPage.Name = "passwordTabPage";
            this.passwordTabPage.Size = new System.Drawing.Size(323, 327);
            this.passwordTabPage.TabIndex = 1;
            this.passwordTabPage.Text = "Password";
            this.passwordTabPage.VerticalScrollbarBarColor = true;
            this.passwordTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.passwordTabPage.VerticalScrollbarSize = 10;
            // 
            // goBackButton1
            // 
            this.goBackButton1.Location = new System.Drawing.Point(245, 301);
            this.goBackButton1.Name = "goBackButton1";
            this.goBackButton1.Size = new System.Drawing.Size(75, 23);
            this.goBackButton1.TabIndex = 10;
            this.goBackButton1.Text = "Volver";
            this.goBackButton1.UseSelectable = true;
            this.goBackButton1.Click += new System.EventHandler(this.goBackButton1_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(99, 233);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(121, 23);
            this.changePasswordButton.TabIndex = 9;
            this.changePasswordButton.Text = "Cambiar contraseña";
            this.changePasswordButton.UseSelectable = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // oldPasswordTextBox
            // 
            // 
            // 
            // 
            this.oldPasswordTextBox.CustomButton.Image = null;
            this.oldPasswordTextBox.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.oldPasswordTextBox.CustomButton.Name = "";
            this.oldPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oldPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldPasswordTextBox.CustomButton.TabIndex = 1;
            this.oldPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldPasswordTextBox.CustomButton.UseSelectable = true;
            this.oldPasswordTextBox.CustomButton.Visible = false;
            this.oldPasswordTextBox.DisplayIcon = true;
            this.oldPasswordTextBox.Icon = global::UI.Properties.Resources.Password_16px;
            this.oldPasswordTextBox.Lines = new string[0];
            this.oldPasswordTextBox.Location = new System.Drawing.Point(21, 63);
            this.oldPasswordTextBox.MaxLength = 32767;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.PromptText = "Ingrese su contraseña antigua";
            this.oldPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldPasswordTextBox.SelectedText = "";
            this.oldPasswordTextBox.SelectionLength = 0;
            this.oldPasswordTextBox.SelectionStart = 0;
            this.oldPasswordTextBox.ShortcutsEnabled = true;
            this.oldPasswordTextBox.Size = new System.Drawing.Size(287, 23);
            this.oldPasswordTextBox.TabIndex = 6;
            this.oldPasswordTextBox.UseSelectable = true;
            this.oldPasswordTextBox.WaterMark = "Ingrese su contraseña antigua";
            this.oldPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPasswordTextBox
            // 
            // 
            // 
            // 
            this.newPasswordTextBox.CustomButton.Image = null;
            this.newPasswordTextBox.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.newPasswordTextBox.CustomButton.Name = "";
            this.newPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newPasswordTextBox.CustomButton.TabIndex = 1;
            this.newPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newPasswordTextBox.CustomButton.UseSelectable = true;
            this.newPasswordTextBox.CustomButton.Visible = false;
            this.newPasswordTextBox.DisplayIcon = true;
            this.newPasswordTextBox.Icon = global::UI.Properties.Resources.Password_16px;
            this.newPasswordTextBox.Lines = new string[0];
            this.newPasswordTextBox.Location = new System.Drawing.Point(21, 129);
            this.newPasswordTextBox.MaxLength = 32767;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.PromptText = "Ingrese su nueva contraseña";
            this.newPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.SelectionLength = 0;
            this.newPasswordTextBox.SelectionStart = 0;
            this.newPasswordTextBox.ShortcutsEnabled = true;
            this.newPasswordTextBox.Size = new System.Drawing.Size(287, 23);
            this.newPasswordTextBox.TabIndex = 7;
            this.newPasswordTextBox.UseSelectable = true;
            this.newPasswordTextBox.WaterMark = "Ingrese su nueva contraseña";
            this.newPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // validatePasswordTextBox
            // 
            // 
            // 
            // 
            this.validatePasswordTextBox.CustomButton.Image = null;
            this.validatePasswordTextBox.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.validatePasswordTextBox.CustomButton.Name = "";
            this.validatePasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.validatePasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.validatePasswordTextBox.CustomButton.TabIndex = 1;
            this.validatePasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.validatePasswordTextBox.CustomButton.UseSelectable = true;
            this.validatePasswordTextBox.CustomButton.Visible = false;
            this.validatePasswordTextBox.DisplayIcon = true;
            this.validatePasswordTextBox.Icon = global::UI.Properties.Resources.Password_16px;
            this.validatePasswordTextBox.Lines = new string[0];
            this.validatePasswordTextBox.Location = new System.Drawing.Point(21, 190);
            this.validatePasswordTextBox.MaxLength = 32767;
            this.validatePasswordTextBox.Name = "validatePasswordTextBox";
            this.validatePasswordTextBox.PasswordChar = '*';
            this.validatePasswordTextBox.PromptText = "Confirme su contraseña";
            this.validatePasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.validatePasswordTextBox.SelectedText = "";
            this.validatePasswordTextBox.SelectionLength = 0;
            this.validatePasswordTextBox.SelectionStart = 0;
            this.validatePasswordTextBox.ShortcutsEnabled = true;
            this.validatePasswordTextBox.Size = new System.Drawing.Size(287, 23);
            this.validatePasswordTextBox.TabIndex = 8;
            this.validatePasswordTextBox.UseSelectable = true;
            this.validatePasswordTextBox.WaterMark = "Confirme su contraseña";
            this.validatePasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.validatePasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(126, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Verificar Contraseña";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Contraseña Nueva";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Contraseña Antigua";
            // 
            // rolesTabPage
            // 
            this.rolesTabPage.Controls.Add(this.groupBox1);
            this.rolesTabPage.HorizontalScrollbarBarColor = true;
            this.rolesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.rolesTabPage.HorizontalScrollbarSize = 10;
            this.rolesTabPage.Location = new System.Drawing.Point(4, 38);
            this.rolesTabPage.Name = "rolesTabPage";
            this.rolesTabPage.Size = new System.Drawing.Size(323, 327);
            this.rolesTabPage.TabIndex = 2;
            this.rolesTabPage.Text = "Roles";
            this.rolesTabPage.VerticalScrollbarBarColor = true;
            this.rolesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.rolesTabPage.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.businessCheckBox);
            this.groupBox1.Controls.Add(this.categoriesAndSubcategoriesCheckBox);
            this.groupBox1.Controls.Add(this.invoiceSaleCheckBox);
            this.groupBox1.Controls.Add(this.productsCheckBox);
            this.groupBox1.Controls.Add(this.employeesCheckBox);
            this.groupBox1.Controls.Add(this.positionsAndSalariesCheckBox);
            this.groupBox1.Controls.Add(this.clientsCheckBox);
            this.groupBox1.Controls.Add(this.brandsCheckBox);
            this.groupBox1.Controls.Add(this.goBackButton2);
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 286);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // goBackButton2
            // 
            this.goBackButton2.Location = new System.Drawing.Point(239, 257);
            this.goBackButton2.Name = "goBackButton2";
            this.goBackButton2.Size = new System.Drawing.Size(75, 23);
            this.goBackButton2.TabIndex = 11;
            this.goBackButton2.Text = "Volver";
            this.goBackButton2.UseSelectable = true;
            this.goBackButton2.Click += new System.EventHandler(this.goBackButton2_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 54);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(331, 57);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(296, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(28, 25);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(3, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "metroLabel4";
            // 
            // businessCheckBox
            // 
            this.businessCheckBox.AutoSize = true;
            this.businessCheckBox.Enabled = false;
            this.businessCheckBox.Location = new System.Drawing.Point(217, 36);
            this.businessCheckBox.Name = "businessCheckBox";
            this.businessCheckBox.Size = new System.Drawing.Size(73, 15);
            this.businessCheckBox.TabIndex = 12;
            this.businessCheckBox.Text = "Negocios";
            this.businessCheckBox.UseSelectable = true;
            // 
            // categoriesAndSubcategoriesCheckBox
            // 
            this.categoriesAndSubcategoriesCheckBox.AutoSize = true;
            this.categoriesAndSubcategoriesCheckBox.Enabled = false;
            this.categoriesAndSubcategoriesCheckBox.Location = new System.Drawing.Point(23, 134);
            this.categoriesAndSubcategoriesCheckBox.Name = "categoriesAndSubcategoriesCheckBox";
            this.categoriesAndSubcategoriesCheckBox.Size = new System.Drawing.Size(167, 15);
            this.categoriesAndSubcategoriesCheckBox.TabIndex = 13;
            this.categoriesAndSubcategoriesCheckBox.Text = "Categorías y SubCategorías";
            this.categoriesAndSubcategoriesCheckBox.UseSelectable = true;
            // 
            // invoiceSaleCheckBox
            // 
            this.invoiceSaleCheckBox.AutoSize = true;
            this.invoiceSaleCheckBox.Enabled = false;
            this.invoiceSaleCheckBox.Location = new System.Drawing.Point(23, 169);
            this.invoiceSaleCheckBox.Name = "invoiceSaleCheckBox";
            this.invoiceSaleCheckBox.Size = new System.Drawing.Size(120, 15);
            this.invoiceSaleCheckBox.TabIndex = 14;
            this.invoiceSaleCheckBox.Text = "Facturas de Ventas";
            this.invoiceSaleCheckBox.UseSelectable = true;
            // 
            // productsCheckBox
            // 
            this.productsCheckBox.AutoSize = true;
            this.productsCheckBox.Enabled = false;
            this.productsCheckBox.Location = new System.Drawing.Point(217, 71);
            this.productsCheckBox.Name = "productsCheckBox";
            this.productsCheckBox.Size = new System.Drawing.Size(77, 15);
            this.productsCheckBox.TabIndex = 15;
            this.productsCheckBox.Text = "Productos";
            this.productsCheckBox.UseSelectable = true;
            // 
            // employeesCheckBox
            // 
            this.employeesCheckBox.AutoSize = true;
            this.employeesCheckBox.Enabled = false;
            this.employeesCheckBox.Location = new System.Drawing.Point(217, 103);
            this.employeesCheckBox.Name = "employeesCheckBox";
            this.employeesCheckBox.Size = new System.Drawing.Size(81, 15);
            this.employeesCheckBox.TabIndex = 16;
            this.employeesCheckBox.Text = "Empleados";
            this.employeesCheckBox.UseSelectable = true;
            // 
            // positionsAndSalariesCheckBox
            // 
            this.positionsAndSalariesCheckBox.AutoSize = true;
            this.positionsAndSalariesCheckBox.Enabled = false;
            this.positionsAndSalariesCheckBox.Location = new System.Drawing.Point(23, 103);
            this.positionsAndSalariesCheckBox.Name = "positionsAndSalariesCheckBox";
            this.positionsAndSalariesCheckBox.Size = new System.Drawing.Size(131, 15);
            this.positionsAndSalariesCheckBox.TabIndex = 17;
            this.positionsAndSalariesCheckBox.Text = "Posiciones y Salarios";
            this.positionsAndSalariesCheckBox.UseSelectable = true;
            // 
            // clientsCheckBox
            // 
            this.clientsCheckBox.AutoSize = true;
            this.clientsCheckBox.Enabled = false;
            this.clientsCheckBox.Location = new System.Drawing.Point(23, 71);
            this.clientsCheckBox.Name = "clientsCheckBox";
            this.clientsCheckBox.Size = new System.Drawing.Size(65, 15);
            this.clientsCheckBox.TabIndex = 18;
            this.clientsCheckBox.Text = "Clientes";
            this.clientsCheckBox.UseSelectable = true;
            // 
            // brandsCheckBox
            // 
            this.brandsCheckBox.AutoSize = true;
            this.brandsCheckBox.Enabled = false;
            this.brandsCheckBox.Location = new System.Drawing.Point(23, 36);
            this.brandsCheckBox.Name = "brandsCheckBox";
            this.brandsCheckBox.Size = new System.Drawing.Size(61, 15);
            this.brandsCheckBox.TabIndex = 19;
            this.brandsCheckBox.Text = "Marcas";
            this.brandsCheckBox.UseSelectable = true;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 436);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.metroTabControl1.ResumeLayout(false);
            this.userTabPage.ResumeLayout(false);
            this.passwordTabPage.ResumeLayout(false);
            this.passwordTabPage.PerformLayout();
            this.rolesTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage userTabPage;
        private MetroFramework.Controls.MetroTabPage passwordTabPage;
        private MetroFramework.Controls.MetroTabPage rolesTabPage;
        private MetroFramework.Controls.MetroTile rolesTile;
        private MetroFramework.Controls.MetroTile changePasswordTile;
        private MetroFramework.Controls.MetroButton changePasswordButton;
        private MetroFramework.Controls.MetroTextBox oldPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox newPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox validatePasswordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton goBackButton1;
        private MetroFramework.Controls.MetroButton goBackButton2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox businessCheckBox;
        private MetroFramework.Controls.MetroCheckBox categoriesAndSubcategoriesCheckBox;
        private MetroFramework.Controls.MetroCheckBox invoiceSaleCheckBox;
        private MetroFramework.Controls.MetroCheckBox productsCheckBox;
        private MetroFramework.Controls.MetroCheckBox employeesCheckBox;
        private MetroFramework.Controls.MetroCheckBox positionsAndSalariesCheckBox;
        private MetroFramework.Controls.MetroCheckBox clientsCheckBox;
        private MetroFramework.Controls.MetroCheckBox brandsCheckBox;
    }
}