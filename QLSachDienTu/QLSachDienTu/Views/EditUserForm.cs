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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSachDienTu.Views
{
    public partial class EditUserForm : Form
    {
        private bool close = true;
        public EditUserForm()
        {
            InitializeComponent();
        }
        public EditUserForm(User user)
        {
            InitializeComponent();
            if (user.avatar != null)
                ptbAvatar.BackgroundImage = ImageController.ConvertByteArrayToImage(user.avatar);
            txbUserName.Text = user.userName;
            txbPassword.Text = user.password;
            txbGmail.Text = user.mail;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput() != "")
            {
                lbError.Text = CheckInput();
                lbError.Location = new Point(panel6.Width / 2 - lbError.Width / 2, lbError.Location.Y);
                close = false;
                return;
            }
            close = true;
            User user = new User()
            {
                mail = txbGmail.Text.Trim(),
                //userName = txbUserName.Text.Trim(),
                password = txbPassword.Text,
            };
            if (ptbAvatar.BackgroundImage != null)
                user.avatar = ImageController.ConvertToByteArray(ptbAvatar.BackgroundImage);
            UserController.UpdateUser(MainForm.currentUser, user);
            MainForm.currentUser = UserController.GetUser(MainForm.currentUser.userName);

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

        private void button2_Click(object sender, EventArgs e)
        {
            string path = fileController.GetOpenImageFilePath();
            string fileType = fileController.GetFileName(path);
            if (path == string.Empty)
            {
                return;
            }
            if (fileType != "png" && fileType != "jpg" && fileType != "jfif" && fileType != "peg")
            {
                MessengerForm form = new MessengerForm("File is invalid.");
                form.ShowDialog();
                return;
            }
            ptbAvatar.BackgroundImage = new Bitmap(path);
        }

        private void EditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
            {
                e.Cancel = true;
            }
        }
        private string CheckInput()
        {
            string error = "";
            if (txbPassword.Text.Length < 5 || txbPassword.Text.Length >= 20)
            {
                error += "Password is invalid. ";
            }
            if (Regex.IsMatch(txbGmail.Text, @"^[\w_-]{3,}@[\w-]{3,}(.[\w]{2,}){1,3}$") == false)
            {
                error += "mail is invalid.";
            }
            return error;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close = true;
        }
    }
}
