namespace QLSachDienTu
{
    partial class MainForm
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
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.btLogout = new FontAwesome.Sharp.IconButton();
            this.btSchedule = new FontAwesome.Sharp.IconButton();
            this.btMail = new FontAwesome.Sharp.IconButton();
            this.btUsers = new FontAwesome.Sharp.IconButton();
            this.btGeneral = new FontAwesome.Sharp.IconButton();
            this.btPersonal = new FontAwesome.Sharp.IconButton();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btMinimum = new FontAwesome.Sharp.IconButton();
            this.btMaximum = new FontAwesome.Sharp.IconButton();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.labelCurrentIcon = new System.Windows.Forms.Label();
            this.iconPictureBox_CurrentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelDestop = new System.Windows.Forms.Panel();
            this.panelLeftMenu.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_CurrentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelLeftMenu.Controls.Add(this.btLogout);
            this.panelLeftMenu.Controls.Add(this.btSchedule);
            this.panelLeftMenu.Controls.Add(this.btMail);
            this.panelLeftMenu.Controls.Add(this.btUsers);
            this.panelLeftMenu.Controls.Add(this.btGeneral);
            this.panelLeftMenu.Controls.Add(this.btPersonal);
            this.panelLeftMenu.Controls.Add(this.panelLeftTop);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(250, 552);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogout.IconSize = 48;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(5, 480);
            this.btLogout.Name = "btLogout";
            this.btLogout.Rotation = 0D;
            this.btLogout.Size = new System.Drawing.Size(230, 70);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Log out";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btSchedule
            // 
            this.btSchedule.FlatAppearance.BorderSize = 0;
            this.btSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSchedule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btSchedule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSchedule.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btSchedule.IconColor = System.Drawing.Color.Gainsboro;
            this.btSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSchedule.IconSize = 48;
            this.btSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSchedule.Location = new System.Drawing.Point(5, 415);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Rotation = 0D;
            this.btSchedule.Size = new System.Drawing.Size(230, 70);
            this.btSchedule.TabIndex = 6;
            this.btSchedule.Text = "Schedule";
            this.btSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSchedule.UseVisualStyleBackColor = true;
            this.btSchedule.Click += new System.EventHandler(this.btSchedule_Click);
            // 
            // btMail
            // 
            this.btMail.FlatAppearance.BorderSize = 0;
            this.btMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btMail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btMail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btMail.IconColor = System.Drawing.Color.Gainsboro;
            this.btMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMail.IconSize = 48;
            this.btMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMail.Location = new System.Drawing.Point(5, 340);
            this.btMail.Name = "btMail";
            this.btMail.Rotation = 0D;
            this.btMail.Size = new System.Drawing.Size(230, 70);
            this.btMail.TabIndex = 5;
            this.btMail.Text = "Mail";
            this.btMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMail.UseVisualStyleBackColor = true;
            this.btMail.Click += new System.EventHandler(this.btMail_Click);
            // 
            // btUsers
            // 
            this.btUsers.FlatAppearance.BorderSize = 0;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btUsers.IconColor = System.Drawing.Color.Gainsboro;
            this.btUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btUsers.IconSize = 48;
            this.btUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsers.Location = new System.Drawing.Point(5, 265);
            this.btUsers.Name = "btUsers";
            this.btUsers.Rotation = 0D;
            this.btUsers.Size = new System.Drawing.Size(230, 70);
            this.btUsers.TabIndex = 3;
            this.btUsers.Text = "Users";
            this.btUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btGeneral
            // 
            this.btGeneral.FlatAppearance.BorderSize = 0;
            this.btGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGeneral.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.btGeneral.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btGeneral.IconColor = System.Drawing.Color.Gainsboro;
            this.btGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btGeneral.IconSize = 48;
            this.btGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGeneral.Location = new System.Drawing.Point(5, 190);
            this.btGeneral.Name = "btGeneral";
            this.btGeneral.Rotation = 0D;
            this.btGeneral.Size = new System.Drawing.Size(230, 70);
            this.btGeneral.TabIndex = 2;
            this.btGeneral.Text = "General";
            this.btGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGeneral.UseVisualStyleBackColor = true;
            this.btGeneral.Click += new System.EventHandler(this.btGeneral_Click);
            // 
            // btPersonal
            // 
            this.btPersonal.FlatAppearance.BorderSize = 0;
            this.btPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPersonal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btPersonal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btPersonal.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btPersonal.IconColor = System.Drawing.Color.Gainsboro;
            this.btPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btPersonal.IconSize = 48;
            this.btPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPersonal.Location = new System.Drawing.Point(5, 115);
            this.btPersonal.Name = "btPersonal";
            this.btPersonal.Rotation = 0D;
            this.btPersonal.Size = new System.Drawing.Size(230, 70);
            this.btPersonal.TabIndex = 1;
            this.btPersonal.Text = "Personal";
            this.btPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPersonal.UseVisualStyleBackColor = true;
            this.btPersonal.Click += new System.EventHandler(this.btPersonal_Click);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelLeftTop.Controls.Add(this.label2);
            this.panelLeftTop.Controls.Add(this.label1);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(250, 100);
            this.panelLeftTop.TabIndex = 0;
            this.panelLeftTop.Click += new System.EventHandler(this.Logo_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(59, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manager";
            this.label2.Click += new System.EventHandler(this.Logo_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Book";
            this.label1.Click += new System.EventHandler(this.Logo_click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.btMinimum);
            this.panelTop.Controls.Add(this.btMaximum);
            this.panelTop.Controls.Add(this.btExit);
            this.panelTop.Controls.Add(this.labelCurrentIcon);
            this.panelTop.Controls.Add(this.iconPictureBox_CurrentIcon);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(912, 100);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btMinimum
            // 
            this.btMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimum.FlatAppearance.BorderSize = 0;
            this.btMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimum.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btMinimum.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btMinimum.IconColor = System.Drawing.Color.Gainsboro;
            this.btMinimum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMinimum.IconSize = 30;
            this.btMinimum.Location = new System.Drawing.Point(799, 3);
            this.btMinimum.Name = "btMinimum";
            this.btMinimum.Rotation = 0D;
            this.btMinimum.Size = new System.Drawing.Size(30, 30);
            this.btMinimum.TabIndex = 4;
            this.btMinimum.UseVisualStyleBackColor = true;
            this.btMinimum.Click += new System.EventHandler(this.btMinimum_Click);
            this.btMinimum.MouseEnter += new System.EventHandler(this.btform_hover);
            this.btMinimum.MouseLeave += new System.EventHandler(this.btform_leave);
            // 
            // btMaximum
            // 
            this.btMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximum.FlatAppearance.BorderSize = 0;
            this.btMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximum.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btMaximum.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btMaximum.IconColor = System.Drawing.Color.Gainsboro;
            this.btMaximum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMaximum.IconSize = 30;
            this.btMaximum.Location = new System.Drawing.Point(839, 5);
            this.btMaximum.Name = "btMaximum";
            this.btMaximum.Rotation = 0D;
            this.btMaximum.Size = new System.Drawing.Size(30, 30);
            this.btMaximum.TabIndex = 3;
            this.btMaximum.UseVisualStyleBackColor = true;
            this.btMaximum.Click += new System.EventHandler(this.btMaximum_Click);
            this.btMaximum.MouseEnter += new System.EventHandler(this.btform_hover);
            this.btMaximum.MouseLeave += new System.EventHandler(this.btform_leave);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExit.IconSize = 30;
            this.btExit.Location = new System.Drawing.Point(879, 5);
            this.btExit.Name = "btExit";
            this.btExit.Rotation = 0D;
            this.btExit.Size = new System.Drawing.Size(30, 30);
            this.btExit.TabIndex = 2;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            this.btExit.MouseEnter += new System.EventHandler(this.btform_hover);
            this.btExit.MouseLeave += new System.EventHandler(this.btform_leave);
            // 
            // labelCurrentIcon
            // 
            this.labelCurrentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelCurrentIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentIcon.Location = new System.Drawing.Point(169, 27);
            this.labelCurrentIcon.Name = "labelCurrentIcon";
            this.labelCurrentIcon.Size = new System.Drawing.Size(502, 57);
            this.labelCurrentIcon.TabIndex = 1;
            this.labelCurrentIcon.Text = "Home";
            this.labelCurrentIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // iconPictureBox_CurrentIcon
            // 
            this.iconPictureBox_CurrentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.iconPictureBox_CurrentIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox_CurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox_CurrentIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox_CurrentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_CurrentIcon.IconSize = 87;
            this.iconPictureBox_CurrentIcon.Location = new System.Drawing.Point(68, 13);
            this.iconPictureBox_CurrentIcon.Name = "iconPictureBox_CurrentIcon";
            this.iconPictureBox_CurrentIcon.Size = new System.Drawing.Size(94, 87);
            this.iconPictureBox_CurrentIcon.TabIndex = 0;
            this.iconPictureBox_CurrentIcon.TabStop = false;
            this.iconPictureBox_CurrentIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelDestop
            // 
            this.panelDestop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panelDestop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestop.ForeColor = System.Drawing.Color.White;
            this.panelDestop.Location = new System.Drawing.Point(250, 100);
            this.panelDestop.Name = "panelDestop";
            this.panelDestop.Size = new System.Drawing.Size(912, 452);
            this.panelDestop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 552);
            this.Controls.Add(this.panelDestop);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeftMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_CurrentIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDestop;
        private FontAwesome.Sharp.IconButton btPersonal;
        private FontAwesome.Sharp.IconButton btUsers;
        private FontAwesome.Sharp.IconButton btGeneral;
        private FontAwesome.Sharp.IconButton btLogout;
        private FontAwesome.Sharp.IconButton btMail;
        private FontAwesome.Sharp.IconButton btSchedule;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_CurrentIcon;
        private System.Windows.Forms.Label labelCurrentIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btMinimum;
        private FontAwesome.Sharp.IconButton btMaximum;
        private FontAwesome.Sharp.IconButton btExit;
    }
}

