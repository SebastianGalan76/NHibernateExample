using NHibernate;
using NHibernate.Cfg;
using NHibernateExample.Managers;
using NHibernateExample.Repositories;

namespace NHibernateExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ClientRepository clientRepository = new ClientRepository(DatabaseSessionManager.OpenSession());

            clientRepository.SaveOrUpdate(new Models.Client { FirstName = "Seba", LastName = "Kowalski", Email = "seba@email.pl" });
        }
    }
}