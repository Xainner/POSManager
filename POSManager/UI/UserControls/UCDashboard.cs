using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using UI.Forms;
using BusinessLibrary.Models;
using LogicLibrary.Management;

namespace UI.UserControls
{
    public partial class UCDashboard : MetroUserControl
    {
        UserModel userModel;

        List<RolesModel> rolesModels;

        public UCDashboard(UserModel userModelOld)
        {
            InitializeComponent();
            userModel = userModelOld;
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                if (userModel.Role != 0)
                {
                    rolesModels = RolesManagement.SelectAllRolesByUserId(userModel.Id);
                    if (rolesModels[0].Enabled == 0)
                    {
                        brandsTile.Enabled = false;
                    }
                    if (rolesModels[1].Enabled == 0)
                    {
                        clientsTile.Enabled = false;
                    }
                    if (rolesModels[2].Enabled == 0)
                    {
                        positionsAndSalariesTile.Enabled = false;
                    }
                    if (rolesModels[3].Enabled == 0)
                    {
                        categoriesAndSubCategoriesTile.Enabled = false;
                    }
                    if (rolesModels[4].Enabled == 0)
                    {
                        employeesTile.Enabled = false;
                    }
                    if (rolesModels[5].Enabled == 0)
                    {
                        businessTile.Enabled = false;
                    }
                    if (rolesModels[6].Enabled == 0)
                    {
                        productsTile.Enabled = false;
                    }
                    if (rolesModels[7].Enabled == 0)
                    {
                        invoiceSaleTile.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void brandTile_Click(object sender, EventArgs e)
        {
            FrmBrands frmBrand = new FrmBrands();
            frmBrand.Show();
        }

        private void clientsTile_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.metroPanel.Controls.ContainsKey("ucClients"))
            {
                UCClients ucClient = new UCClients
                {
                    Dock = DockStyle.Fill
                };
                FrmMain.Instance.metroPanel.Controls.Add(ucClient);
            }
            FrmMain.Instance.metroPanel.Controls["ucClients"].BringToFront();
            FrmMain.Instance.metroLink.Visible = true;
        }

        private void categoriesAndSubCategoriesTile_Click(object sender, EventArgs e)
        {
            FrmCategoriesAndSubCategories frmCategoriesAndSubCategories = new FrmCategoriesAndSubCategories();
            frmCategoriesAndSubCategories.Show();
        }

        private void positionsAndSalariesTile_Click(object sender, EventArgs e)
        {
            FrmPositionsAndSalaries frmPositionsAndSalaries = new FrmPositionsAndSalaries();
            frmPositionsAndSalaries.Show();
        }

        private void employeesTile_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.metroPanel.Controls.ContainsKey("ucEmployees"))
            {
                UCEmployees ucEmployees = new UCEmployees
                {
                    Dock = DockStyle.Fill
                };
                FrmMain.Instance.metroPanel.Controls.Add(ucEmployees);
            }
            FrmMain.Instance.metroPanel.Controls["ucEmployees"].BringToFront();
            FrmMain.Instance.metroLink.Visible = true;
        }

        private void businessTile_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.metroPanel.Controls.ContainsKey("ucBusiness"))
            {
                UCBusiness ucBusiness = new UCBusiness
                {
                    Dock = DockStyle.Fill
                };
                FrmMain.Instance.metroPanel.Controls.Add(ucBusiness);
            }
            FrmMain.Instance.metroPanel.Controls["ucBusiness"].BringToFront();
            FrmMain.Instance.metroLink.Visible = true;
        }

        private void invoiceSaleTile_Click(object sender, EventArgs e)
        {
            FrmInvoiceSale frmInvoiceSale = new FrmInvoiceSale();
            frmInvoiceSale.Show();
        }

        private void productsTile_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.metroPanel.Controls.ContainsKey("ucProducts"))
            {
                UCProducts ucProducts = new UCProducts
                {
                    Dock = DockStyle.Fill
                };
                FrmMain.Instance.metroPanel.Controls.Add(ucProducts);
            }
            FrmMain.Instance.metroPanel.Controls["ucProducts"].BringToFront();
            FrmMain.Instance.metroLink.Visible = true;
        }

        private void aboutTile_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Show();
        }

        private void userTile_Click(object sender, EventArgs e)
        {
            switch (userModel.Role)
            {
                case 0:
                    FrmAdministrator frmAdministrator = new FrmAdministrator(userModel.Id);
                    frmAdministrator.Show();
                    break;
                case 1:
                    FrmUser frmUser = new FrmUser(userModel.UserName, userModel.Id);
                    frmUser.Show();
                    break;
            }
        }

        private void logOutTile_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            FrmMain.Instance.Dispose();
            frmLogin.Show();
        }

        private void offsetSaleTile_Click(object sender, EventArgs e)
        {
            FrmNewOffset frmNewOffset = new FrmNewOffset();
            frmNewOffset.Show();
        }
    }
}
