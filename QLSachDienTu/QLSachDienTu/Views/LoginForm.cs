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

namespace QLSachDienTu.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserController.getUser(txbUserName.Text, txbPassword.Text) == null)
            {
                lbNote.Text = "Wrong Username or Password";
            }
            else
            {
                MainForm.currentUser = UserController.getUser(txbUserName.Text, txbPassword.Text);
                //this.Close();
                lbNote.ForeColor = Color.White;
                lbNote.Font = new Font(FontFamily.GenericSansSerif, 25);
                pnlInput.Visible = false;
                pnlLogo.Location = new Point(this.Size.Width / 2 - pnlLogo.Width / 2, this.Size.Height / 2 - pnlLogo.Height / 2);
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            lbNote.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
