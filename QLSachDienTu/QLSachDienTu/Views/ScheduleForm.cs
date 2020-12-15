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
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
            SetStyleDataGripView();
        }
        private void SetStyleDataGripView()
        {
            dgvSchedule.EnableHeadersVisualStyles = false;
            dgvSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ColumnHeadersHeight = 40;
            dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 144, 156);
            dgvSchedule.RowsDefaultCellStyle.BackColor = Color.White;
            dgvSchedule.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvSchedule.DataSource = ScheduleController.GetSchedules(MainForm.currentUser);
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.CurrentRow == null)
            {
                return;
            }
            if (dgvSchedule.CurrentRow.Cells["cRefuseOrAccept"].Value.ToString() == "Refuse")
            {
                using (MessengerForm form = new MessengerForm("the poster refused the request"))
                {
                    form.ShowDialog();
                }
                return;
            }

            Book book = BookController.GetBook(Convert.ToInt32(dgvSchedule.CurrentRow.Cells["cBookId"].Value));
            string path = fileController.GetSavePath(book.fileType, book.bookName);
            if (path == string.Empty)
            {
                return;
            }
            fileController.DowloadFile(book.source, path);

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.CurrentRow == null)
            {
                return;
            }
            ScheduleController.Delete(ScheduleController.GetSchedule(MainForm.currentUser, Convert.ToInt32(dgvSchedule.CurrentRow.Cells["cBookId"].Value)) as Schedule);
            dgvSchedule.DataSource = ScheduleController.GetSchedules(MainForm.currentUser);
        }
    }
}
