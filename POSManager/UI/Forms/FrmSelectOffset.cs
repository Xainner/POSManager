using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class FrmSelectOffset : MetroFramework.Forms.MetroForm
    {
        public FrmSelectOffset()
        {
            InitializeComponent();
        }

        private void newOffsetTile_Click(object sender, EventArgs e)
        {
            FrmNewOffset frmNewOffset = new FrmNewOffset();
            frmNewOffset.Show();
        }

        private void existingOffsetTile_Click(object sender, EventArgs e)
        {
            FrmExistingOffset frmExistingOffset = new FrmExistingOffset();
            frmExistingOffset.Show();
        }
    }
}
