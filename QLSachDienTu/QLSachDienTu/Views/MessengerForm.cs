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
    public partial class MessengerForm : Form
    {
        public MessengerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public MessengerForm(string text)
        {
            InitializeComponent();
            lbInformation.Text = text;
            lbInformation.Location = new Point(panel2.Width / 2 - lbInformation.Size.Width / 2, panel2.Height / 2 - lbInformation.Size.Height / 2);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
