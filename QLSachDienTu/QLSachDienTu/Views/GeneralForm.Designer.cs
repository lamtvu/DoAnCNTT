namespace QLSachDienTu.Views
{
    partial class GeneralForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPublicOrPrivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btSearch = new FontAwesome.Sharp.IconButton();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.cbbTypeSearch = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPoP = new System.Windows.Forms.Label();
            this.lbFileType = new System.Windows.Forms.Label();
            this.lbPoster = new System.Windows.Forms.Label();
            this.lbKind = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.labelPublicOrPrivate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.btDowloadOrSend = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKinds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 450);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvBooks);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 401);
            this.panel5.TabIndex = 1;
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cName,
            this.cKind,
            this.cAuthor,
            this.cPublicOrPrivate});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(479, 401);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "id";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Visible = false;
            this.cID.Width = 60;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.DataPropertyName = "name";
            this.cName.HeaderText = "Name";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cKind
            // 
            this.cKind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cKind.DataPropertyName = "kind";
            this.cKind.HeaderText = "Kind";
            this.cKind.MinimumWidth = 6;
            this.cKind.Name = "cKind";
            this.cKind.ReadOnly = true;
            // 
            // cAuthor
            // 
            this.cAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAuthor.DataPropertyName = "author";
            this.cAuthor.HeaderText = "Author";
            this.cAuthor.MinimumWidth = 6;
            this.cAuthor.Name = "cAuthor";
            this.cAuthor.ReadOnly = true;
            // 
            // cPublicOrPrivate
            // 
            this.cPublicOrPrivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPublicOrPrivate.DataPropertyName = "publicOrPrivate";
            this.cPublicOrPrivate.HeaderText = "Public or Private";
            this.cPublicOrPrivate.MinimumWidth = 6;
            this.cPublicOrPrivate.Name = "cPublicOrPrivate";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btSearch);
            this.panel4.Controls.Add(this.tbSearchString);
            this.panel4.Controls.Add(this.cbbTypeSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 49);
            this.panel4.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_click);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btSearch.IconColor = System.Drawing.Color.White;
            this.btSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSearch.IconSize = 25;
            this.btSearch.Location = new System.Drawing.Point(434, 3);
            this.btSearch.Name = "btSearch";
            this.btSearch.Rotation = 0D;
            this.btSearch.Size = new System.Drawing.Size(39, 36);
            this.btSearch.TabIndex = 2;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSeachString
            // 
            this.tbSearchString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchString.Location = new System.Drawing.Point(294, 9);
            this.tbSearchString.Name = "tbSeachString";
            this.tbSearchString.Size = new System.Drawing.Size(134, 22);
            this.tbSearchString.TabIndex = 1;
            // 
            // cbbTypeSearch
            // 
            this.cbbTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTypeSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTypeSearch.FormattingEnabled = true;
            this.cbbTypeSearch.Items.AddRange(new object[] {
            "Kind",
            "Name",
            "Author",
            "Poster",
            "POP"});
            this.cbbTypeSearch.Location = new System.Drawing.Point(165, 9);
            this.cbbTypeSearch.Name = "cbbTypeSearch";
            this.cbbTypeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbbTypeSearch.TabIndex = 0;
            this.cbbTypeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.lbPoP);
            this.panel2.Controls.Add(this.lbFileType);
            this.panel2.Controls.Add(this.lbPoster);
            this.panel2.Controls.Add(this.lbKind);
            this.panel2.Controls.Add(this.lbAuthor);
            this.panel2.Controls.Add(this.labelPublicOrPrivate);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.labelNote);
            this.panel2.Controls.Add(this.btDowloadOrSend);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbKinds);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(479, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 450);
            this.panel2.TabIndex = 0;
            // 
            // lbPoP
            // 
            this.lbPoP.AllowDrop = true;
            this.lbPoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lbPoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbPoP.Location = new System.Drawing.Point(183, 246);
            this.lbPoP.Name = "lbPoP";
            this.lbPoP.Size = new System.Drawing.Size(132, 27);
            this.lbPoP.TabIndex = 13;
            // 
            // lbFileType
            // 
            this.lbFileType.AllowDrop = true;
            this.lbFileType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lbFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbFileType.Location = new System.Drawing.Point(105, 205);
            this.lbFileType.Name = "lbFileType";
            this.lbFileType.Size = new System.Drawing.Size(210, 27);
            this.lbFileType.TabIndex = 12;
            // 
            // lbPoster
            // 
            this.lbPoster.AllowDrop = true;
            this.lbPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lbPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbPoster.Location = new System.Drawing.Point(86, 165);
            this.lbPoster.Name = "lbPoster";
            this.lbPoster.Size = new System.Drawing.Size(229, 27);
            this.lbPoster.TabIndex = 11;
            // 
            // lbKind
            // 
            this.lbKind.AllowDrop = true;
            this.lbKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lbKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbKind.Location = new System.Drawing.Point(86, 125);
            this.lbKind.Name = "lbKind";
            this.lbKind.Size = new System.Drawing.Size(229, 27);
            this.lbKind.TabIndex = 10;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AllowDrop = true;
            this.lbAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbAuthor.Location = new System.Drawing.Point(86, 87);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(229, 27);
            this.lbAuthor.TabIndex = 9;
            // 
            // labelPublicOrPrivate
            // 
            this.labelPublicOrPrivate.AutoSize = true;
            this.labelPublicOrPrivate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPublicOrPrivate.Location = new System.Drawing.Point(3, 248);
            this.labelPublicOrPrivate.Name = "labelPublicOrPrivate";
            this.labelPublicOrPrivate.Size = new System.Drawing.Size(174, 25);
            this.labelPublicOrPrivate.TabIndex = 8;
            this.labelPublicOrPrivate.Text = "Public or private:";
            // 
            // lbName
            // 
            this.lbName.AllowDrop = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbName.Location = new System.Drawing.Point(87, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(228, 51);
            this.lbName.TabIndex = 7;
            // 
            // labelNote
            // 
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.Color.PapayaWhip;
            this.labelNote.Location = new System.Drawing.Point(34, 384);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(281, 57);
            this.labelNote.TabIndex = 6;
            // 
            // btDowloadOrSend
            // 
            this.btDowloadOrSend.BackColor = System.Drawing.Color.SlateGray;
            this.btDowloadOrSend.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btDowloadOrSend.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btDowloadOrSend.IconColor = System.Drawing.Color.White;
            this.btDowloadOrSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDowloadOrSend.IconSize = 48;
            this.btDowloadOrSend.Location = new System.Drawing.Point(105, 304);
            this.btDowloadOrSend.Name = "btDowloadOrSend";
            this.btDowloadOrSend.Rotation = 0D;
            this.btDowloadOrSend.Size = new System.Drawing.Size(144, 64);
            this.btDowloadOrSend.TabIndex = 5;
            this.btDowloadOrSend.UseVisualStyleBackColor = false;
            this.btDowloadOrSend.Click += new System.EventHandler(this.btDowloadOrSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(3, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "File type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author:";
            // 
            // lbKinds
            // 
            this.lbKinds.AutoSize = true;
            this.lbKinds.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbKinds.Location = new System.Drawing.Point(6, 127);
            this.lbKinds.Name = "lbKinds";
            this.lbKinds.Size = new System.Drawing.Size(63, 25);
            this.lbKinds.TabIndex = 2;
            this.lbKinds.Text = "Kind:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poster:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralForm";
            this.Text = "GeneralForm";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKinds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPoP;
        private System.Windows.Forms.Label lbFileType;
        private System.Windows.Forms.Label lbPoster;
        private System.Windows.Forms.Label lbKind;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label labelPublicOrPrivate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.ComboBox cbbTypeSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPublicOrPrivate;
        private System.Windows.Forms.Button btnRefresh;
        private FontAwesome.Sharp.IconButton btSearch;
        private FontAwesome.Sharp.IconButton btDowloadOrSend;
    }
}