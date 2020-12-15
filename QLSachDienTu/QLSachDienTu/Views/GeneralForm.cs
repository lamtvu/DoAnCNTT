using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSachDienTu.Controllers;
using QLSachDienTu.Models;

namespace QLSachDienTu.Views
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
            SetStyleDataGripView();
        }
        private void SetStyleDataGripView()
        {
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBooks.ColumnHeadersHeight = 50;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 144, 156);
            dgvBooks.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvBooks.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = Controllers.BookController.GetBooks();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = BookController.GetBook(Convert.ToInt32(dgvBooks.CurrentRow.Cells["cID"].Value));
            lbName.Text = book.bookName;
            lbPoP.Text = book.privateOrPublic;
            lbKind.Text = book.kind;
            lbAuthor.Text = book.author;
            lbPoster.Text = book.posterName;
            lbFileType.Text = book.fileType;
        }

        private void btDowloadOrSend_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow.Cells["cPublicOrPrivate"].Value.ToString() == "Public" || MainForm.currentUser.office == "admin" || BookController.IsOwerBook(Convert.ToInt32(dgvBooks.CurrentRow.Cells["cID"].Value), MainForm.currentUser))
            {
                Cursor.Current = Cursors.WaitCursor;
                Book book = BookController.GetBook(Convert.ToInt32(dgvBooks.CurrentRow.Cells["cID"].Value));
                string path = fileController.GetSavePath(book.fileType, book.bookName);
                if (path == string.Empty)
                {
                    return;
                }
                fileController.DowloadFile(book.source, path);
                Cursor.Current = Cursors.Default;
                return;
            }
            Book tempBook = BookController.GetBook(Convert.ToInt32(dgvBooks.CurrentRow.Cells["cID"].Value));
            using (RequestForm form = new RequestForm(tempBook, UserController.GetUser(tempBook.posterName)))
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchString.Text = "";
            var cbb = sender as ComboBox;
            switch (cbb.Text)
            {
                case "Name":
                    tbSearchString.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tbSearchString.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    AutoCompleteStringCollection colBookNames = new AutoCompleteStringCollection();
                    colBookNames.AddRange(BookController.GetBookNames());
                    tbSearchString.AutoCompleteCustomSource = colBookNames;
                    break;
                case "Author":
                    tbSearchString.AutoCompleteMode = AutoCompleteMode.None;
                    tbSearchString.AutoCompleteSource = AutoCompleteSource.None;
                    break;
                case "Kind":
                    tbSearchString.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tbSearchString.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    collection.Add("Novel");
                    collection.Add("Reference");
                    collection.Add("Textbook");
                    collection.Add("Documentary");
                    collection.Add("Research");
                    collection.Add("Other");
                    tbSearchString.AutoCompleteCustomSource = collection;
                    break;
                case "POP":
                    tbSearchString.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tbSearchString.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    AutoCompleteStringCollection colPOP = new AutoCompleteStringCollection();
                    colPOP.Add("Public");
                    colPOP.Add("Private");
                    tbSearchString.AutoCompleteCustomSource = colPOP;
                    break;
                case "Poster":
                    tbSearchString.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tbSearchString.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    AutoCompleteStringCollection colPoster = new AutoCompleteStringCollection();
                    colPoster.AddRange(UserController.GetNameUsers());
                    tbSearchString.AutoCompleteCustomSource = colPoster;
                    break;
                default:
                    break;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            switch (cbbTypeSearch.Text)
            {
                case "Name":
                    dgvBooks.DataSource = BookController.SearchNameBooks(tbSearchString.Text);
                    break;
                case "Author":
                    dgvBooks.DataSource = BookController.SearchAuthorBooks(tbSearchString.Text);
                    break;
                case "Kind":
                    dgvBooks.DataSource = BookController.SearchKindBooks(tbSearchString.Text);
                    break;
                case "POP":
                    dgvBooks.DataSource = BookController.SearchPOPBooks(tbSearchString.Text);
                    break;
                case "Poster":
                    dgvBooks.DataSource = BookController.SearchPosterBooks(tbSearchString.Text);
                    break;
                default:
                    break;
            }
        }

        private void btnRefresh_click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = BookController.GetBooks();
            cbbTypeSearch.Text = "";
            tbSearchString.Text = "";
            lbName.Text = "";
            lbKind.Text = "";
            lbFileType.Text = "";
            lbAuthor.Text = "";
            lbPoP.Text = "";
            lbPoster.Text = "";
        }
    }
}
