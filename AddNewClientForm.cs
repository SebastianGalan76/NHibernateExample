using NHibernateExample.Models;
using NHibernateExample.Repositories;

namespace NHibernateExample {
    public partial class AddNewClientForm : Form {
        private ClientRepository mClientRepository;
        private IList<Client> mClients;
        private DataGridView mDataGridView;

        internal AddNewClientForm(ClientRepository clientRepository, IList<Client> clients, DataGridView dataGridView) {
            InitializeComponent();

            mClientRepository = clientRepository;
            mClients = clients;
            mDataGridView = dataGridView;
        }

        private bool ValidateEmail(string email) {
            if(mClients.Where(c => c.Email == email).Any()) {
                MessageBox.Show("There is a client with the provided email address!", "OK");
                return false;
            }

            return true;
        }

        private bool ValidateFirstName(string firstName) {
            if(firstName.Length < 2) {
                MessageBox.Show("Provided First Name is not correct!", "OK");
                return false;
            }

            return true;
        }

        private bool ValidateLastName(string lastName) {
            if(lastName.Length < 2) {
                MessageBox.Show("Provided Last Name is not correct!", "OK");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string firstName = vFirstName.Text;
            string lastName = vLastName.Text;
            string email = vEmail.Text;

            if(!ValidateFirstName(firstName)) {
                return;
            }
            if(!ValidateLastName(lastName)) {
                return;
            }
            if(!ValidateEmail(email)) {
                return;
            }
            
            Client newClient = new Client { FirstName = firstName, LastName = lastName, Email = email };
            mClientRepository.SaveOrUpdate(newClient);
            mClients.Add(newClient);
            mDataGridView.DataSource = null;
            mDataGridView.DataSource = mClients;
            mDataGridView.Refresh();

            Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
