using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;

namespace NHibernateExample.Container {
    internal class ClientContainer {
        private readonly ClientRepository mClientRepository;

        internal delegate void RefreshDataGrid(IList<Client> clients);
        internal RefreshDataGrid mRefreshDataGrid;

        private IList<Client> mClients;

        public ClientContainer(RefreshDataGrid refreshDataGrid) {
            mClientRepository = new ClientRepository(DatabaseSessionManager.OpenSession());
            mClients = mClientRepository.GetClients();

            mRefreshDataGrid = refreshDataGrid;
        }

        public IList<Client> GetClients() {
            return mClients;
        }

        public void AddClient(Client client) { 
            mClients.Add(client);
            mClientRepository.SaveOrUpdate(client);
            mRefreshDataGrid(mClients);
        }

        public void RemoveClient(Client client) {
            mClients.Remove(client);
            mClientRepository.Delete(client);
            mRefreshDataGrid(mClients);
        }

        public void UpdateClient(Client client) {
            mClientRepository.SaveOrUpdate(client);
        }
    }
}
