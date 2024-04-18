using NHibernateExample.Container;
using NHibernateExample.Managers;
using NHibernateExample.Models;
using NHibernateExample.View;

namespace NHibernateExample {
    public partial class MainForm : Form {
        private readonly ClientContainer mClientContainer;
        private readonly BookContainer mBookContainer;

        private ClientFilter mClientFilter = new();

        public MainForm() {
            InitializeComponent();

            mClientContainer = new ClientContainer(RefreshClientDataGrid);
            mBookContainer = new BookContainer(RefreshBookDataGrid);

            LoadData();
        }

        private void LoadData() {
            RefreshClientDataGrid(mClientContainer.GetClients());
            RefreshBookDataGrid(mBookContainer.GetBooks());
        }

        private void RefreshClientDataGrid(IList<Client> clients) {
            dgvClients.DataSource = null;
            dgvClients.AutoGenerateColumns = false;
            dgvClients.DataSource = clients;
        }
        private void RefreshBookDataGrid(IList<Book> books) {
            dgvBooks.DataSource = null;
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataSource = books;
        }

        private void btnClients_Click(object sender, EventArgs e) {
            pClients.Show();
            pBooks.Hide();
        }
        private void btnBooks_Click(object sender, EventArgs e) {
            pClients.Hide();
            pBooks.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            AddNewClientForm form = new AddNewClientForm(mClientContainer);
            form.ShowDialog();
        }

        private void vSearch_TextChanged(object sender, EventArgs e) {
            IList<Client> foundedClients = mClientFilter.GetFilteredClientList(mClientContainer, vSearchFirstName.Text, vSearchLastName.Text, vSearchEmail.Text);
            RefreshClientDataGrid(foundedClients);
        }

        private void dgvClients_ManageClientClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvClients.Columns["Client_Manage"].Index && e.RowIndex >= 0) {
                Client selectedClient = dgvClients.Rows[e.RowIndex].DataBoundItem as Client;

                if(selectedClient != null) {
                    ClientForm form = new ClientForm(selectedClient, mClientContainer);
                    form.ShowDialog();
                }
            }
        }
        private void dgvBooks_ManageBookClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvBooks.Columns["Book_Manage"].Index && e.RowIndex >= 0) {
                Book selectedBook = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;

                if(selectedBook != null) {
                    BookForm form = new BookForm(selectedBook, mBookContainer);
                    form.ShowDialog();
                }
            }
        }

        private void dgvBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var book = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;

            if(dgvBooks.Columns[e.ColumnIndex].Name == "Book_Available" && e.Value == null) {
                if(book != null && book.Borrows != null) {
                    bool available = true;
                    foreach(Borrow borrow in book.Borrows) {
                        if(!borrow.IsReturned()) {
                            available = false;
                            break;
                        }
                    }

                    e.Value = available;
                    e.FormattingApplied = true;
                }
            }
        }
    }
}