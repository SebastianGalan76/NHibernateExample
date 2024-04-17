using NHibernate;
using NHibernateExample.Models;
using System.Diagnostics.CodeAnalysis;

namespace NHibernateExample.Repositories {
    internal class ClientRepository {
        private readonly ISession mSession;

        public ClientRepository(ISession session) {
            mSession = session;
        }

        public Client GetById(int id) {
            return mSession.Get<Client>(id);
        }

        public void SaveOrUpdate(Client client) {
            using(var transaction = mSession.BeginTransaction()) {
                try {
                    mSession.SaveOrUpdate(client);

                    transaction.Commit();
                }
                catch (Exception ex) {
                    transaction.Rollback();

                    throw new ApplicationException("An error occurred while saving or updating the client.", ex);
                }
            }
        }

        public IList<Client> GetClients() {
            return mSession.Query<Client>().ToList();
        }
    }
}
