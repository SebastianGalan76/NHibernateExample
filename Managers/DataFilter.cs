using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample.Managers {
    internal class DataFilter {
        public IList<Client> GetFilteredClientList(ClientContainer clientContainer,string firstName, string lastName, string email) {
            return clientContainer.GetClients().Where(c => 
                FirstNamePredicate(c, firstName)
                && LastNamePredicate(c, lastName)
                && EmailPredicate(c, email))
                .ToList();

            bool FirstNamePredicate(Client client, string firstName) {
                if(firstName == null || firstName.Length < 1) {
                    return true;
                }

                return client.FirstName.ToLower().StartsWith(firstName.ToLower());
            }

            bool LastNamePredicate(Client client, string lastName) {
                if(lastName == null || lastName.Length < 1) {
                    return true;
                }

                return client.LastName.ToLower().StartsWith(lastName.ToLower());
            }

            bool EmailPredicate(Client client, string emailName) {
                if(emailName == null || emailName.Length < 1) {
                    return true;
                }

                return client.Email.ToLower().StartsWith(emailName.ToLower());
            }
        }

        public IList<Book> GetFilteredBookList(BookContainer clientContainer, string isbn, string title, string author) {
            return clientContainer.GetBooks().Where(b =>
                ISBNPredicate(b, isbn)
                && TitlePredicate(b, title)
                && AuthorPredicate(b, author))
                .ToList();

            bool ISBNPredicate(Book book, string isbn) {
                if(isbn == null || isbn.Length < 1) {
                    return true;
                }

                return book.ISBN.ToLower().StartsWith(isbn.ToLower());
            }

            bool TitlePredicate(Book book, string title) {
                if(title == null || title.Length < 1) {
                    return true;
                }

                return book.Title.ToLower().StartsWith(title.ToLower());
            }

            bool AuthorPredicate(Book book, string author) {
                if(author == null || author.Length < 1) {
                    return true;
                }

                return book.Author.ToLower().StartsWith(author.ToLower());
            }
        }
    }
}
