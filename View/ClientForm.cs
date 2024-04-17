using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample.View {
    public partial class ClientForm : Form {
        private readonly ClientContainer mClientContainer;
        private readonly Client mClient;

        internal ClientForm(Client client, ClientContainer clientContainer) {
            InitializeComponent();

            mClient = client;
            vFirstName.Text = client.FirstName;
            vLastName.Text = client.LastName;
            vEmail.Text = client.Email;

            mClientContainer = clientContainer;
        }

        private void UpdateUser() {
            mClient.FirstName = vFirstName.Text;
            mClient.LastName = vLastName.Text;
            mClient.Email = vEmail.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            mClientContainer.RemoveClient(mClient);
            Hide();
        }
    }
}
