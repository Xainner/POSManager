namespace UI.Forms
{
    partial class FrmSelectOffset
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
            this.newOffsetTile = new MetroFramework.Controls.MetroTile();
            this.existingOffsetTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // newOffsetTile
            // 
            this.newOffsetTile.ActiveControl = null;
            this.newOffsetTile.Location = new System.Drawing.Point(57, 121);
            this.newOffsetTile.Name = "newOffsetTile";
            this.newOffsetTile.Size = new System.Drawing.Size(139, 100);
            this.newOffsetTile.TabIndex = 0;
            this.newOffsetTile.Text = "Nuevo Apartado";
            this.newOffsetTile.UseSelectable = true;
            this.newOffsetTile.Click += new System.EventHandler(this.newOffsetTile_Click);
            // 
            // existingOffsetTile
            // 
            this.existingOffsetTile.ActiveControl = null;
            this.existingOffsetTile.Location = new System.Drawing.Point(323, 121);
            this.existingOffsetTile.Name = "existingOffsetTile";
            this.existingOffsetTile.Size = new System.Drawing.Size(139, 100);
            this.existingOffsetTile.TabIndex = 0;
            this.existingOffsetTile.Text = "Apartado Existente";
            this.existingOffsetTile.UseSelectable = true;
            this.existingOffsetTile.Click += new System.EventHandler(this.existingOffsetTile_Click);
            // 
            // FrmSelectOffset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 316);
            this.Controls.Add(this.existingOffsetTile);
            this.Controls.Add(this.newOffsetTile);
            this.Name = "FrmSelectOffset";
            this.Text = "Seleccione Apartado";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile newOffsetTile;
        private MetroFramework.Controls.MetroTile existingOffsetTile;
    }
}