using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSachDienTu.Controllers;
using QLSachDienTu.Models;

namespace QLSachDienTu.Views
{
    public partial class EditBookForm : Form
    {
        private int formFunction;
        private Book currentBook;
        private bool close = true;
        public EditBookForm()
        {
            InitializeComponent();
            btEdit.Text = "Add";
            formFunction = 1;
            cbbKind.SelectedIndex = 0;
            cbbPoP.SelectedIndex = 0;
        }
        public EditBookForm(string buttonName, Book book)
        {
            InitializeComponent();
            btEdit.Text = buttonName;
            txbAuthor.Text = book.author;
            txbFile.Text = book.bookName + "." + book.fileType;
            txbName.Text = book.bookName;
            cbbKind.SelectedItem = book.kind;
            cbbPoP.SelectedItem = book.privateOrPublic;
            if (buttonName == "Change")
            {
                formFunction = 0;
            }
            else
            {
                formFunction = -1;
            }
            currentBook = book;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (formFunction == -1)
            {
                BookController.deleteBook(MainForm.currentUser.userName, currentBook.id);
                return;
            }
            if (CheckInput() != "")
            {
                close = false;
                lbError.Text = CheckInput();
                return;
            }
            close = true;
            Book book = new Book()
            {
                bookName = txbName.Text.Trim(),
                author = txbAuthor.Text.Trim(),
                kind = cbbKind.Text.Trim(),
                fileType = fileController.GetFileName(txbFile.Text),
                privateOrPublic = cbbPoP.Text.Trim(),
                mails = new List<Mail>(),
            };
            if (File.Exists(txbFile.Text))
                book.source = fileController.ConvertToByteArray(txbFile.Text);
            if (formFunction == 1)
            {
                BookController.AddBook(MainForm.currentUser.userName, book);
                return;
            }
            else
            if (formFunction == 0)
            {
                BookController.updateBook(Convert.ToInt32(currentBook.id), book);
                return;
            }
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
        }

        private string CheckInput()
        {
            string error = "";
            if (!Regex.IsMatch(txbName.Text.Trim(), @"^[\w\s]{5,20}$"))
            {
                error += "Name is invalid. ";
            }
            if (txbFile.Text == "" || txbFile.Text == string.Empty)
            {
                error += "File is null.";
            }
            return error;
        }

        private void EditBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close != true)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            close = true;
        }

        private void btBrown_Click(object sender, EventArgs e)
        {
            txbFile.Text = fileController.GetOpenBookFilePath();
        }
    }
}
