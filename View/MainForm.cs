using NHibernateExample.Container;
using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.View;

namespace NHibernateExample {
    public partial class MainForm : Form {
        private readonly ClientContainer mClientContainer;

        private ClientFilter mClientFilter = new();

        public MainForm() {
            InitializeComponent();

            mClientContainer = new ClientContainer(RefreshDataGrid);

            LoadClients();
        }

        private void LoadClients() {
            RefreshDataGrid(mClientContainer.GetClients());
        }

        private void RefreshDataGrid(IList<Client> clients) {
            List<DataGridViewColumn> savedColumns = new List<DataGridViewColumn>();
            string[] columnOrder = new string[] { "ID", "FirstName", "LastName", "Email", "Manage" };
            foreach(DataGridViewColumn column in dgvClients.Columns) {
                savedColumns.Add(column);
            }

            dgvClients.DataSource = null;
            dgvClients.DataSource = clients;

            dgvClients.Columns.Clear();
            foreach(DataGridViewColumn column in savedColumns) {
                dgvClients.Columns.Add(column.Clone() as DataGridViewColumn);
            }

            //Restore column order
            for(int i = 0;i < columnOrder.Length;i++) {
                string columnName = columnOrder[i];
                if(dgvClients.Columns.Contains(columnName)) {
                    dgvClients.Columns[columnName].DisplayIndex = i;
                }
            }
        }

        private void btnClients_Click(object sender, EventArgs e) {
            pClients.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            AddNewClientForm form = new AddNewClientForm(mClientContainer);
            form.ShowDialog();
        }

        private void vSearch_TextChanged(object sender, EventArgs e) {
            IList<Client> foundedClients = mClientFilter.GetFilteredClientList(mClientContainer, vSearchFirstName.Text, vSearchLastName.Text, vSearchEmail.Text);
            RefreshDataGrid(foundedClients);
        }

        private void DgvClients_ManageClientClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvClients.Columns["Manage"].Index && e.RowIndex >= 0) {
                Client selectedClient = dgvClients.Rows[e.RowIndex].DataBoundItem as Client;

                if(selectedClient != null) {
                    ClientForm form = new ClientForm(selectedClient, mClientContainer);
                    form.ShowDialog();
                }
            }
        }
    }
}