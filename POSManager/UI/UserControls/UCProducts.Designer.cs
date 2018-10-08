namespace UI.UserControls
{
    partial class UCProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.subCategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.brandComboBox = new MetroFramework.Controls.MetroComboBox();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.photoButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.priceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.estableQuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.inputQuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StyleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.gravadoCheckBox = new MetroFramework.Controls.MetroRadioButton();
            this.exentoCheckBox = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.searchTextBox.Location = new System.Drawing.Point(683, 278);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Ingrese el producto a buscar";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.ShowButton = true;
            this.searchTextBox.Size = new System.Drawing.Size(265, 23);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Ingrese el producto a buscar";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.exentoCheckBox);
            this.groupBox1.Controls.Add(this.gravadoCheckBox);
            this.groupBox1.Controls.Add(this.metroLink2);
            this.groupBox1.Controls.Add(this.metroLink1);
            this.groupBox1.Controls.Add(this.subCategoryComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.brandComboBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.photoButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.estableQuantityTextBox);
            this.groupBox1.Controls.Add(this.inputQuantityTextBox);
            this.groupBox1.Controls.Add(this.StyleTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 269);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de los Negocios";
            // 
            // metroLink2
            // 
            this.metroLink2.Image = global::UI.Properties.Resources.Rotate_Right_16px1;
            this.metroLink2.Location = new System.Drawing.Point(896, 228);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(26, 23);
            this.metroLink2.TabIndex = 17;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::UI.Properties.Resources.Rotate_Left_16px1;
            this.metroLink1.Location = new System.Drawing.Point(761, 228);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(26, 23);
            this.metroLink1.TabIndex = 18;
            this.metroLink1.UseSelectable = true;
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.ItemHeight = 23;
            this.subCategoryComboBox.Location = new System.Drawing.Point(160, 160);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(222, 29);
            this.subCategoryComboBox.TabIndex = 14;
            this.subCategoryComboBox.UseSelectable = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.ItemHeight = 23;
            this.categoryComboBox.Location = new System.Drawing.Point(160, 125);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(222, 29);
            this.categoryComboBox.TabIndex = 14;
            this.categoryComboBox.UseSelectable = true;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.ItemHeight = 23;
            this.brandComboBox.Location = new System.Drawing.Point(160, 90);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(222, 29);
            this.brandComboBox.TabIndex = 14;
            this.brandComboBox.UseSelectable = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(249, 240);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 240);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(87, 240);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 240);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(793, 228);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(97, 23);
            this.photoButton.TabIndex = 13;
            this.photoButton.Text = "Seleccionar Foto";
            this.photoButton.UseSelectable = true;
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
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.DisplayIcon = true;
            this.descriptionTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(524, 125);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.PromptText = "Ingrese la descripción del producto";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(204, 89);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMark = "Ingrese la descripción del producto";
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.CustomButton.Image = null;
            this.priceTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.priceTextBox.CustomButton.Name = "";
            this.priceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.priceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceTextBox.CustomButton.TabIndex = 1;
            this.priceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceTextBox.CustomButton.UseSelectable = true;
            this.priceTextBox.CustomButton.Visible = false;
            this.priceTextBox.DisplayIcon = true;
            this.priceTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.priceTextBox.Lines = new string[0];
            this.priceTextBox.Location = new System.Drawing.Point(524, 90);
            this.priceTextBox.MaxLength = 32767;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PromptText = "Ingrese el precio por unidad";
            this.priceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.SelectionLength = 0;
            this.priceTextBox.SelectionStart = 0;
            this.priceTextBox.ShortcutsEnabled = true;
            this.priceTextBox.Size = new System.Drawing.Size(204, 23);
            this.priceTextBox.TabIndex = 7;
            this.priceTextBox.UseSelectable = true;
            this.priceTextBox.WaterMark = "Ingrese el precio por unidad";
            this.priceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // estableQuantityTextBox
            // 
            // 
            // 
            // 
            this.estableQuantityTextBox.CustomButton.Image = null;
            this.estableQuantityTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.estableQuantityTextBox.CustomButton.Name = "";
            this.estableQuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.estableQuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.estableQuantityTextBox.CustomButton.TabIndex = 1;
            this.estableQuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.estableQuantityTextBox.CustomButton.UseSelectable = true;
            this.estableQuantityTextBox.CustomButton.Visible = false;
            this.estableQuantityTextBox.DisplayIcon = true;
            this.estableQuantityTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.estableQuantityTextBox.Lines = new string[0];
            this.estableQuantityTextBox.Location = new System.Drawing.Point(524, 60);
            this.estableQuantityTextBox.MaxLength = 32767;
            this.estableQuantityTextBox.Name = "estableQuantityTextBox";
            this.estableQuantityTextBox.PasswordChar = '\0';
            this.estableQuantityTextBox.PromptText = "Ingrese la cantidad fija";
            this.estableQuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.estableQuantityTextBox.SelectedText = "";
            this.estableQuantityTextBox.SelectionLength = 0;
            this.estableQuantityTextBox.SelectionStart = 0;
            this.estableQuantityTextBox.ShortcutsEnabled = true;
            this.estableQuantityTextBox.Size = new System.Drawing.Size(204, 23);
            this.estableQuantityTextBox.TabIndex = 6;
            this.estableQuantityTextBox.UseSelectable = true;
            this.estableQuantityTextBox.WaterMark = "Ingrese la cantidad fija";
            this.estableQuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estableQuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // inputQuantityTextBox
            // 
            // 
            // 
            // 
            this.inputQuantityTextBox.CustomButton.Image = null;
            this.inputQuantityTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.inputQuantityTextBox.CustomButton.Name = "";
            this.inputQuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputQuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputQuantityTextBox.CustomButton.TabIndex = 1;
            this.inputQuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputQuantityTextBox.CustomButton.UseSelectable = true;
            this.inputQuantityTextBox.CustomButton.Visible = false;
            this.inputQuantityTextBox.DisplayIcon = true;
            this.inputQuantityTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.inputQuantityTextBox.Lines = new string[0];
            this.inputQuantityTextBox.Location = new System.Drawing.Point(524, 28);
            this.inputQuantityTextBox.MaxLength = 32767;
            this.inputQuantityTextBox.Name = "inputQuantityTextBox";
            this.inputQuantityTextBox.PasswordChar = '\0';
            this.inputQuantityTextBox.PromptText = "Ingrese la cantidad de entrada";
            this.inputQuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputQuantityTextBox.SelectedText = "";
            this.inputQuantityTextBox.SelectionLength = 0;
            this.inputQuantityTextBox.SelectionStart = 0;
            this.inputQuantityTextBox.ShortcutsEnabled = true;
            this.inputQuantityTextBox.Size = new System.Drawing.Size(204, 23);
            this.inputQuantityTextBox.TabIndex = 5;
            this.inputQuantityTextBox.UseSelectable = true;
            this.inputQuantityTextBox.WaterMark = "Ingrese la cantidad de entrada";
            this.inputQuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputQuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StyleTextBox
            // 
            // 
            // 
            // 
            this.StyleTextBox.CustomButton.Image = null;
            this.StyleTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.StyleTextBox.CustomButton.Name = "";
            this.StyleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StyleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StyleTextBox.CustomButton.TabIndex = 1;
            this.StyleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StyleTextBox.CustomButton.UseSelectable = true;
            this.StyleTextBox.CustomButton.Visible = false;
            this.StyleTextBox.DisplayIcon = true;
            this.StyleTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.StyleTextBox.Lines = new string[0];
            this.StyleTextBox.Location = new System.Drawing.Point(160, 60);
            this.StyleTextBox.MaxLength = 32767;
            this.StyleTextBox.Name = "StyleTextBox";
            this.StyleTextBox.PasswordChar = '\0';
            this.StyleTextBox.PromptText = "Ingrese el nombre de la sociedad";
            this.StyleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StyleTextBox.SelectedText = "";
            this.StyleTextBox.SelectionLength = 0;
            this.StyleTextBox.SelectionStart = 0;
            this.StyleTextBox.ShortcutsEnabled = true;
            this.StyleTextBox.Size = new System.Drawing.Size(222, 23);
            this.StyleTextBox.TabIndex = 2;
            this.StyleTextBox.UseSelectable = true;
            this.StyleTextBox.WaterMark = "Ingrese el nombre de la sociedad";
            this.StyleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StyleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
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
            this.codeTextBox.Location = new System.Drawing.Point(160, 28);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.PromptText = "Ingrese el nombre de fantasía";
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(222, 23);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMark = "Ingrese el nombre de fantasía";
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(388, 125);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(76, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Descripción";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 160);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "SubCategoría";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(67, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Categoría";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(388, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Precio por Unidad";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(388, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Cantidad Fija";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(388, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Cantidad de Entrada";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Marca";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Estilo";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Código";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 307);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(945, 274);
            this.metroGrid1.TabIndex = 17;
            // 
            // gravadoCheckBox
            // 
            this.gravadoCheckBox.AutoSize = true;
            this.gravadoCheckBox.Location = new System.Drawing.Point(160, 207);
            this.gravadoCheckBox.Name = "gravadoCheckBox";
            this.gravadoCheckBox.Size = new System.Drawing.Size(67, 15);
            this.gravadoCheckBox.TabIndex = 19;
            this.gravadoCheckBox.Text = "Gravado";
            this.gravadoCheckBox.UseSelectable = true;
            // 
            // exentoCheckBox
            // 
            this.exentoCheckBox.AutoSize = true;
            this.exentoCheckBox.Location = new System.Drawing.Point(233, 207);
            this.exentoCheckBox.Name = "exentoCheckBox";
            this.exentoCheckBox.Size = new System.Drawing.Size(58, 15);
            this.exentoCheckBox.TabIndex = 19;
            this.exentoCheckBox.Text = "Exento";
            this.exentoCheckBox.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 207);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(112, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Tipo de Impuesto";
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(951, 584);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroButton photoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox priceTextBox;
        private MetroFramework.Controls.MetroTextBox estableQuantityTextBox;
        private MetroFramework.Controls.MetroTextBox inputQuantityTextBox;
        private MetroFramework.Controls.MetroTextBox StyleTextBox;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox subCategoryComboBox;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private MetroFramework.Controls.MetroComboBox brandComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroRadioButton exentoCheckBox;
        private MetroFramework.Controls.MetroRadioButton gravadoCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}
