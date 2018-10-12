namespace UI.Forms
{
    partial class FrmLogin
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
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.DisplayIcon = true;
            this.userNameTextBox.Icon = global::UI.Properties.Resources.User_16px;
            this.userNameTextBox.Lines = new string[] {
        "omar"};
            this.userNameTextBox.Location = new System.Drawing.Point(23, 276);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PromptText = "Ingrese su nombre de usuario";
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(364, 23);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = "omar";
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMark = "Ingrese su nombre de usuario";
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userNameTextBox_KeyUp);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.DisplayIcon = true;
            this.passwordTextBox.Icon = global::UI.Properties.Resources.Password_16px;
            this.passwordTextBox.Lines = new string[] {
        "1234"};
            this.passwordTextBox.Location = new System.Drawing.Point(23, 336);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PromptText = "Ingrese su contraseña";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(364, 23);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "1234";
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMark = "Ingrese su contraseña";
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 314);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Contraseña";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 254);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre de Usuario";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(312, 469);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Iniciar sesión";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 476);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "MiFacturador™";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(127, 476);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(151, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "© Empresa Sin Nombre";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 515);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "FrmLogin";
            this.Text = "Ingreso al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}