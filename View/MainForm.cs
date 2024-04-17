using NHibernate;
using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;

namespace NHibernateExample {
    public partial class MainForm : Form {
        private readonly ClientRepository mClientRepository;

        private ClientFilter mClientFilter = new();
        private IList<Client> mClients;

        public MainForm() {
            InitializeComponent();

            ISession session = DatabaseSessionManager.OpenSession();
            mClientRepository = new ClientRepository(session);

            mClients = new List<Client>();
            LoadClients();
        }

        private void LoadClients() {
            mClients = mClientRepository.GetClients();
            dgvClients.DataSource = mClients;
        }

        private void RefreshClients(IList<Client> clients) {
            dgvClients.DataSource = null;
            dgvClients.DataSource = clients;
            dgvClients.Refresh();
        }

        private void btnClients_Click(object sender, EventArgs e) {
            pClients.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            AddNewClientForm form = new AddNewClientForm(mClientRepository, mClients, dgvClients);
            form.ShowDialog();
        }

        private void vSearch_TextChanged(object sender, EventArgs e) {
            IList<Client> foundedClients = mClientFilter.GetFilteredClientList(mClients, vSearchFirstName.Text, vSearchLastName.Text, vSearchEmail.Text);
            RefreshClients(foundedClients);
        }
    }
}