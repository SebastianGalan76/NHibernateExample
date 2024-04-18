using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample.View {
    public partial class ClientForm : Form {
        private readonly ClientContainer mClientContainer;
        private readonly Client mClient;

        internal ClientForm(Client client, ClientContainer clientContainer) {
            InitializeComponent();

            mClient = client;
            vFirstName.Text = client.FirstName;
            vLastName.Text = client.LastName;
            vEmail.Text = client.Email;

            mClientContainer = clientContainer;
            if(client.Borrows != null && client.Borrows.Count > 0) {
                dgvBorrowedBooks.DataSource = client.Borrows.Where(b => !b.IsReturned()).ToList();
            }
        }

        private void UpdateUser() {
            mClient.FirstName = vFirstName.Text;
            mClient.LastName = vLastName.Text;
            mClient.Email = vEmail.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            mClientContainer.RemoveClient(mClient);
            Hide();
        }

        private void dgvBorrowedBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var borrow = dgvBorrowedBooks.Rows[e.RowIndex].DataBoundItem as Borrow;

            if(dgvBorrowedBooks.Columns[e.ColumnIndex].Name == "Author" && e.Value == null) {
                if(borrow != null && borrow.Book != null) {
                    e.Value = borrow.Book.Author;
                    e.FormattingApplied = true;
                }
            } else if(dgvBorrowedBooks.Columns[e.ColumnIndex].Name == "Title" && e.Value == null) {
                if(borrow != null && borrow.Book != null) {
                    e.Value = borrow.Book.Title;
                    e.FormattingApplied = true;
                }
            } else if(dgvBorrowedBooks.Columns[e.ColumnIndex].Name == "ISBN" && e.Value == null) {
                if(borrow != null && borrow.Book != null) {
                    e.Value = borrow.Book.ISBN;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvBorrowedBooks_ManageClientClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvBorrowedBooks.Columns["Return"].Index && e.RowIndex >= 0) {
                Borrow selectedBorrowObj = dgvBorrowedBooks.Rows[e.RowIndex].DataBoundItem as Borrow;

                if(selectedBorrowObj != null) {
                    selectedBorrowObj.Return();
                    mClientContainer.UpdateClient(mClient);

                    if(mClient.Borrows != null && mClient.Borrows.Count > 0) {
                        dgvBorrowedBooks.DataSource = mClient.Borrows.Where(b => !b.IsReturned()).ToList();
                    }
                    MessageBox.Show("The book has been returned.", "OK");
                }
            }
        }
    }
}
