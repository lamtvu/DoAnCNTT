using QLSachDienTu.Controllers;
using QLSachDienTu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSachDienTu.Views
{
    public partial class RequestForm : Form
    {
        private Book currentBook;
        private User toUser;
        public RequestForm(Book currentBook, User toUserValue)
        {
            InitializeComponent();
            lbTo.Text = toUserValue.userName;
            this.FormBorderStyle = FormBorderStyle.None;
            this.currentBook = currentBook;
            toUser = toUserValue;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MailController.GetMail(currentBook.id, toUser.userName, MainForm.currentUser.userName) != null)
            {
                using (MessengerForm form = new MessengerForm("you have submitted a request"))
                {
                    form.ShowDialog();
                    return;
                }
            }
            if (ScheduleController.GetSchedule(MainForm.currentUser, currentBook.id) != null)
            {
                using (MessengerForm form = new MessengerForm("this book was in schedule"))
                {
                    form.ShowDialog();
                    return;
                }
            }
            Mail mail = new Mail();
            mail.reason = rtbReason.Text;
            MailController.Add(MainForm.currentUser, toUser, currentBook, mail);
        }
    }
}
