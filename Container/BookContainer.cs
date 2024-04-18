using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;

namespace NHibernateExample.Container {
    internal class BookContainer {
        private readonly BookRepository mBookRepository;

        internal delegate void RefreshDataGrid(IList<Book> books);
        internal RefreshDataGrid mRefreshDataGrid;

        private IList<Book> mBooks;

        public BookContainer(RefreshDataGrid refreshDataGrid) {
            mBookRepository = new BookRepository(DatabaseSessionManager.OpenSession());
            mBooks = mBookRepository.GetBooks();

            mRefreshDataGrid = refreshDataGrid;
        }

        public IList<Book> GetBooks() {
            return mBooks;
        }

        public void AddBook(Book book) {
            mBooks.Add(book);
            mBookRepository.SaveOrUpdate(book);
            mRefreshDataGrid(mBooks);
        }

        public void RemoveBook(Book book) {
            mBooks.Remove(book);
            mBookRepository.Delete(book);
            mRefreshDataGrid(mBooks);
        }

        public void UpdateBook(Book book) {
            mBookRepository.SaveOrUpdate(book);
        }
    }
}
