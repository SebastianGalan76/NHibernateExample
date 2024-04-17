using NHibernate;
using NHibernateExample.Models;

namespace NHibernateExample.Repositories {
    internal class BorrowRepository {
        private readonly ISession mSession;

        public BorrowRepository(ISession session) {
            mSession = session;
        }

        public Borrow GetById(int id) {
            return mSession.Get<Borrow>(id);
        }

        public void SaveOrUpdate(Borrow borrow) {
            using(var transaction = mSession.BeginTransaction()) {
                try {
                    mSession.SaveOrUpdate(borrow);

                    transaction.Commit();
                } catch(Exception ex) {
                    transaction.Rollback();

                    throw new ApplicationException("An error occurred while saving or updating the borrow table.", ex);
                }
            }
        }

        public IList<Borrow> GetBorrows() {
            return mSession.Query<Borrow>().ToList();
        }
    }
}
