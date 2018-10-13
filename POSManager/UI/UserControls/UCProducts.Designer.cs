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
            this.exentoCheckBox = new MetroFramework.Controls.MetroRadioButton();
            this.gravadoCheckBox = new MetroFramework.Controls.MetroRadioButton();
            this.rotateRightLink = new MetroFramework.Controls.MetroLink();
            this.rotateLeftLink = new MetroFramework.Controls.MetroLink();
            this.subCategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.brandComboBox = new MetroFramework.Controls.MetroComboBox();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.photoButton = new MetroFramework.Controls.MetroButton();
            this.ImgpictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.priceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.estableQuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.variableQuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StyleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.productmetroGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lowerDiscountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lowerPorcentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productmetroGrid)).BeginInit();
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
            this.groupBox1.Controls.Add(this.rotateRightLink);
            this.groupBox1.Controls.Add(this.rotateLeftLink);
            this.groupBox1.Controls.Add(this.subCategoryComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.brandComboBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.photoButton);
            this.groupBox1.Controls.Add(this.ImgpictureBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.lowerPorcentTextBox);
            this.groupBox1.Controls.Add(this.lowerDiscountTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.estableQuantityTextBox);
            this.groupBox1.Controls.Add(this.variableQuantityTextBox);
            this.groupBox1.Controls.Add(this.StyleTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel9);
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
            this.groupBox1.Size = new System.Drawing.Size(945, 269);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de los Negocios";
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
            // gravadoCheckBox
            // 
            this.gravadoCheckBox.AutoSize = true;
            this.gravadoCheckBox.Checked = true;
            this.gravadoCheckBox.Location = new System.Drawing.Point(160, 207);
            this.gravadoCheckBox.Name = "gravadoCheckBox";
            this.gravadoCheckBox.Size = new System.Drawing.Size(67, 15);
            this.gravadoCheckBox.TabIndex = 19;
            this.gravadoCheckBox.TabStop = true;
            this.gravadoCheckBox.Text = "Gravado";
            this.gravadoCheckBox.UseSelectable = true;
            // 
            // rotateRightLink
            // 
            this.rotateRightLink.Image = global::UI.Properties.Resources.Rotate_Right_16px1;
            this.rotateRightLink.Location = new System.Drawing.Point(896, 228);
            this.rotateRightLink.Name = "rotateRightLink";
            this.rotateRightLink.Size = new System.Drawing.Size(26, 23);
            this.rotateRightLink.TabIndex = 17;
            this.rotateRightLink.UseSelectable = true;
            this.rotateRightLink.Click += new System.EventHandler(this.rotateRightLink_Click);
            // 
            // rotateLeftLink
            // 
            this.rotateLeftLink.Image = global::UI.Properties.Resources.Rotate_Left_16px1;
            this.rotateLeftLink.Location = new System.Drawing.Point(761, 228);
            this.rotateLeftLink.Name = "rotateLeftLink";
            this.rotateLeftLink.Size = new System.Drawing.Size(26, 23);
            this.rotateLeftLink.TabIndex = 18;
            this.rotateLeftLink.UseSelectable = true;
            this.rotateLeftLink.Click += new System.EventHandler(this.rotateLeftLink_Click);
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
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // ImgpictureBox
            // 
            this.ImgpictureBox.Image = global::UI.Properties.Resources.Empty;
            this.ImgpictureBox.Location = new System.Drawing.Point(734, 19);
            this.ImgpictureBox.Name = "ImgpictureBox";
            this.ImgpictureBox.Size = new System.Drawing.Size(205, 203);
            this.ImgpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgpictureBox.TabIndex = 2;
            this.ImgpictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.DisplayIcon = true;
            this.descriptionTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(524, 177);
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
            this.descriptionTextBox.Size = new System.Drawing.Size(204, 74);
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
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // variableQuantityTextBox
            // 
            // 
            // 
            // 
            this.variableQuantityTextBox.CustomButton.Image = null;
            this.variableQuantityTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.variableQuantityTextBox.CustomButton.Name = "";
            this.variableQuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.variableQuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.variableQuantityTextBox.CustomButton.TabIndex = 1;
            this.variableQuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.variableQuantityTextBox.CustomButton.UseSelectable = true;
            this.variableQuantityTextBox.CustomButton.Visible = false;
            this.variableQuantityTextBox.DisplayIcon = true;
            this.variableQuantityTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.variableQuantityTextBox.Lines = new string[0];
            this.variableQuantityTextBox.Location = new System.Drawing.Point(524, 28);
            this.variableQuantityTextBox.MaxLength = 32767;
            this.variableQuantityTextBox.Name = "variableQuantityTextBox";
            this.variableQuantityTextBox.PasswordChar = '\0';
            this.variableQuantityTextBox.PromptText = "Ingrese la cantidad de entrada";
            this.variableQuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variableQuantityTextBox.SelectedText = "";
            this.variableQuantityTextBox.SelectionLength = 0;
            this.variableQuantityTextBox.SelectionStart = 0;
            this.variableQuantityTextBox.ShortcutsEnabled = true;
            this.variableQuantityTextBox.Size = new System.Drawing.Size(204, 23);
            this.variableQuantityTextBox.TabIndex = 5;
            this.variableQuantityTextBox.UseSelectable = true;
            this.variableQuantityTextBox.WaterMark = "Ingrese la cantidad de entrada";
            this.variableQuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.variableQuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroLabel10.Location = new System.Drawing.Point(388, 177);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(76, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Descripción";
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
            // productmetroGrid
            // 
            this.productmetroGrid.AllowUserToAddRows = false;
            this.productmetroGrid.AllowUserToDeleteRows = false;
            this.productmetroGrid.AllowUserToResizeRows = false;
            this.productmetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productmetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productmetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productmetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productmetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productmetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productmetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.productmetroGrid.EnableHeadersVisualStyles = false;
            this.productmetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productmetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productmetroGrid.Location = new System.Drawing.Point(3, 307);
            this.productmetroGrid.Name = "productmetroGrid";
            this.productmetroGrid.ReadOnly = true;
            this.productmetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productmetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productmetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productmetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productmetroGrid.Size = new System.Drawing.Size(945, 274);
            this.productmetroGrid.TabIndex = 17;
            this.productmetroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productmetroGrid_CellClick);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(388, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(118, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Descuento Minimo";
            // 
            // lowerDiscountTextBox
            // 
            // 
            // 
            // 
            this.lowerDiscountTextBox.CustomButton.Image = null;
            this.lowerDiscountTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.lowerDiscountTextBox.CustomButton.Name = "";
            this.lowerDiscountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lowerDiscountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lowerDiscountTextBox.CustomButton.TabIndex = 1;
            this.lowerDiscountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lowerDiscountTextBox.CustomButton.UseSelectable = true;
            this.lowerDiscountTextBox.CustomButton.Visible = false;
            this.lowerDiscountTextBox.DisplayIcon = true;
            this.lowerDiscountTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.lowerDiscountTextBox.Lines = new string[0];
            this.lowerDiscountTextBox.Location = new System.Drawing.Point(524, 119);
            this.lowerDiscountTextBox.MaxLength = 32767;
            this.lowerDiscountTextBox.Name = "lowerDiscountTextBox";
            this.lowerDiscountTextBox.PasswordChar = '\0';
            this.lowerDiscountTextBox.PromptText = "Cantidad de descuento";
            this.lowerDiscountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lowerDiscountTextBox.SelectedText = "";
            this.lowerDiscountTextBox.SelectionLength = 0;
            this.lowerDiscountTextBox.SelectionStart = 0;
            this.lowerDiscountTextBox.ShortcutsEnabled = true;
            this.lowerDiscountTextBox.Size = new System.Drawing.Size(204, 23);
            this.lowerDiscountTextBox.TabIndex = 7;
            this.lowerDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lowerDiscountTextBox.UseSelectable = true;
            this.lowerDiscountTextBox.WaterMark = "Cantidad de descuento";
            this.lowerDiscountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lowerDiscountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lowerDiscountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lowerDiscountTextBox_KeyUp);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(388, 148);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(119, 19);
            this.metroLabel12.TabIndex = 0;
            this.metroLabel12.Text = "Porcentaje Minimo";
            // 
            // lowerPorcentTextBox
            // 
            // 
            // 
            // 
            this.lowerPorcentTextBox.CustomButton.Image = null;
            this.lowerPorcentTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.lowerPorcentTextBox.CustomButton.Name = "";
            this.lowerPorcentTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lowerPorcentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lowerPorcentTextBox.CustomButton.TabIndex = 1;
            this.lowerPorcentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lowerPorcentTextBox.CustomButton.UseSelectable = true;
            this.lowerPorcentTextBox.CustomButton.Visible = false;
            this.lowerPorcentTextBox.DisplayIcon = true;
            this.lowerPorcentTextBox.Enabled = false;
            this.lowerPorcentTextBox.Icon = global::UI.Properties.Resources.Paper_Money_16px;
            this.lowerPorcentTextBox.Lines = new string[0];
            this.lowerPorcentTextBox.Location = new System.Drawing.Point(524, 148);
            this.lowerPorcentTextBox.MaxLength = 32767;
            this.lowerPorcentTextBox.Name = "lowerPorcentTextBox";
            this.lowerPorcentTextBox.PasswordChar = '\0';
            this.lowerPorcentTextBox.PromptText = "Porcentaje Minimo";
            this.lowerPorcentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lowerPorcentTextBox.SelectedText = "";
            this.lowerPorcentTextBox.SelectionLength = 0;
            this.lowerPorcentTextBox.SelectionStart = 0;
            this.lowerPorcentTextBox.ShortcutsEnabled = true;
            this.lowerPorcentTextBox.Size = new System.Drawing.Size(204, 23);
            this.lowerPorcentTextBox.TabIndex = 7;
            this.lowerPorcentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lowerPorcentTextBox.UseSelectable = true;
            this.lowerPorcentTextBox.WaterMark = "Porcentaje Minimo";
            this.lowerPorcentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lowerPorcentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productmetroGrid);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(951, 584);
            this.Load += new System.EventHandler(this.UCProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productmetroGrid)).EndInit();
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
        private System.Windows.Forms.PictureBox ImgpictureBox;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox priceTextBox;
        private MetroFramework.Controls.MetroTextBox estableQuantityTextBox;
        private MetroFramework.Controls.MetroTextBox variableQuantityTextBox;
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
        private MetroFramework.Controls.MetroGrid productmetroGrid;
        private MetroFramework.Controls.MetroLink rotateRightLink;
        private MetroFramework.Controls.MetroLink rotateLeftLink;
        private MetroFramework.Controls.MetroRadioButton exentoCheckBox;
        private MetroFramework.Controls.MetroRadioButton gravadoCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox lowerDiscountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox lowerPorcentTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}
