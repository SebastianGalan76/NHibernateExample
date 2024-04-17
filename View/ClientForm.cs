using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;

namespace NHibernateExample.View {
    public partial class ClientForm : Form {
        private readonly ClientRepository mClientRepository;
        private readonly Client mClient;

        internal ClientForm(Client client) {
            InitializeComponent();

            mClient = client;
            vFirstName.Text = client.FirstName;
            vLastName.Text = client.LastName;
            vEmail.Text = client.Email;

            mClientRepository = new ClientRepository(DatabaseSessionManager.OpenSession());
        }

        private void UpdateUser() {
            mClient.FirstName = vFirstName.Text;
            mClient.LastName = vLastName.Text;
            mClient.Email = vEmail.Text;

            mClientRepository.SaveOrUpdate(mClient);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            mClientRepository.Delete(mClient);
        }
    }
}
