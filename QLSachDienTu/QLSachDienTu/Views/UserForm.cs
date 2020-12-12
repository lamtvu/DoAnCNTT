using QLSachDienTu.Controllers;
using QLSachDienTu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSachDienTu.Views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            SetStyleDataGripView();
            closeAdd();
            if (MainForm.currentUser.office != "admin")
            {
                pnFunction.Visible = false;
            }
            tbSearchString.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSearchString.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection colPoster = new AutoCompleteStringCollection();
            colPoster.AddRange(UserController.GetNameUsers());
            tbSearchString.AutoCompleteCustomSource = colPoster;
            dgvUsers.DataSource = UserController.getUsers();
        }
        private void SetStyleDataGripView()
        {
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 144, 156);
            dgvUsers.RowsDefaultCellStyle.BackColor = Color.White;
            dgvUsers.RowsDefaultCellStyle.ForeColor = Color.Black;
        }
        private void closeAdd()
        {
            pnAdd.Enabled = false;
            pnAdd.Visible = false;
            btBrown.Enabled = false;
            btBrown.Visible = false;
            tbName.ReadOnly = true;
            tbMail.ReadOnly = true;
            cbbOffice.Enabled = false;
            pnFunction.Visible = true;
            ptbAvatar.BackgroundImage = null;
            tbName.Text = "";
            tbMail.Text = "";
            cbbOffice.SelectedIndex = 1;
        }
        private void OpenAdd()
        {
            pnAdd.Enabled = true;
            pnAdd.Visible = true;
            btBrown.Enabled = true;
            btBrown.Visible = true;
            tbName.ReadOnly = false;
            tbMail.ReadOnly = false;
            cbbOffice.Enabled = true;
            ptbAvatar.BackgroundImage = null;
            tbName.Text = "";
            tbMail.Text = "";
            cbbOffice.SelectedIndex = 1;
            txbPass.Text = "";
            pnFunction.Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenAdd();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            closeAdd();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = UserController.GetUser(dgvUsers.CurrentRow.Cells["cUsername"].Value.ToString());
            tbMail.Text = user.mail;
            tbName.Text = user.userName;
            cbbOffice.Text = user.office;
            ptbAvatar.BackgroundImage = ImageController.ConvertByteArrayToImage(user.avatar);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (UserController.GetUser(tbName.Text) != null)
            {
                using (MessengerForm form = new MessengerForm("Username already exists"))
                {
                    form.ShowDialog();
                }
                return;
            }

            User user = new User();
            user.userName = tbName.Text.Trim();
            user.office = cbbOffice.Text;
            user.mail = tbMail.Text.Trim();
            user.password = txbPass.Text;
            user.avatar = ImageController.ConvertToByteArray(ptbAvatar.BackgroundImage);
            UserController.Add(user);
            dgvUsers.DataSource = UserController.getUsers();
        }

        private void btBrown_Click(object sender, EventArgs e)
        {
            string path = fileController.GetOpenImageFilePath();
            string fileType = fileController.GetFileName(path);
            if (path == string.Empty)
            {
                return;
            }
            if (fileType != "png" && fileType != ".jpg" && fileType != "jfif" && fileType != "peg")
            {
                MessengerForm form = new MessengerForm("File is invalid.");
                form.ShowDialog();
                return;
            }
            ptbAvatar.BackgroundImage = new Bitmap(path);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                return;
            }
            UserController.Delete(UserController.GetUser(dgvUsers.CurrentRow.Cells["cUsername"].Value.ToString()));
            dgvUsers.DataSource = UserController.getUsers();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = UserController.SearchUser(tbSearchString.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = UserController.getUsers();
            tbSearchString.Text = "";
            tbMail.Text = "";
            tbName.Text = "";
            cbbOffice.SelectedIndex = 1;
        }
    }
}
