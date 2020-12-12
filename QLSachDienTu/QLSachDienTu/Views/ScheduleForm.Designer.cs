namespace QLSachDienTu.Views
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.cBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRefuseOrAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDownload = new FontAwesome.Sharp.IconButton();
            this.btDelete = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSchedule);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 398);
            this.panel3.TabIndex = 1;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBookId,
            this.cRefuseOrAccept,
            this.cBookName});
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(800, 398);
            this.dgvSchedule.TabIndex = 0;
            // 
            // cBookId
            // 
            this.cBookId.DataPropertyName = "bookId";
            this.cBookId.HeaderText = "Book Id";
            this.cBookId.MinimumWidth = 6;
            this.cBookId.Name = "cBookId";
            this.cBookId.Visible = false;
            this.cBookId.Width = 125;
            // 
            // cRefuseOrAccept
            // 
            this.cRefuseOrAccept.DataPropertyName = "refuseOrAccept";
            this.cRefuseOrAccept.HeaderText = "RefuseOrAccept";
            this.cRefuseOrAccept.MinimumWidth = 6;
            this.cRefuseOrAccept.Name = "cRefuseOrAccept";
            this.cRefuseOrAccept.ReadOnly = true;
            this.cRefuseOrAccept.Width = 125;
            // 
            // cBookName
            // 
            this.cBookName.DataPropertyName = "bookName";
            this.cBookName.HeaderText = "Book Name";
            this.cBookName.MinimumWidth = 6;
            this.cBookName.Name = "cBookName";
            this.cBookName.ReadOnly = true;
            this.cBookName.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.btDownload);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 52);
            this.panel2.TabIndex = 0;
            // 
            // btDownload
            // 
            this.btDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDownload.BackColor = System.Drawing.Color.SlateGray;
            this.btDownload.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btDownload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btDownload.IconColor = System.Drawing.Color.White;
            this.btDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDownload.IconSize = 25;
            this.btDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDownload.Location = new System.Drawing.Point(501, 3);
            this.btDownload.Name = "btDownload";
            this.btDownload.Rotation = 0D;
            this.btDownload.Size = new System.Drawing.Size(145, 41);
            this.btDownload.TabIndex = 4;
            this.btDownload.Text = "Dowload";
            this.btDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.BackColor = System.Drawing.Color.SlateGray;
            this.btDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btDelete.IconColor = System.Drawing.Color.White;
            this.btDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelete.IconSize = 25;
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(652, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Rotation = 0D;
            this.btDelete.Size = new System.Drawing.Size(145, 41);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Delete";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btDelete;
        private FontAwesome.Sharp.IconButton btDownload;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRefuseOrAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookName;
    }
}