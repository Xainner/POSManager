namespace UI.Forms
{
    partial class FrmCategoriesAndSubCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categorySearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.categoriesGridView = new MetroFramework.Controls.MetroGrid();
            this.deleteCategoryButton = new MetroFramework.Controls.MetroButton();
            this.updateCategoryButton = new MetroFramework.Controls.MetroButton();
            this.createCategoryButton = new MetroFramework.Controls.MetroButton();
            this.categoryNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.categoryIdLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.subCategorySearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.categoriesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.subCategoriesGridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.subCategoryIdLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteSubCategoryButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.updateSubCategoryButton = new MetroFramework.Controls.MetroButton();
            this.subCategoryNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.createSubCategoryButton = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categorySearchTextBox);
            this.groupBox1.Controls.Add(this.categoriesGridView);
            this.groupBox1.Controls.Add(this.deleteCategoryButton);
            this.groupBox1.Controls.Add(this.updateCategoryButton);
            this.groupBox1.Controls.Add(this.createCategoryButton);
            this.groupBox1.Controls.Add(this.categoryNameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.categoryIdLabel);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorías";
            // 
            // categorySearchTextBox
            // 
            // 
            // 
            // 
            this.categorySearchTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.categorySearchTextBox.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.categorySearchTextBox.CustomButton.Name = "";
            this.categorySearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.categorySearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categorySearchTextBox.CustomButton.TabIndex = 1;
            this.categorySearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categorySearchTextBox.CustomButton.UseSelectable = true;
            this.categorySearchTextBox.DisplayIcon = true;
            this.categorySearchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.categorySearchTextBox.Lines = new string[0];
            this.categorySearchTextBox.Location = new System.Drawing.Point(134, 137);
            this.categorySearchTextBox.MaxLength = 32767;
            this.categorySearchTextBox.Name = "categorySearchTextBox";
            this.categorySearchTextBox.PasswordChar = '\0';
            this.categorySearchTextBox.PromptText = "Ingrese una categoría a buscar";
            this.categorySearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categorySearchTextBox.SelectedText = "";
            this.categorySearchTextBox.SelectionLength = 0;
            this.categorySearchTextBox.SelectionStart = 0;
            this.categorySearchTextBox.ShortcutsEnabled = true;
            this.categorySearchTextBox.ShowButton = true;
            this.categorySearchTextBox.ShowClearButton = true;
            this.categorySearchTextBox.Size = new System.Drawing.Size(228, 23);
            this.categorySearchTextBox.TabIndex = 2;
            this.categorySearchTextBox.UseSelectable = true;
            this.categorySearchTextBox.WaterMark = "Ingrese una categoría a buscar";
            this.categorySearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categorySearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.categorySearchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.categorySearchTextBox_ButtonClick);
            this.categorySearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.categorySearchTextBox_KeyUp);
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AllowUserToAddRows = false;
            this.categoriesGridView.AllowUserToDeleteRows = false;
            this.categoriesGridView.AllowUserToResizeRows = false;
            this.categoriesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.categoriesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.categoriesGridView.EnableHeadersVisualStyles = false;
            this.categoriesGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoriesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriesGridView.Location = new System.Drawing.Point(6, 166);
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.ReadOnly = true;
            this.categoriesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.categoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesGridView.Size = new System.Drawing.Size(356, 233);
            this.categoriesGridView.TabIndex = 3;
            this.categoriesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesGridView_CellClick);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(168, 99);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Eliminar";
            this.deleteCategoryButton.UseSelectable = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.Location = new System.Drawing.Point(87, 99);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.updateCategoryButton.TabIndex = 2;
            this.updateCategoryButton.Text = "Modificar";
            this.updateCategoryButton.UseSelectable = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.Location = new System.Drawing.Point(6, 99);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.createCategoryButton.TabIndex = 2;
            this.createCategoryButton.Text = "Agregar";
            this.createCategoryButton.UseSelectable = true;
            this.createCategoryButton.Click += new System.EventHandler(this.createCategoryButton_Click);
            // 
            // categoryNameTextBox
            // 
            // 
            // 
            // 
            this.categoryNameTextBox.CustomButton.Image = null;
            this.categoryNameTextBox.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.categoryNameTextBox.CustomButton.Name = "";
            this.categoryNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.categoryNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categoryNameTextBox.CustomButton.TabIndex = 1;
            this.categoryNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categoryNameTextBox.CustomButton.UseSelectable = true;
            this.categoryNameTextBox.CustomButton.Visible = false;
            this.categoryNameTextBox.DisplayIcon = true;
            this.categoryNameTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.categoryNameTextBox.Lines = new string[0];
            this.categoryNameTextBox.Location = new System.Drawing.Point(168, 60);
            this.categoryNameTextBox.MaxLength = 32767;
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.PasswordChar = '\0';
            this.categoryNameTextBox.PromptText = "Ingrese el nombre de la categoría";
            this.categoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categoryNameTextBox.SelectedText = "";
            this.categoryNameTextBox.SelectionLength = 0;
            this.categoryNameTextBox.SelectionStart = 0;
            this.categoryNameTextBox.ShortcutsEnabled = true;
            this.categoryNameTextBox.ShowClearButton = true;
            this.categoryNameTextBox.Size = new System.Drawing.Size(194, 23);
            this.categoryNameTextBox.TabIndex = 1;
            this.categoryNameTextBox.UseSelectable = true;
            this.categoryNameTextBox.WaterMark = "Ingrese el nombre de la categoría";
            this.categoryNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Nombre de la Categoría";
            // 
            // categoryIdLabel
            // 
            this.categoryIdLabel.AutoSize = true;
            this.categoryIdLabel.Location = new System.Drawing.Point(32, 26);
            this.categoryIdLabel.Name = "categoryIdLabel";
            this.categoryIdLabel.Size = new System.Drawing.Size(95, 19);
            this.categoryIdLabel.TabIndex = 0;
            this.categoryIdLabel.Text = "Seleccione una";
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
            // subCategorySearchTextBox
            // 
            // 
            // 
            // 
            this.subCategorySearchTextBox.CustomButton.Image = global::UI.Properties.Resources.Search_16px1;
            this.subCategorySearchTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.subCategorySearchTextBox.CustomButton.Name = "";
            this.subCategorySearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subCategorySearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subCategorySearchTextBox.CustomButton.TabIndex = 1;
            this.subCategorySearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subCategorySearchTextBox.CustomButton.UseSelectable = true;
            this.subCategorySearchTextBox.DisplayIcon = true;
            this.subCategorySearchTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.subCategorySearchTextBox.Lines = new string[0];
            this.subCategorySearchTextBox.Location = new System.Drawing.Point(127, 137);
            this.subCategorySearchTextBox.MaxLength = 32767;
            this.subCategorySearchTextBox.Name = "subCategorySearchTextBox";
            this.subCategorySearchTextBox.PasswordChar = '\0';
            this.subCategorySearchTextBox.PromptText = "Ingrese una subcategoría a buscar";
            this.subCategorySearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subCategorySearchTextBox.SelectedText = "";
            this.subCategorySearchTextBox.SelectionLength = 0;
            this.subCategorySearchTextBox.SelectionStart = 0;
            this.subCategorySearchTextBox.ShortcutsEnabled = true;
            this.subCategorySearchTextBox.ShowButton = true;
            this.subCategorySearchTextBox.ShowClearButton = true;
            this.subCategorySearchTextBox.Size = new System.Drawing.Size(235, 23);
            this.subCategorySearchTextBox.TabIndex = 4;
            this.subCategorySearchTextBox.UseSelectable = true;
            this.subCategorySearchTextBox.WaterMark = "Ingrese una subcategoría a buscar";
            this.subCategorySearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subCategorySearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.subCategorySearchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.subCategorySearchTextBox_ButtonClick);
            this.subCategorySearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subCategorySearchTextBox_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.categoriesComboBox);
            this.groupBox2.Controls.Add(this.subCategorySearchTextBox);
            this.groupBox2.Controls.Add(this.subCategoriesGridView);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.subCategoryIdLabel);
            this.groupBox2.Controls.Add(this.deleteSubCategoryButton);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.updateSubCategoryButton);
            this.groupBox2.Controls.Add(this.subCategoryNameTextBox);
            this.groupBox2.Controls.Add(this.createSubCategoryButton);
            this.groupBox2.Location = new System.Drawing.Point(397, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 405);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SubCategorías";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(115, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Categoría";
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.ItemHeight = 23;
            this.categoriesComboBox.Location = new System.Drawing.Point(188, 19);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(174, 29);
            this.categoriesComboBox.TabIndex = 5;
            this.categoriesComboBox.UseSelectable = true;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // subCategoriesGridView
            // 
            this.subCategoriesGridView.AllowUserToAddRows = false;
            this.subCategoriesGridView.AllowUserToDeleteRows = false;
            this.subCategoriesGridView.AllowUserToResizeRows = false;
            this.subCategoriesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subCategoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subCategoriesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.subCategoriesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCategoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.subCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subCategoriesGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.subCategoriesGridView.EnableHeadersVisualStyles = false;
            this.subCategoriesGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subCategoriesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subCategoriesGridView.Location = new System.Drawing.Point(6, 166);
            this.subCategoriesGridView.Name = "subCategoriesGridView";
            this.subCategoriesGridView.ReadOnly = true;
            this.subCategoriesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCategoriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.subCategoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subCategoriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subCategoriesGridView.Size = new System.Drawing.Size(356, 233);
            this.subCategoriesGridView.TabIndex = 3;
            this.subCategoriesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subCategoriesGridView_CellClick);
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
            // subCategoryIdLabel
            // 
            this.subCategoryIdLabel.AutoSize = true;
            this.subCategoryIdLabel.Location = new System.Drawing.Point(32, 26);
            this.subCategoryIdLabel.Name = "subCategoryIdLabel";
            this.subCategoryIdLabel.Size = new System.Drawing.Size(70, 19);
            this.subCategoryIdLabel.TabIndex = 0;
            this.subCategoryIdLabel.Text = "Seleccione";
            // 
            // deleteSubCategoryButton
            // 
            this.deleteSubCategoryButton.Location = new System.Drawing.Point(168, 99);
            this.deleteSubCategoryButton.Name = "deleteSubCategoryButton";
            this.deleteSubCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSubCategoryButton.TabIndex = 2;
            this.deleteSubCategoryButton.Text = "Eliminar";
            this.deleteSubCategoryButton.UseSelectable = true;
            this.deleteSubCategoryButton.Click += new System.EventHandler(this.deleteSubCategoryButton_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(176, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Nombre de la SubCategoría";
            // 
            // updateSubCategoryButton
            // 
            this.updateSubCategoryButton.Location = new System.Drawing.Point(87, 99);
            this.updateSubCategoryButton.Name = "updateSubCategoryButton";
            this.updateSubCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.updateSubCategoryButton.TabIndex = 2;
            this.updateSubCategoryButton.Text = "Modificar";
            this.updateSubCategoryButton.UseSelectable = true;
            this.updateSubCategoryButton.Click += new System.EventHandler(this.updateSubCategoryButton_Click);
            // 
            // subCategoryNameTextBox
            // 
            // 
            // 
            // 
            this.subCategoryNameTextBox.CustomButton.Image = null;
            this.subCategoryNameTextBox.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.subCategoryNameTextBox.CustomButton.Name = "";
            this.subCategoryNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subCategoryNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subCategoryNameTextBox.CustomButton.TabIndex = 1;
            this.subCategoryNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subCategoryNameTextBox.CustomButton.UseSelectable = true;
            this.subCategoryNameTextBox.CustomButton.Visible = false;
            this.subCategoryNameTextBox.DisplayIcon = true;
            this.subCategoryNameTextBox.Icon = global::UI.Properties.Resources.Edit_16px;
            this.subCategoryNameTextBox.Lines = new string[0];
            this.subCategoryNameTextBox.Location = new System.Drawing.Point(188, 60);
            this.subCategoryNameTextBox.MaxLength = 32767;
            this.subCategoryNameTextBox.Name = "subCategoryNameTextBox";
            this.subCategoryNameTextBox.PasswordChar = '\0';
            this.subCategoryNameTextBox.PromptText = "Ingrese el nombre de la subcategoría";
            this.subCategoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subCategoryNameTextBox.SelectedText = "";
            this.subCategoryNameTextBox.SelectionLength = 0;
            this.subCategoryNameTextBox.SelectionStart = 0;
            this.subCategoryNameTextBox.ShortcutsEnabled = true;
            this.subCategoryNameTextBox.ShowClearButton = true;
            this.subCategoryNameTextBox.Size = new System.Drawing.Size(174, 23);
            this.subCategoryNameTextBox.TabIndex = 3;
            this.subCategoryNameTextBox.UseSelectable = true;
            this.subCategoryNameTextBox.WaterMark = "Ingrese el nombre de la subcategoría";
            this.subCategoryNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subCategoryNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createSubCategoryButton
            // 
            this.createSubCategoryButton.Location = new System.Drawing.Point(6, 99);
            this.createSubCategoryButton.Name = "createSubCategoryButton";
            this.createSubCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.createSubCategoryButton.TabIndex = 2;
            this.createSubCategoryButton.Text = "Agregar";
            this.createSubCategoryButton.UseSelectable = true;
            this.createSubCategoryButton.Click += new System.EventHandler(this.createSubCategoryButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmCategoriesAndSubCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCategoriesAndSubCategories";
            this.Tag = "";
            this.Text = "Categorías y SubCategorías";
            this.Load += new System.EventHandler(this.FrmCategoriesAndSubCategories_Load);
            this.Leave += new System.EventHandler(this.FrmCategoriesAndSubCategories_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox categoryNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel categoryIdLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox subCategorySearchTextBox;
        private MetroFramework.Controls.MetroTextBox categorySearchTextBox;
        private MetroFramework.Controls.MetroGrid categoriesGridView;
        private MetroFramework.Controls.MetroButton deleteCategoryButton;
        private MetroFramework.Controls.MetroButton updateCategoryButton;
        private MetroFramework.Controls.MetroButton createCategoryButton;
        private MetroFramework.Controls.MetroGrid subCategoriesGridView;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel subCategoryIdLabel;
        private MetroFramework.Controls.MetroButton deleteSubCategoryButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton updateSubCategoryButton;
        private MetroFramework.Controls.MetroTextBox subCategoryNameTextBox;
        private MetroFramework.Controls.MetroButton createSubCategoryButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox categoriesComboBox;
    }
}