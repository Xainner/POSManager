namespace UI.Forms.Extras
{
    partial class FrmFirstRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstRun));
            this.startUpAdvancedWizard = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.advancedWizardPage1 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.validateSerialButton = new MetroFramework.Controls.MetroButton();
            this.keyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.advancedWizardPage3 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.rotateRightLink = new MetroFramework.Controls.MetroLink();
            this.rotateLeftLink = new MetroFramework.Controls.MetroLink();
            this.selectLogoButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.juridicIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.telephoneTextBox = new MetroFramework.Controls.MetroTextBox();
            this.societyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fantasyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.advancedWizardPage2 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.validatePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.advancedWizardPage4 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.startUpAdvancedWizard.SuspendLayout();
            this.advancedWizardPage1.SuspendLayout();
            this.advancedWizardPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.advancedWizardPage2.SuspendLayout();
            this.advancedWizardPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // startUpAdvancedWizard
            // 
            this.startUpAdvancedWizard.BackButtonEnabled = false;
            this.startUpAdvancedWizard.BackButtonText = "< Atras";
            this.startUpAdvancedWizard.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.startUpAdvancedWizard.ButtonsVisible = true;
            this.startUpAdvancedWizard.CancelButtonText = "&Cancelar";
            this.startUpAdvancedWizard.Controls.Add(this.advancedWizardPage1);
            this.startUpAdvancedWizard.Controls.Add(this.advancedWizardPage3);
            this.startUpAdvancedWizard.Controls.Add(this.advancedWizardPage2);
            this.startUpAdvancedWizard.Controls.Add(this.advancedWizardPage4);
            this.startUpAdvancedWizard.CurrentPageIsFinishPage = false;
            this.startUpAdvancedWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUpAdvancedWizard.FinishButton = true;
            this.startUpAdvancedWizard.FinishButtonEnabled = true;
            this.startUpAdvancedWizard.FinishButtonText = "&Terminar";
            this.startUpAdvancedWizard.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.startUpAdvancedWizard.HelpButton = true;
            this.startUpAdvancedWizard.HelpButtonText = "&Acerca";
            this.startUpAdvancedWizard.Location = new System.Drawing.Point(20, 60);
            this.startUpAdvancedWizard.Name = "startUpAdvancedWizard";
            this.startUpAdvancedWizard.NextButtonEnabled = true;
            this.startUpAdvancedWizard.NextButtonText = "Siguiente >";
            this.startUpAdvancedWizard.ProcessKeys = false;
            this.startUpAdvancedWizard.Size = new System.Drawing.Size(760, 370);
            this.startUpAdvancedWizard.TabIndex = 0;
            this.startUpAdvancedWizard.TouchScreen = false;
            this.startUpAdvancedWizard.WizardPages.Add(this.advancedWizardPage1);
            this.startUpAdvancedWizard.WizardPages.Add(this.advancedWizardPage2);
            this.startUpAdvancedWizard.WizardPages.Add(this.advancedWizardPage3);
            this.startUpAdvancedWizard.WizardPages.Add(this.advancedWizardPage4);
            this.startUpAdvancedWizard.Cancel += new System.EventHandler(this.startUpAdvancedWizard_Cancel);
            this.startUpAdvancedWizard.Next += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardEventArgs>(this.startUpAdvancedWizard_Next);
            this.startUpAdvancedWizard.Back += new System.EventHandler(this.startUpAdvancedWizard_Back);
            this.startUpAdvancedWizard.Finish += new System.EventHandler(this.startUpAdvancedWizard_Finish);
            this.startUpAdvancedWizard.Help += new System.EventHandler(this.startUpAdvancedWizard_Help);
            this.startUpAdvancedWizard.Load += new System.EventHandler(this.startUpAdvancedWizard_Load);
            this.startUpAdvancedWizard.Leave += new System.EventHandler(this.startUpAdvancedWizard_Leave);
            // 
            // advancedWizardPage1
            // 
            this.advancedWizardPage1.Controls.Add(this.validateSerialButton);
            this.advancedWizardPage1.Controls.Add(this.keyMaskedTextBox);
            this.advancedWizardPage1.Controls.Add(this.metroLabel13);
            this.advancedWizardPage1.Controls.Add(this.metroLabel2);
            this.advancedWizardPage1.Controls.Add(this.metroLabel1);
            this.advancedWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage1.Header = true;
            this.advancedWizardPage1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage1.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage1.HeaderImage")));
            this.advancedWizardPage1.HeaderImageVisible = true;
            this.advancedWizardPage1.HeaderTitle = "Bienvenido a MiFacturador";
            this.advancedWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage1.Name = "advancedWizardPage1";
            this.advancedWizardPage1.PreviousPage = 0;
            this.advancedWizardPage1.Size = new System.Drawing.Size(760, 330);
            this.advancedWizardPage1.SubTitle = "Suit completa de punto de venta";
            this.advancedWizardPage1.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage1.TabIndex = 1;
            // 
            // validateSerialButton
            // 
            this.validateSerialButton.Location = new System.Drawing.Point(404, 209);
            this.validateSerialButton.Name = "validateSerialButton";
            this.validateSerialButton.Size = new System.Drawing.Size(57, 23);
            this.validateSerialButton.TabIndex = 4;
            this.validateSerialButton.Text = "Validar";
            this.validateSerialButton.UseSelectable = true;
            this.validateSerialButton.Click += new System.EventHandler(this.validateSerialButton_Click);
            // 
            // keyMaskedTextBox
            // 
            this.keyMaskedTextBox.Location = new System.Drawing.Point(170, 209);
            this.keyMaskedTextBox.Mask = "CCCCC-CCCCC-CCCCC-CCCCC-CCCCC-CCCCC";
            this.keyMaskedTextBox.Name = "keyMaskedTextBox";
            this.keyMaskedTextBox.PromptChar = ' ';
            this.keyMaskedTextBox.Size = new System.Drawing.Size(228, 20);
            this.keyMaskedTextBox.TabIndex = 3;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(170, 182);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(291, 19);
            this.metroLabel13.TabIndex = 2;
            this.metroLabel13.Text = "Para comenzar, ingresa tu licencia del programa";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(65, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(503, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "tomes unos minutos para completar información necesaria para iniciar el programa." +
    "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(567, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Hemos detectado que es la primera vez que inicias el programa por lo que requerim" +
    "os que te ";
            // 
            // advancedWizardPage3
            // 
            this.advancedWizardPage3.Controls.Add(this.rotateRightLink);
            this.advancedWizardPage3.Controls.Add(this.rotateLeftLink);
            this.advancedWizardPage3.Controls.Add(this.selectLogoButton);
            this.advancedWizardPage3.Controls.Add(this.pictureBox1);
            this.advancedWizardPage3.Controls.Add(this.juridicIdTextBox);
            this.advancedWizardPage3.Controls.Add(this.telephoneTextBox);
            this.advancedWizardPage3.Controls.Add(this.societyNameTextBox);
            this.advancedWizardPage3.Controls.Add(this.fantasyNameTextBox);
            this.advancedWizardPage3.Controls.Add(this.metroLabel8);
            this.advancedWizardPage3.Controls.Add(this.metroLabel9);
            this.advancedWizardPage3.Controls.Add(this.metroLabel10);
            this.advancedWizardPage3.Controls.Add(this.metroLabel11);
            this.advancedWizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage3.Header = true;
            this.advancedWizardPage3.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage3.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage3.HeaderImage")));
            this.advancedWizardPage3.HeaderImageVisible = true;
            this.advancedWizardPage3.HeaderTitle = "Información del negocio";
            this.advancedWizardPage3.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage3.Name = "advancedWizardPage3";
            this.advancedWizardPage3.PreviousPage = 1;
            this.advancedWizardPage3.Size = new System.Drawing.Size(760, 330);
            this.advancedWizardPage3.SubTitle = "Necesitaremos configurar un negocio como principal, más adelante puedes cambiar e" +
    "sta configuración";
            this.advancedWizardPage3.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage3.TabIndex = 3;
            // 
            // rotateRightLink
            // 
            this.rotateRightLink.Image = global::UI.Properties.Resources.Rotate_Right_16px1;
            this.rotateRightLink.Location = new System.Drawing.Point(687, 276);
            this.rotateRightLink.Name = "rotateRightLink";
            this.rotateRightLink.Size = new System.Drawing.Size(26, 23);
            this.rotateRightLink.TabIndex = 18;
            this.rotateRightLink.UseSelectable = true;
            // 
            // rotateLeftLink
            // 
            this.rotateLeftLink.Image = global::UI.Properties.Resources.Rotate_Left_16px1;
            this.rotateLeftLink.Location = new System.Drawing.Point(552, 276);
            this.rotateLeftLink.Name = "rotateLeftLink";
            this.rotateLeftLink.Size = new System.Drawing.Size(26, 23);
            this.rotateLeftLink.TabIndex = 17;
            this.rotateLeftLink.UseSelectable = true;
            // 
            // selectLogoButton
            // 
            this.selectLogoButton.Location = new System.Drawing.Point(584, 276);
            this.selectLogoButton.Name = "selectLogoButton";
            this.selectLogoButton.Size = new System.Drawing.Size(97, 23);
            this.selectLogoButton.TabIndex = 16;
            this.selectLogoButton.Text = "Seleccionar logo";
            this.selectLogoButton.UseSelectable = true;
            this.selectLogoButton.Click += new System.EventHandler(this.selectLogoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Empty;
            this.pictureBox1.Location = new System.Drawing.Point(552, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.juridicIdTextBox.Location = new System.Drawing.Point(239, 200);
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
            this.juridicIdTextBox.TabIndex = 13;
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
            this.telephoneTextBox.Location = new System.Drawing.Point(239, 247);
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
            this.telephoneTextBox.TabIndex = 14;
            this.telephoneTextBox.UseSelectable = true;
            this.telephoneTextBox.WaterMark = "Ingrese el número teléfonico";
            this.telephoneTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telephoneTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.societyNameTextBox.Location = new System.Drawing.Point(239, 154);
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
            this.societyNameTextBox.TabIndex = 12;
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
            this.fantasyNameTextBox.Location = new System.Drawing.Point(239, 113);
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
            this.fantasyNameTextBox.TabIndex = 11;
            this.fantasyNameTextBox.UseSelectable = true;
            this.fantasyNameTextBox.WaterMark = "Ingrese el nombre de fantasía";
            this.fantasyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fantasyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(79, 247);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Teléfono";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(79, 200);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(98, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Cédula Jurídica";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(79, 154);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(150, 19);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Nombre de la Sociedad";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(79, 117);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(128, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "Nombre de Fantasía";
            // 
            // advancedWizardPage2
            // 
            this.advancedWizardPage2.Controls.Add(this.validatePasswordTextBox);
            this.advancedWizardPage2.Controls.Add(this.passwordTextBox);
            this.advancedWizardPage2.Controls.Add(this.userNameTextBox);
            this.advancedWizardPage2.Controls.Add(this.metroLabel5);
            this.advancedWizardPage2.Controls.Add(this.metroLabel6);
            this.advancedWizardPage2.Controls.Add(this.metroLabel7);
            this.advancedWizardPage2.Controls.Add(this.metroLabel4);
            this.advancedWizardPage2.Controls.Add(this.metroLabel3);
            this.advancedWizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage2.Header = true;
            this.advancedWizardPage2.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage2.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage2.HeaderImage")));
            this.advancedWizardPage2.HeaderImageVisible = true;
            this.advancedWizardPage2.HeaderTitle = "Configuración de usuario principal";
            this.advancedWizardPage2.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage2.Name = "advancedWizardPage2";
            this.advancedWizardPage2.PreviousPage = 0;
            this.advancedWizardPage2.Size = new System.Drawing.Size(760, 330);
            this.advancedWizardPage2.SubTitle = "Usuario administrador";
            this.advancedWizardPage2.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage2.TabIndex = 2;
            // 
            // validatePasswordTextBox
            // 
            // 
            // 
            // 
            this.validatePasswordTextBox.CustomButton.Image = null;
            this.validatePasswordTextBox.CustomButton.Location = new System.Drawing.Point(212, 1);
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
            this.validatePasswordTextBox.Location = new System.Drawing.Point(373, 251);
            this.validatePasswordTextBox.MaxLength = 32767;
            this.validatePasswordTextBox.Name = "validatePasswordTextBox";
            this.validatePasswordTextBox.PasswordChar = '*';
            this.validatePasswordTextBox.PromptText = "Confirme su contraseña";
            this.validatePasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.validatePasswordTextBox.SelectedText = "";
            this.validatePasswordTextBox.SelectionLength = 0;
            this.validatePasswordTextBox.SelectionStart = 0;
            this.validatePasswordTextBox.ShortcutsEnabled = true;
            this.validatePasswordTextBox.Size = new System.Drawing.Size(234, 23);
            this.validatePasswordTextBox.TabIndex = 11;
            this.validatePasswordTextBox.UseSelectable = true;
            this.validatePasswordTextBox.WaterMark = "Confirme su contraseña";
            this.validatePasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.validatePasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.DisplayIcon = true;
            this.passwordTextBox.Icon = global::UI.Properties.Resources.Password_16px;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(373, 204);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PromptText = "Ingrese la contraseña";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(234, 23);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMark = "Ingrese la contraseña";
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.DisplayIcon = true;
            this.userNameTextBox.Icon = global::UI.Properties.Resources.User_16px;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(373, 166);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PromptText = "Ingrese un nombre de usuario";
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(234, 23);
            this.userNameTextBox.TabIndex = 9;
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMark = "Ingrese un nombre de usuario";
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(197, 251);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Confirmar Contraseña";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(197, 204);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Contraseña";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(197, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(126, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Nombre de Usuario";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(65, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(297, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Por favor, completa los campos correspondientes";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(65, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(356, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Necesitaremos configurar un usuario de tipo administrador,";
            // 
            // advancedWizardPage4
            // 
            this.advancedWizardPage4.Controls.Add(this.metroLabel12);
            this.advancedWizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage4.Header = true;
            this.advancedWizardPage4.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage4.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage4.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage4.HeaderImage")));
            this.advancedWizardPage4.HeaderImageVisible = true;
            this.advancedWizardPage4.HeaderTitle = "MiTienda";
            this.advancedWizardPage4.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage4.Name = "advancedWizardPage4";
            this.advancedWizardPage4.PreviousPage = 2;
            this.advancedWizardPage4.Size = new System.Drawing.Size(760, 330);
            this.advancedWizardPage4.SubTitle = "Configuración Finalizada";
            this.advancedWizardPage4.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage4.TabIndex = 4;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(65, 98);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(366, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Todo listo, ya puedes inicializar el programa con normalidad.";
            // 
            // FrmFirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startUpAdvancedWizard);
            this.Name = "FrmFirstRun";
            this.Text = "MiFacturador - Instalador";
            this.startUpAdvancedWizard.ResumeLayout(false);
            this.advancedWizardPage1.ResumeLayout(false);
            this.advancedWizardPage1.PerformLayout();
            this.advancedWizardPage3.ResumeLayout(false);
            this.advancedWizardPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.advancedWizardPage2.ResumeLayout(false);
            this.advancedWizardPage2.PerformLayout();
            this.advancedWizardPage4.ResumeLayout(false);
            this.advancedWizardPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard startUpAdvancedWizard;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage3;
        private MetroFramework.Controls.MetroTextBox validatePasswordTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox juridicIdTextBox;
        private MetroFramework.Controls.MetroTextBox telephoneTextBox;
        private MetroFramework.Controls.MetroTextBox societyNameTextBox;
        private MetroFramework.Controls.MetroTextBox fantasyNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage4;
        private MetroFramework.Controls.MetroLink rotateRightLink;
        private MetroFramework.Controls.MetroLink rotateLeftLink;
        private MetroFramework.Controls.MetroButton selectLogoButton;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.MaskedTextBox keyMaskedTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton validateSerialButton;
    }
}