namespace QLSachDienTu.Views
{
    partial class EditBookForm
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.btBrown = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbKind = new System.Windows.Forms.ComboBox();
            this.cbbPoP = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbName.Location = new System.Drawing.Point(129, 185);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(244, 22);
            this.txbName.TabIndex = 0;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbAuthor.Location = new System.Drawing.Point(129, 296);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(244, 22);
            this.txbAuthor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kind";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-3, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "PublicOrPrivate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "File";
            // 
            // txbFile
            // 
            this.txbFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbFile.Location = new System.Drawing.Point(129, 239);
            this.txbFile.Name = "txbFile";
            this.txbFile.ReadOnly = true;
            this.txbFile.Size = new System.Drawing.Size(130, 22);
            this.txbFile.TabIndex = 12;
            // 
            // btBrown
            // 
            this.btBrown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btBrown.BackColor = System.Drawing.Color.SlateGray;
            this.btBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBrown.Location = new System.Drawing.Point(276, 218);
            this.btBrown.Name = "btBrown";
            this.btBrown.Size = new System.Drawing.Size(75, 65);
            this.btBrown.TabIndex = 13;
            this.btBrown.Text = "Brown";
            this.btBrown.UseVisualStyleBackColor = false;
            this.btBrown.Click += new System.EventHandler(this.btBrown_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEdit.BackColor = System.Drawing.Color.SlateGray;
            this.btEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEdit.Location = new System.Drawing.Point(75, 475);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(261, 49);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(75, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(261, 49);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogo.Controls.Add(this.label5);
            this.pnlLogo.Controls.Add(this.label7);
            this.pnlLogo.Controls.Add(this.panel2);
            this.pnlLogo.Controls.Add(this.panel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(400, 143);
            this.pnlLogo.TabIndex = 16;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 46);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-BOOK";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.label7.Location = new System.Drawing.Point(197, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Manager";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel2.Location = new System.Drawing.Point(110, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 3);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel1.Location = new System.Drawing.Point(19, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 3);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // cbbKind
            // 
            this.cbbKind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbKind.AutoCompleteCustomSource.AddRange(new string[] {
            "Novel",
            "Reference",
            "Textbook",
            "documentary",
            "research",
            "Other"});
            this.cbbKind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKind.FormattingEnabled = true;
            this.cbbKind.Items.AddRange(new object[] {
            "Novel",
            "Reference",
            "Textbook",
            "Documentary",
            "Research",
            "Other"});
            this.cbbKind.Location = new System.Drawing.Point(130, 343);
            this.cbbKind.Name = "cbbKind";
            this.cbbKind.Size = new System.Drawing.Size(244, 24);
            this.cbbKind.TabIndex = 17;
            // 
            // cbbPoP
            // 
            this.cbbPoP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbPoP.AutoCompleteCustomSource.AddRange(new string[] {
            "Public",
            "Private"});
            this.cbbPoP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPoP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPoP.FormattingEnabled = true;
            this.cbbPoP.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbbPoP.Location = new System.Drawing.Point(130, 395);
            this.cbbPoP.Name = "cbbPoP";
            this.cbbPoP.Size = new System.Drawing.Size(244, 24);
            this.cbbPoP.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbError);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbbPoP);
            this.panel3.Controls.Add(this.txbName);
            this.panel3.Controls.Add(this.cbbKind);
            this.panel3.Controls.Add(this.txbAuthor);
            this.panel3.Controls.Add(this.pnlLogo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btEdit);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btBrown);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 609);
            this.panel3.TabIndex = 19;
            // 
            // lbError
            // 
            this.lbError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(67, 443);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 19;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(402, 609);
            this.Controls.Add(this.panel3);
            this.Name = "EditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBookForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBookForm_FormClosing);
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.Button btBrown;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbKind;
        private System.Windows.Forms.ComboBox cbbPoP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbError;
    }
}