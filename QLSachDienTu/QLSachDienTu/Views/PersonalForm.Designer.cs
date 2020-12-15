namespace QLSachDienTu.Views
{
    partial class PersonalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMail = new System.Windows.Forms.Label();
            this.txbOffice = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.Label();
            this.btEdit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDowload = new FontAwesome.Sharp.IconButton();
            this.btDelete = new FontAwesome.Sharp.IconButton();
            this.edit = new FontAwesome.Sharp.IconButton();
            this.btAdd = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPublicOrPrivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.txbMail);
            this.panel1.Controls.Add(this.txbOffice);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 0;
            // 
            // txbMail
            // 
            this.txbMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMail.AutoSize = true;
            this.txbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMail.Location = new System.Drawing.Point(351, 78);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(49, 20);
            this.txbMail.TabIndex = 13;
            this.txbMail.Text = "none";
            this.txbMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbOffice
            // 
            this.txbOffice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbOffice.AutoSize = true;
            this.txbOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOffice.Location = new System.Drawing.Point(351, 46);
            this.txbOffice.Name = "txbOffice";
            this.txbOffice.Size = new System.Drawing.Size(49, 20);
            this.txbOffice.TabIndex = 12;
            this.txbOffice.Text = "none";
            this.txbOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbUserName
            // 
            this.txbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUserName.AutoSize = true;
            this.txbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(351, 13);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(49, 20);
            this.txbUserName.TabIndex = 11;
            this.txbUserName.Text = "none";
            this.txbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btEdit
            // 
            this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEdit.BackColor = System.Drawing.Color.SlateGray;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btEdit.IconColor = System.Drawing.Color.White;
            this.btEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEdit.IconSize = 48;
            this.btEdit.Location = new System.Drawing.Point(737, 19);
            this.btEdit.Name = "btEdit";
            this.btEdit.Rotation = 0D;
            this.btEdit.Size = new System.Drawing.Size(51, 50);
            this.btEdit.TabIndex = 10;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(127, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(295, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(279, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Office:";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb1.Location = new System.Drawing.Point(239, 16);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(106, 20);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "User name:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 323);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.btnDowload);
            this.panel3.Controls.Add(this.btDelete);
            this.panel3.Controls.Add(this.edit);
            this.panel3.Controls.Add(this.btAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(690, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 280);
            this.panel3.TabIndex = 2;
            // 
            // btnDowload
            // 
            this.btnDowload.BackColor = System.Drawing.Color.SlateGray;
            this.btnDowload.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDowload.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnDowload.IconColor = System.Drawing.Color.White;
            this.btnDowload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDowload.IconSize = 48;
            this.btnDowload.Location = new System.Drawing.Point(23, 201);
            this.btnDowload.Name = "btnDowload";
            this.btnDowload.Rotation = 0D;
            this.btnDowload.Size = new System.Drawing.Size(75, 62);
            this.btnDowload.TabIndex = 3;
            this.btnDowload.UseVisualStyleBackColor = false;
            this.btnDowload.Click += new System.EventHandler(this.btnDowload_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.SlateGray;
            this.btDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btDelete.IconColor = System.Drawing.Color.White;
            this.btDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelete.IconSize = 48;
            this.btDelete.Location = new System.Drawing.Point(23, 133);
            this.btDelete.Name = "btDelete";
            this.btDelete.Rotation = 0D;
            this.btDelete.Size = new System.Drawing.Size(75, 62);
            this.btDelete.TabIndex = 2;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.SlateGray;
            this.edit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.edit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.edit.IconColor = System.Drawing.Color.White;
            this.edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit.IconSize = 48;
            this.edit.Location = new System.Drawing.Point(23, 65);
            this.edit.Name = "edit";
            this.edit.Rotation = 0D;
            this.edit.Size = new System.Drawing.Size(75, 62);
            this.edit.TabIndex = 1;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btAdd.IconColor = System.Drawing.Color.White;
            this.btAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAdd.IconSize = 48;
            this.btAdd.Location = new System.Drawing.Point(23, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Rotation = 0D;
            this.btAdd.Size = new System.Drawing.Size(75, 53);
            this.btAdd.TabIndex = 0;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 43);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(257, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "My Books";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(690, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 43);
            this.panel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel5.Controls.Add(this.dgvBooks);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 280);
            this.panel5.TabIndex = 4;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.ColumnHeadersHeight = 40;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cName,
            this.cKind,
            this.cFileType,
            this.cAuthor,
            this.cPublicOrPrivate});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.RowHeadersWidth = 25;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(690, 280);
            this.dgvBooks.TabIndex = 3;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "id";
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "name";
            this.cName.HeaderText = "Name";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cKind
            // 
            this.cKind.DataPropertyName = "kind";
            this.cKind.HeaderText = "Kind";
            this.cKind.MinimumWidth = 6;
            this.cKind.Name = "cKind";
            this.cKind.ReadOnly = true;
            // 
            // cFileType
            // 
            this.cFileType.DataPropertyName = "fileType";
            this.cFileType.HeaderText = "File type";
            this.cFileType.MinimumWidth = 6;
            this.cFileType.Name = "cFileType";
            this.cFileType.ReadOnly = true;
            // 
            // cAuthor
            // 
            this.cAuthor.DataPropertyName = "author";
            this.cAuthor.HeaderText = "Author";
            this.cAuthor.MinimumWidth = 6;
            this.cAuthor.Name = "cAuthor";
            this.cAuthor.ReadOnly = true;
            // 
            // cPublicOrPrivate
            // 
            this.cPublicOrPrivate.DataPropertyName = "publicOrPrivate";
            this.cPublicOrPrivate.HeaderText = "PublicOrPrivate";
            this.cPublicOrPrivate.MinimumWidth = 6;
            this.cPublicOrPrivate.Name = "cPublicOrPrivate";
            this.cPublicOrPrivate.ReadOnly = true;
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalForm";
            this.Text = "  x";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private FontAwesome.Sharp.IconButton btEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btDelete;
        private FontAwesome.Sharp.IconButton edit;
        private FontAwesome.Sharp.IconButton btAdd;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txbUserName;
        private System.Windows.Forms.Label txbMail;
        private System.Windows.Forms.Label txbOffice;
        private FontAwesome.Sharp.IconButton btnDowload;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPublicOrPrivate;
    }
}