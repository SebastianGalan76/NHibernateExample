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

                dgvBorrowHistory.DataSource = book.Borrows;
            }
        }

        private void dgvBorrowedBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var borrow = dgvBorrowHistory.Rows[e.RowIndex].DataBoundItem as Borrow;

            if(dgvBorrowHistory.Columns[e.ColumnIndex].Name == "FirstName" && e.Value == null) {
                if(borrow != null && borrow.Client != null) {
                    e.Value = borrow.Client.FirstName;
                    e.FormattingApplied = true;
                }
            } else if(dgvBorrowHistory.Columns[e.ColumnIndex].Name == "LastName" && e.Value == null) {
                if(borrow != null && borrow.Client != null) {
                    e.Value = borrow.Client.LastName;
                    e.FormattingApplied = true;
                }
            } else if(dgvBorrowHistory.Columns[e.ColumnIndex].Name == "Email" && e.Value == null) {
                if(borrow != null && borrow.Client!= null) {
                    e.Value = borrow.Client.Email;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            mBookContainer.RemoveBook(mBook);
            Hide();
        }
    }
}
