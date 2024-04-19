using NHibernateExample.Container;
using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernateExample.View {
    public partial class BorrowBookForm : Form {
        private readonly BookContainer mBookContainer;
        private readonly BorrowRepository mBorrowRepository;
        private readonly ClientForm mClientForm;
        private readonly Client mClient;
        private readonly DataFilter dataFilter = new();

        internal BorrowBookForm(Client client, BookContainer bookContainer, ClientForm clientForm) {
            InitializeComponent();

            mClient = client;
            mClientForm = clientForm;
            mBookContainer = bookContainer;

            mBorrowRepository = new BorrowRepository(DatabaseSessionManager.OpenSession());

            IList<Book> availableBookList = new List<Book>();
            foreach(Book book in mBookContainer.GetBooks()) {
                bool available = true;
                foreach(Borrow borrow in book.Borrows) {
                    if(!borrow.IsReturned()) {
                        available = false;
                        break;
                    }
                }

                if(available) {
                    availableBookList.Add(book);
                }
            }

            if(availableBookList.Count > 0) {
                RefreshBookList(availableBookList);
            }
        }

        private void RefreshBookList(IList<Book> books) {
            dgvAvailableBooks.DataSource = null;
            dgvAvailableBooks.AutoGenerateColumns = false;
            dgvAvailableBooks.DataSource = books;
        }

        private void dgvAvailableBooks_SelectBookClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvAvailableBooks.Columns["Borrow"].Index && e.RowIndex >= 0) {
                Book? selectedBook = dgvAvailableBooks.Rows[e.RowIndex].DataBoundItem as Book;

                if(selectedBook != null) {
                    Borrow borrow = new Borrow() {
                        Book = selectedBook,
                        Client = mClient,
                        BorrowDate = DateTime.Now,
                        ReturnDate = DateTime.MinValue
                    };
                    mBorrowRepository.SaveOrUpdate(borrow);

                    mClient.Borrows.Add(borrow);
                    mClientForm.RefreshBorrowedBooks();
                    selectedBook.Borrows.Add(borrow);
                    Hide();

                    MessageBox.Show(mClient.FirstName + " " + mClient.LastName + " has borrowed a new book", "OK");
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e) {
            IList<Book> foundedBooks = dataFilter.GetFilteredBookList(mBookContainer, vSearchISBN.Text, vSearchTitle.Text, vSearchAuthor.Text);
            RefreshBookList(foundedBooks);
        }
    }
}
