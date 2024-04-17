using NHibernate;
using NHibernateExample.Models;

namespace NHibernateExample.Repositories {
    internal class BookRepository {
        private readonly ISession mSession;

        public BookRepository(ISession session) {
            mSession = session;
        }

        public Book GetById(int id) {
            return mSession.Get<Book>(id);
        }

        public void SaveOrUpdate(Book book) {
            using(var transaction = mSession.BeginTransaction()) {
                try {
                    mSession.SaveOrUpdate(book);

                    transaction.Commit();
                } catch(Exception ex) {
                    transaction.Rollback();

                    throw new ApplicationException("An error occurred while saving or updating the book.", ex);
                }
            }
        }

        public IList<Book> GetBooks() {
            return mSession.Query<Book>().ToList();
        }
    }
}
