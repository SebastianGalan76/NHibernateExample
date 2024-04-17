using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample {
    public partial class AddNewClientForm : Form {
        private ClientContainer mClientContainer;

        internal AddNewClientForm(ClientContainer clientContainer) {
            InitializeComponent();

            mClientContainer = clientContainer;
        }

        private bool ValidateEmail(string email) {
            if(mClientContainer.GetClients().Where(c => c.Email == email).Any()) {
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

            mClientContainer.AddClient(new Client { FirstName = firstName, LastName = lastName, Email = email });
            Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
