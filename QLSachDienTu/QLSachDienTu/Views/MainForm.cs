using FontAwesome.Sharp;
using QLSachDienTu.Views;
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

namespace QLSachDienTu
{
    public partial class MainForm : Form
    {
        private IconButton currentIconButton;
        private Panel LeftBorderPanel;
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();
            LeftBorderPanel = new Panel();
            LeftBorderPanel.Size = new Size(10, 70);
            LeftBorderPanel.BackColor = Color.Black;
            LeftBorderPanel.Visible = false;
            panelLeftMenu.Controls.Add(LeftBorderPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = string.Empty;
            OpenChildForm(new LogoForm());
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            panelDestop.Controls.Add(childForm);
            panelDestop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                Disable();
                IconButton iconButton = sender as IconButton;
                currentIconButton = iconButton;
                iconButton.ImageAlign = ContentAlignment.MiddleRight;
                iconButton.TextAlign = ContentAlignment.MiddleCenter;
                iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconButton.BackColor = Color.Gainsboro;
                iconButton.ForeColor = Color.Black;
                iconButton.IconColor = Color.Black;

                LeftBorderPanel.Location = new Point(10, iconButton.Location.Y);
                LeftBorderPanel.Visible = true;
                LeftBorderPanel.BringToFront();

                iconPictureBox_CurrentIcon.IconChar = iconButton.IconChar;
                labelCurrentIcon.Text = iconButton.Text;
            }
        }
        private void Disable()
        {
            if (currentIconButton != null)
            {
                currentIconButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentIconButton.TextAlign = ContentAlignment.MiddleLeft;
                currentIconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentIconButton.BackColor = Color.FromArgb(55, 71, 79);
                currentIconButton.ForeColor = Color.Gainsboro;
                currentIconButton.IconColor = Color.Gainsboro;
                LeftBorderPanel.Visible = false;
                currentIconButton = null;
            }
        }
        private void Reset()
        {
            Disable();
            iconPictureBox_CurrentIcon.IconChar = IconChar.Home;
            labelCurrentIcon.Text = "Home";

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Logo_click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new LogoForm());
        }
        private void btPersonal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonalForm());
            ActiveButton(sender);
        }

        private void btGeneral_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GeneralForm());
            ActiveButton(sender);

        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
            ActiveButton(sender);

        }

        private void btMail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MailForm());
            ActiveButton(sender);
        }

        private void btSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleForm());
            ActiveButton(sender);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btform_hover(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            iconButton.BackColor = Color.Gainsboro;
            iconButton.IconColor = Color.Black;
        }
        private void btform_leave(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            iconButton.BackColor = Color.FromArgb(55, 71, 79);
            iconButton.IconColor = Color.Gainsboro;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
