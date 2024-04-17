using NHibernate;
using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;

namespace NHibernateExample {
    public partial class MainForm : Form {
        private readonly ClientRepository mClientRepository;

        private IList<Client> mClients;

        public MainForm() {
            InitializeComponent();

            ISession session = DatabaseSessionManager.OpenSession();
            mClientRepository = new ClientRepository(session);
        }

        private void LoadClients() {
            mClients = mClientRepository.GetClients();
            dgvClients.DataSource = mClients;
        }

        private void Form1_Load(object sender, EventArgs e) {
            LoadClients();
        }

        private void btnClients_Click(object sender, EventArgs e) {

        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            AddNewClientForm form = new AddNewClientForm(mClientRepository, mClients, dgvClients);
            form.ShowDialog();
        }
    }
}