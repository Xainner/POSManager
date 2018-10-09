namespace UI.Forms
{
    partial class FrmAbout
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.productNameLabel = new MetroFramework.Controls.MetroLabel();
            this.productKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.licenseTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(80, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "MiFacturador™";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(80, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(191, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Todos los derechos reservados.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(80, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(151, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "© Empresa Sin Nombre";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(80, 228);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "2018";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Windows icons by Icons8";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(80, 199);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Versión 2.0 “Goku”";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(369, 114);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(83, 19);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "metroLabel6";
            // 
            // productKeyLabel
            // 
            this.productKeyLabel.AutoSize = true;
            this.productKeyLabel.Location = new System.Drawing.Point(369, 142);
            this.productKeyLabel.Name = "productKeyLabel";
            this.productKeyLabel.Size = new System.Drawing.Size(83, 19);
            this.productKeyLabel.TabIndex = 5;
            this.productKeyLabel.Text = "metroLabel6";
            // 
            // licenseTypeLabel
            // 
            this.licenseTypeLabel.AutoSize = true;
            this.licenseTypeLabel.Location = new System.Drawing.Point(369, 171);
            this.licenseTypeLabel.Name = "licenseTypeLabel";
            this.licenseTypeLabel.Size = new System.Drawing.Size(83, 19);
            this.licenseTypeLabel.TabIndex = 5;
            this.licenseTypeLabel.Text = "metroLabel6";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 332);
            this.Controls.Add(this.licenseTypeLabel);
            this.Controls.Add(this.productKeyLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmAbout";
            this.Text = "Acerca de la aplicación";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel productNameLabel;
        private MetroFramework.Controls.MetroLabel productKeyLabel;
        private MetroFramework.Controls.MetroLabel licenseTypeLabel;
    }
}