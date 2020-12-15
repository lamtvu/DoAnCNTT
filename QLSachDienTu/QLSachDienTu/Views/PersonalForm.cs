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
    public partial class PersonalForm : Form
    {
        public PersonalForm()
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
            dgvBooks.ColumnHeadersHeight = 40;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBooks.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 144, 156);
            dgvBooks.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvBooks.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            txbMail.Text = MainForm.currentUser.mail;
            txbOffice.Text = MainForm.currentUser.office;
            txbUserName.Text = MainForm.currentUser.userName;
            dgvBooks.DataSource = BookController.getBooks(MainForm.currentUser.userName);
            pictureBox1.BackgroundImage = ImageController.ConvertByteArrayToImage(MainForm.currentUser.avatar);
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            using (EditBookForm form = new EditBookForm())
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.ShowDialog();
            }
            reload();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            using (EditUserForm form = new EditUserForm(MainForm.currentUser))
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.ShowDialog();
            }
            this.reload();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            using (EditBookForm form = new EditBookForm("Change", BookController.GetBook(Convert.ToInt32(dgvBooks.CurrentRow.Cells["cID"].Value))))
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.ShowDialog();
            }
            reload();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            using (MessengerForm form = new MessengerForm("Do you delete this book"))
            {
                form.FormBorderStyle = FormBorderStyle.None;
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    BookController.deleteBook(MainForm.currentUser.userName, Convert.ToInt32(dgvBooks.CurrentRow.Cells["cId"].Value));
                }
            }
            reload();

        }

        private void btnDowload_Click(object sender, EventArgs e)
        {
            Book book = BookController.GetBook(Convert.ToInt32(dgvBooks.CurrentRow.Cells["cId"].Value));
            string path = fileController.GetSavePath(book.fileType, book.bookName);
            if (path == string.Empty)
            {
                return;
            }
            fileController.DowloadFile(book.source,path);
        }
    }
}
