namespace QLSachDienTu.Views
{
    partial class MailForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvMails = new System.Windows.Forms.DataGridView();
            this.cFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReason = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRepuseAll = new FontAwesome.Sharp.IconButton();
            this.btRepuse = new FontAwesome.Sharp.IconButton();
            this.btAgreeAll = new FontAwesome.Sharp.IconButton();
            this.btAgree = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvMails);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 398);
            this.panel4.TabIndex = 3;
            // 
            // dgvMails
            // 
            this.dgvMails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFrom,
            this.cBookId,
            this.cTo,
            this.cBookName,
            this.cReason});
            this.dgvMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMails.Location = new System.Drawing.Point(0, 0);
            this.dgvMails.MultiSelect = false;
            this.dgvMails.Name = "dgvMails";
            this.dgvMails.RowHeadersWidth = 51;
            this.dgvMails.RowTemplate.Height = 24;
            this.dgvMails.Size = new System.Drawing.Size(600, 398);
            this.dgvMails.TabIndex = 1;
            this.dgvMails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMails_CellClick);
            // 
            // cFrom
            // 
            this.cFrom.DataPropertyName = "from";
            this.cFrom.HeaderText = "From";
            this.cFrom.MinimumWidth = 6;
            this.cFrom.Name = "cFrom";
            this.cFrom.ReadOnly = true;
            this.cFrom.Width = 125;
            // 
            // cBookId
            // 
            this.cBookId.DataPropertyName = "bookId";
            this.cBookId.HeaderText = "BookId";
            this.cBookId.MinimumWidth = 6;
            this.cBookId.Name = "cBookId";
            this.cBookId.ReadOnly = true;
            this.cBookId.Visible = false;
            this.cBookId.Width = 125;
            // 
            // cTo
            // 
            this.cTo.DataPropertyName = "to";
            this.cTo.HeaderText = "To";
            this.cTo.MinimumWidth = 6;
            this.cTo.Name = "cTo";
            this.cTo.ReadOnly = true;
            this.cTo.Width = 125;
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
            // cReason
            // 
            this.cReason.DataPropertyName = "reason";
            this.cReason.HeaderText = "Reason";
            this.cReason.MinimumWidth = 6;
            this.cReason.Name = "cReason";
            this.cReason.ReadOnly = true;
            this.cReason.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.lbBookName);
            this.panel3.Controls.Add(this.lbFrom);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbReason);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(600, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 398);
            this.panel3.TabIndex = 2;
            // 
            // lbBookName
            // 
            this.lbBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbBookName.Location = new System.Drawing.Point(13, 91);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(175, 23);
            this.lbBookName.TabIndex = 5;
            // 
            // lbFrom
            // 
            this.lbFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbFrom.Location = new System.Drawing.Point(13, 32);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(175, 23);
            this.lbFrom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reason:";
            // 
            // lbReason
            // 
            this.lbReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbReason.Location = new System.Drawing.Point(10, 153);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(178, 236);
            this.lbReason.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.btRepuseAll);
            this.panel2.Controls.Add(this.btRepuse);
            this.panel2.Controls.Add(this.btAgreeAll);
            this.panel2.Controls.Add(this.btAgree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 52);
            this.panel2.TabIndex = 0;
            // 
            // btRepuseAll
            // 
            this.btRepuseAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btRepuseAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRepuseAll.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btRepuseAll.IconColor = System.Drawing.Color.Black;
            this.btRepuseAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRepuseAll.IconSize = 25;
            this.btRepuseAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRepuseAll.Location = new System.Drawing.Point(522, 12);
            this.btRepuseAll.Name = "btRepuseAll";
            this.btRepuseAll.Rotation = 0D;
            this.btRepuseAll.Size = new System.Drawing.Size(145, 32);
            this.btRepuseAll.TabIndex = 3;
            this.btRepuseAll.Text = "Repuse All";
            this.btRepuseAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRepuseAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRepuseAll.UseVisualStyleBackColor = true;
            this.btRepuseAll.Click += new System.EventHandler(this.btRepuseAll_Click);
            // 
            // btRepuse
            // 
            this.btRepuse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btRepuse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRepuse.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btRepuse.IconColor = System.Drawing.Color.Black;
            this.btRepuse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRepuse.IconSize = 25;
            this.btRepuse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRepuse.Location = new System.Drawing.Point(357, 12);
            this.btRepuse.Name = "btRepuse";
            this.btRepuse.Rotation = 0D;
            this.btRepuse.Size = new System.Drawing.Size(145, 32);
            this.btRepuse.TabIndex = 2;
            this.btRepuse.Text = "Repuse";
            this.btRepuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRepuse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRepuse.UseVisualStyleBackColor = true;
            this.btRepuse.Click += new System.EventHandler(this.btRepuse_Click);
            // 
            // btAgreeAll
            // 
            this.btAgreeAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btAgreeAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgreeAll.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btAgreeAll.IconColor = System.Drawing.Color.Black;
            this.btAgreeAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAgreeAll.IconSize = 25;
            this.btAgreeAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgreeAll.Location = new System.Drawing.Point(193, 12);
            this.btAgreeAll.Name = "btAgreeAll";
            this.btAgreeAll.Rotation = 0D;
            this.btAgreeAll.Size = new System.Drawing.Size(145, 32);
            this.btAgreeAll.TabIndex = 1;
            this.btAgreeAll.Text = "Agree All";
            this.btAgreeAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgreeAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAgreeAll.UseVisualStyleBackColor = true;
            this.btAgreeAll.Click += new System.EventHandler(this.btAgreeAll_Click);
            // 
            // btAgree
            // 
            this.btAgree.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btAgree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgree.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btAgree.IconColor = System.Drawing.Color.Black;
            this.btAgree.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAgree.IconSize = 25;
            this.btAgree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgree.Location = new System.Drawing.Point(32, 12);
            this.btAgree.Name = "btAgree";
            this.btAgree.Rotation = 0D;
            this.btAgree.Size = new System.Drawing.Size(145, 32);
            this.btAgree.TabIndex = 0;
            this.btAgree.Text = "Agree";
            this.btAgree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgree.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAgree.UseVisualStyleBackColor = true;
            this.btAgree.Click += new System.EventHandler(this.btAgree_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMails;
        private FontAwesome.Sharp.IconButton btRepuseAll;
        private FontAwesome.Sharp.IconButton btRepuse;
        private FontAwesome.Sharp.IconButton btAgreeAll;
        private FontAwesome.Sharp.IconButton btAgree;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReason;
    }
}