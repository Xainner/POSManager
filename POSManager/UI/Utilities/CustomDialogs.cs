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
        public static DialogResult SearchClient(int frm)
        {
            DialogResult dialogResult = DialogResult.None;
            using (FrmSearchClient frmSearchClient = new FrmSearchClient(frm))
            {
                dialogResult = frmSearchClient.ShowDialog();
            }
            return dialogResult;
        }

        public static DialogResult SearchEmployee(int frm)
        {
            DialogResult dialogResult = DialogResult.None;
            using (FrmSearchEmployee frmSearchEmployee = new FrmSearchEmployee(frm))
            {
                dialogResult = frmSearchEmployee.ShowDialog();
            }
            return dialogResult;
        }
    }
}
