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
using MetroFramework.Forms;
using MetroFramework;
using UI.Utilities;

namespace UI.Forms.SearchForms
{
    public partial class FrmSearchClient : MetroForm
    {
        List<ClientModel> clientModels;

        public FrmSearchClient()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Búsqueda rápida de clientes.";
            clientsGridView.DataSource = null;
        }

        private void getClientButton_Click(object sender, EventArgs e)
        {
            if (clientsGridView.DataSource != null)
            {
                ClientModel clientModel = ClientManagement.SelectClientById(int.Parse(clientsGridView.CurrentRow.Cells[0].Value.ToString()));
                FrmInvoiceSale.ClientModel = clientModel;
            } else
            {
                MetroMessageBox.Show(this, "Debe selecccionar un cliente antes de poder envíarlo.", "Cliente incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clientSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(clientSearchTextBox.Text))
            {
                clientModels = ClientManagement.MultipleValueSearch(clientSearchTextBox.Text);
                if (clientModels != null)
                {
                    clientsGridView.DataSource = clientModels;
                } else
                {
                    toolStripStatusLabel1.Text = "No se encontraron registros en la base de datos.";
                }
            } else
            {
                clientsGridView.DataSource = null;
            }
        }
    }
}
