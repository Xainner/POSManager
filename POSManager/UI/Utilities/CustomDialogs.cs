using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.SearchForms;

namespace UI.Utilities
{
    public static class CustomDialogs
    {
        public static DialogResult SearchClient()
        {
            DialogResult dialogResult = DialogResult.None;
            using (FrmSearchClient frmSearchClient = new FrmSearchClient())
            {
                dialogResult = frmSearchClient.ShowDialog();
            }
            return dialogResult;
        }

        public static DialogResult SearchEmployee()
        {
            DialogResult dialogResult = DialogResult.None;
            using (FrmSearchEmployee frmSearchEmployee = new FrmSearchEmployee())
            {
                dialogResult = frmSearchEmployee.ShowDialog();
            }
            return dialogResult;
        }
    }
}
