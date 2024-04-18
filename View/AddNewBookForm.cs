using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample {
    public partial class AddNewBookForm : Form {
        private BookContainer mBookContainer;

        internal AddNewBookForm(BookContainer bookContainer) {
            InitializeComponent();

            mBookContainer = bookContainer;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string isbn = vISBN.Text;
            string title = vTitle.Text;
            string author = vAuthor.Text;

            mBookContainer.AddBook(new Book() { ISBN = isbn, Title = title, Author = author});
            Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
