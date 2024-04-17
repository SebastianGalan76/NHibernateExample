using NHibernateExample.Models;

namespace NHibernateExample.Managers {
    internal class ClientFilter {
        public IList<Client> GetFilteredClientList(IList<Client> allClients,string firstName, string lastName, string email) {
            return allClients.Where(c => 
                FirstNamePredicate(c, firstName)
                && LastNamePredicate(c, lastName)
                && EmailPredicate(c, email))
                .ToList();
        }

        private bool FirstNamePredicate(Client client, string firstName) {
            if(firstName == null || firstName.Length < 1) {
                return true;
            }

            return client.FirstName.ToLower().StartsWith(firstName.ToLower());
        }

        private bool LastNamePredicate(Client client, string lastName) {
            if(lastName == null || lastName.Length < 1) {
                return true;
            }

            return client.LastName.ToLower().StartsWith(lastName.ToLower());
        }

        private bool EmailPredicate(Client client, string emailName) {
            if(emailName == null || emailName.Length < 1) {
                return true;
            }

            return client.Email.ToLower().StartsWith(emailName.ToLower());
        }
    }
}
