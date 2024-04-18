using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample.View {
    public partial class BookForm : Form {
        private readonly BookContainer mBookContainer;
        private readonly Book mBook;

        internal BookForm(Book book, BookContainer bookContainer) {
            InitializeComponent();

            mBook = book;
            mBookContainer = bookContainer;

            tvAuthor.Text = mBook.Author;
            tvTitle.Text = mBook.Title;
            tvAuthor.Text = mBook.Author;

            if(book.Borrows != null) {
                bool available = true;
                foreach(Borrow borrow in book.Borrows) {
                    if(!borrow.IsReturned()) {
                        available = false;
                        break;
                    }
                }

                cbAvailable.Checked = available;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            mBookContainer.RemoveBook(mBook);
            Hide();
        }
    }
}
