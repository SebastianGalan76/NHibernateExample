using NHibernate;
using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;
using NHibernateExample.View;
using static NHibernate.Cfg.Mappings;

namespace NHibernateExample {
    public partial class MainForm : Form {
        private readonly ClientRepository mClientRepository;

        private ClientFilter mClientFilter = new();
        private IList<Client> mAllClients;
        private IList<Client> mClients;

        public MainForm() {
            InitializeComponent();

            ISession session = DatabaseSessionManager.OpenSession();
            mClientRepository = new ClientRepository(session);

            mAllClients = new List<Client>();
            mClients = new List<Client>();

            LoadClients();
        }

        private void LoadClients() {
            mAllClients = mClientRepository.GetClients();
            foreach(var client in mAllClients) {
                mClients.Add(client);
            }

            dgvClients.DataSource = mClients;
        }

        private void RefreshClients(IList<Client> clients) {
            mClients.Clear();
            foreach(var client in clients) {
                mClients.Add(client);
            }

            List<DataGridViewColumn> savedColumns = new List<DataGridViewColumn>();
            string[] columnOrder = new string[] { "ID", "FirstName", "LastName", "Email", "Manage" };
            foreach(DataGridViewColumn column in dgvClients.Columns) {
                savedColumns.Add(column);
            }

            dgvClients.DataSource = null;
            dgvClients.DataSource = mClients;

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
            AddNewClientForm form = new AddNewClientForm(mClientRepository, mAllClients, dgvClients);
            form.ShowDialog();
        }

        private void vSearch_TextChanged(object sender, EventArgs e) {
            IList<Client> foundedClients = mClientFilter.GetFilteredClientList(mAllClients, vSearchFirstName.Text, vSearchLastName.Text, vSearchEmail.Text);
            RefreshClients(foundedClients);
        }
    }
}