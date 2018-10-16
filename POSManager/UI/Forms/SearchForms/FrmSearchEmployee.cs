using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary.Models;
using LogicLibrary.Management;
using MetroFramework;
using MetroFramework.Forms;

namespace UI.Forms.SearchForms
{
    public partial class FrmSearchEmployee : MetroForm
    {
        List<EmployeeModel> employeeModels;
        int frmNew;

        public FrmSearchEmployee(int frm)
        {
            frmNew = frm;
            InitializeComponent();
            toolStripStatusLabel1.Text = "Búsqueda rápida de clientes.";
            employeesGridView.DataSource = null;
        }

        private void getEmployeeButton_Click(object sender, EventArgs e)
        {
            switch (frmNew)
            {
                case 0:
                    if (employeesGridView.DataSource != null)
                    {
                        EmployeeModel employeeModel = EmployeeManagement.SelectEmployeeById(int.Parse(employeesGridView.CurrentRow.Cells[0].Value.ToString()));
                        FrmInvoiceSale.EmployeeModel = employeeModel;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Debe selecccionar un empleado antes de poder envíarlo.", "Empleado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 1:
                    if (employeesGridView.DataSource != null)
                    {
                        EmployeeModel employeeModel = EmployeeManagement.SelectEmployeeById(int.Parse(employeesGridView.CurrentRow.Cells[0].Value.ToString()));
                        FrmNewOffset.EmployeeModel = employeeModel;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Debe selecccionar un empleado antes de poder envíarlo.", "Empleado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void employeeSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(employeeSearchTextBox.Text))
            {
                employeeModels = EmployeeManagement.MultipleValueSearch(employeeSearchTextBox.Text);
                if (employeeModels != null)
                {
                    employeesGridView.DataSource = employeeModels;
                }
                else
                {
                    toolStripStatusLabel1.Text = "No se encontraron registros en la base de datos.";
                }
            }
            else
            {
                employeesGridView.DataSource = null;
            }
        }

        private void employeesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeesGridView.CurrentCell != null)
            {
                getEmployeeButton.PerformClick();
            }
        }
    }
}
