using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using UI.UserControls;
using BusinessLibrary.Models;
using LogicLibrary.Utilities;

namespace UI
{
    public partial class FrmMain : MetroForm
    {
        static FrmMain _frmMain;
        UserModel UserModel = new UserModel();

        public static FrmMain Instance
        {
            get
            {
                if (_frmMain == null)
                {
                    UserModel userModel = new UserModel();
                    _frmMain = new FrmMain(userModel);
                }
                return _frmMain;
            }
        }

        public MetroPanel metroPanel
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }

        public MetroLink metroLink
        {
            get { return goBackLink; }
            set { goBackLink = value; }
        }

        public ToolStripStatusLabel ToolStripLabel
        {
            get { return toolStripStatusLabel1; }
            set { toolStripStatusLabel1 = value; }
        }

        public FrmMain(UserModel userModel)
        {
            InitializeComponent();
            UserModel = userModel;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            goBackLink.Visible = false;
            _frmMain = this;
            UCDashboard ucDashboard = new UCDashboard(UserModel);
            mainPanel.Controls.Add(ucDashboard);
            userNameLabel.Text = UserModel.UserName;
            toolStripStatusLabel1.Text = "Estás en el Dashboard";
        }

        private void FrmMain_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackLink_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["ucDashboard"].BringToFront();
            goBackLink.Visible = false;
            toolStripStatusLabel1.Text = "Estás en el Dashboard";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Printing printing = new Printing(1, DateTime.Now.Date, "casa de omar", "casa de pamela", 12, "Saul");
            printing.print();
        }
    }
}
