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
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
            SetStyleDataGripView();
            dgvMails.DataSource = MailController.GetMails(MainForm.currentUser);
        }
        private void SetStyleDataGripView()
        {
            dgvMails.EnableHeadersVisualStyles = false;
            dgvMails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMails.ColumnHeadersHeight = 40;
            dgvMails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvMails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMails.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 144, 156);
            dgvMails.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMails.RowsDefaultCellStyle.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbFrom.Text = dgvMails.CurrentRow.Cells["cFrom"].Value.ToString();
            lbBookName.Text = dgvMails.CurrentRow.Cells["cBookName"].Value.ToString();
            lbReason.Text = dgvMails.CurrentRow.Cells["cReason"].Value.ToString();
        }

        private void btAgree_Click(object sender, EventArgs e)
        {
            if (dgvMails.CurrentRow == null)
            {
                return;
            }
            Schedule schedule = new Schedule();
            schedule.refuseOrAccept = "Accept";
            Mail mail = MailController.GetMail(Convert.ToInt32(dgvMails.CurrentRow.Cells["cBookId"].Value), dgvMails.CurrentRow.Cells["cTo"].Value.ToString(), dgvMails.CurrentRow.Cells["cFrom"].Value.ToString());
            ScheduleController.AddSchedule(mail, schedule);
            MailController.Delete(dgvMails.CurrentRow.Cells["cFrom"].Value.ToString(), dgvMails.CurrentRow.Cells["cTo"].Value.ToString(), Convert.ToInt32(dgvMails.CurrentRow.Cells["cBookId"].Value));
            dgvMails.DataSource = MailController.GetMails(MainForm.currentUser);
        }

        private void btAgreeAll_Click(object sender, EventArgs e)
        {
            ScheduleController.AddAllSAcceptSchedule(MainForm.currentUser);
            MailController.DeleteAddMail(MainForm.currentUser);
            dgvMails.DataSource = MailController.GetMails(MainForm.currentUser);
        }

        private void btRepuse_Click(object sender, EventArgs e)
        {
            if (dgvMails.CurrentRow == null)
            {
                return;
            }
            ScheduleController.AddSchedule(MailController.GetMail
                (Convert.ToInt32(dgvMails.CurrentRow.Cells["cBookId"].Value),
                dgvMails.CurrentRow.Cells["cTo"].Value.ToString(),
                dgvMails.CurrentRow.Cells["cFrom"].Value.ToString())
                , new Schedule() { refuseOrAccept = "Refuse" });
            MailController.Delete(dgvMails.CurrentRow.Cells["cFrom"].Value.ToString(),
                dgvMails.CurrentRow.Cells["cTo"].Value.ToString(),
                Convert.ToInt32(dgvMails.CurrentRow.Cells["cBookId"].Value));
            dgvMails.DataSource = MailController.GetMails(MainForm.currentUser);
        }

        private void btRepuseAll_Click(object sender, EventArgs e)
        {
            if (dgvMails.CurrentRow == null)
            {
                return;
            }
            ScheduleController.AddAllRefuseSchedule(MainForm.currentUser);
            MailController.DeleteAddMail(MainForm.currentUser);
            dgvMails.DataSource = MailController.GetMails(MainForm.currentUser);
        }
    }
}
