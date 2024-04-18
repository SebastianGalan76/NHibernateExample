using NHibernateExample.Container;
using NHibernateExample.Models;

namespace NHibernateExample.View {
    public partial class ClientForm : Form {
        private readonly ClientContainer mClientContainer;
        private readonly BookContainer mBookContainer;
        private readonly Client mClient;

        internal ClientForm(Client client, ClientContainer clientContainer, BookContainer bookContainer) {
            InitializeComponent();

            mClient = client;
            vFirstName.Text = client.FirstName;
            vLastName.Text = client.LastName;
            vEmail.Text = client.Email;

            mClientContainer = clientContainer;
            mBookContainer = bookContainer;
            if(client.Borrows != null && client.Borrows.Count > 0) {
                dgvBorrowedBooks.AutoGenerateColumns = false;
                dgvBorrowedBooks.DataSource = client.Borrows.Where(b => !b.IsReturned()).ToList();
            }

            btnSaveChanges.Visible = false;
            btnCancelChanges.Visible = false;
        }

        private void UpdateClient() {
            mClient.FirstName = vFirstName.Text;
            mClient.LastName = vLastName.Text;
            mClient.Email = vEmail.Text;

            mClientContainer.UpdateClient(mClient);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            mClientContainer.RemoveClient(mClient);
            Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) {
            UpdateClient();

            btnSaveChanges.Visible = false;
            btnCancelChanges.Visible = false;
        }

        private void btnCancelChanges_Click(object sender, EventArgs e) {
            vFirstName.Text = mClient.FirstName;
            vLastName.Text = mClient.LastName;
            vEmail.Text = mClient.Email;

            btnSaveChanges.Visible = false;
            btnCancelChanges.Visible = false;
        }

        private void btnBorrow_Click(object sender, EventArgs e) {
            BorrowBookForm form = new BorrowBookForm(mClient, mBookContainer);
            form.ShowDialog();
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

        private void vData_TextChanged(object sender, EventArgs e) {
            btnSaveChanges.Visible = true;
            btnCancelChanges.Visible = true;
        }
    }
}
