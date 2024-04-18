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
        private readonly Client mClient;

        internal BorrowBookForm(Client client, BookContainer bookContainer) {
            InitializeComponent();

            mClient = client;
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
                dgvAvailableBooks.DataSource = availableBookList;
            }
        }

        private void dgvAvailableBooks_SelectBookClick(object sender, DataGridViewCellEventArgs e) {
            Book selectedBook = dgvAvailableBooks.Rows[e.RowIndex].DataBoundItem as Book;

            if(selectedBook != null) {
                Borrow borrow = new Borrow() { 
                    Book = selectedBook, 
                    Client = mClient, 
                    BorrowDate = DateTime.Now
                };
                mBorrowRepository.SaveOrUpdate(borrow);

                mClient.Borrows.Add(borrow);
                selectedBook.Borrows.Add(borrow);

                MessageBox.Show(mClient.FirstName + " " + mClient.LastName + " has borrowed a new book", "OK");
            }
        }
    }
}
