namespace Library_Management_System
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.nav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new Library_Management_System.custom_button.customBTN();
            this.minBtn = new Library_Management_System.custom_button.customBTN();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.accBTN = new Library_Management_System.custom_button.customBTN();
            this.outBTN = new Library_Management_System.custom_button.customBTN();
            this.borrowBTN = new Library_Management_System.custom_button.customBTN();
            this.libBTN = new Library_Management_System.custom_button.customBTN();
            this.dashBTN = new Library_Management_System.custom_button.customBTN();
            this.basePanel = new System.Windows.Forms.Panel();
            this.main_dash1 = new Library_Management_System.main_dash();
            this.nclib1 = new Library_Management_System.nclib();
            this.book_request1 = new Library_Management_System.book_request();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav
            // 
            this.nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nav.Controls.Add(this.pictureBox1);
            this.nav.Controls.Add(this.closeBtn);
            this.nav.Controls.Add(this.minBtn);
            this.nav.Controls.Add(this.label1);
            this.nav.Font = new System.Drawing.Font("Inter Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(1440, 75);
            this.nav.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.closeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.closeBtn.BorderRadius = 5;
            this.closeBtn.BorderSize = 0;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1393, 24);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.minBtn.BorderColor = System.Drawing.Color.Transparent;
            this.minBtn.BorderRadius = 5;
            this.minBtn.BorderSize = 0;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.ForeColor = System.Drawing.Color.White;
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.Location = new System.Drawing.Point(1330, 24);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(25, 25);
            this.minBtn.TabIndex = 3;
            this.minBtn.TextColor = System.Drawing.Color.White;
            this.minBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "N O R Z A G A R A Y  C O L L E G E  L I B R A R Y  S Y S T E M";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.menu.Controls.Add(this.accBTN);
            this.menu.Controls.Add(this.outBTN);
            this.menu.Controls.Add(this.borrowBTN);
            this.menu.Controls.Add(this.libBTN);
            this.menu.Controls.Add(this.dashBTN);
            this.menu.Location = new System.Drawing.Point(0, 74);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(97, 955);
            this.menu.TabIndex = 1;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // accBTN
            // 
            this.accBTN.BackColor = System.Drawing.Color.Transparent;
            this.accBTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.accBTN.BorderColor = System.Drawing.Color.Transparent;
            this.accBTN.BorderRadius = 10;
            this.accBTN.BorderSize = 0;
            this.accBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accBTN.FlatAppearance.BorderSize = 0;
            this.accBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.accBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.accBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accBTN.ForeColor = System.Drawing.Color.White;
            this.accBTN.Image = ((System.Drawing.Image)(resources.GetObject("accBTN.Image")));
            this.accBTN.Location = new System.Drawing.Point(28, 64);
            this.accBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accBTN.Name = "accBTN";
            this.accBTN.Size = new System.Drawing.Size(40, 40);
            this.accBTN.TabIndex = 3;
            this.accBTN.TextColor = System.Drawing.Color.White;
            this.accBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accBTN.UseVisualStyleBackColor = false;
            // 
            // outBTN
            // 
            this.outBTN.BackColor = System.Drawing.Color.Transparent;
            this.outBTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.outBTN.BorderColor = System.Drawing.Color.Transparent;
            this.outBTN.BorderRadius = 10;
            this.outBTN.BorderSize = 0;
            this.outBTN.FlatAppearance.BorderSize = 0;
            this.outBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.outBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.outBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outBTN.ForeColor = System.Drawing.Color.White;
            this.outBTN.Image = ((System.Drawing.Image)(resources.GetObject("outBTN.Image")));
            this.outBTN.Location = new System.Drawing.Point(14, 859);
            this.outBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outBTN.Name = "outBTN";
            this.outBTN.Size = new System.Drawing.Size(69, 71);
            this.outBTN.TabIndex = 3;
            this.outBTN.TextColor = System.Drawing.Color.White;
            this.outBTN.UseVisualStyleBackColor = false;
            this.outBTN.Click += new System.EventHandler(this.outBTN_Click);
            // 
            // borrowBTN
            // 
            this.borrowBTN.BackColor = System.Drawing.Color.Transparent;
            this.borrowBTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.borrowBTN.BorderColor = System.Drawing.Color.Transparent;
            this.borrowBTN.BorderRadius = 10;
            this.borrowBTN.BorderSize = 0;
            this.borrowBTN.FlatAppearance.BorderSize = 0;
            this.borrowBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.borrowBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.borrowBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBTN.ForeColor = System.Drawing.Color.White;
            this.borrowBTN.Image = ((System.Drawing.Image)(resources.GetObject("borrowBTN.Image")));
            this.borrowBTN.Location = new System.Drawing.Point(14, 378);
            this.borrowBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.borrowBTN.Name = "borrowBTN";
            this.borrowBTN.Size = new System.Drawing.Size(69, 71);
            this.borrowBTN.TabIndex = 3;
            this.borrowBTN.TextColor = System.Drawing.Color.White;
            this.borrowBTN.UseVisualStyleBackColor = false;
            this.borrowBTN.Click += new System.EventHandler(this.borrowBTN_Click);
            // 
            // libBTN
            // 
            this.libBTN.BackColor = System.Drawing.Color.Transparent;
            this.libBTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.libBTN.BorderColor = System.Drawing.Color.Transparent;
            this.libBTN.BorderRadius = 10;
            this.libBTN.BorderSize = 0;
            this.libBTN.FlatAppearance.BorderSize = 0;
            this.libBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.libBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.libBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libBTN.ForeColor = System.Drawing.Color.White;
            this.libBTN.Image = ((System.Drawing.Image)(resources.GetObject("libBTN.Image")));
            this.libBTN.Location = new System.Drawing.Point(14, 268);
            this.libBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libBTN.Name = "libBTN";
            this.libBTN.Size = new System.Drawing.Size(69, 71);
            this.libBTN.TabIndex = 3;
            this.libBTN.TextColor = System.Drawing.Color.White;
            this.libBTN.UseVisualStyleBackColor = false;
            this.libBTN.Click += new System.EventHandler(this.libBTN_Click);
            // 
            // dashBTN
            // 
            this.dashBTN.BackColor = System.Drawing.Color.Transparent;
            this.dashBTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.dashBTN.BorderColor = System.Drawing.Color.Transparent;
            this.dashBTN.BorderRadius = 10;
            this.dashBTN.BorderSize = 0;
            this.dashBTN.FlatAppearance.BorderSize = 0;
            this.dashBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.dashBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.dashBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBTN.ForeColor = System.Drawing.Color.White;
            this.dashBTN.Image = ((System.Drawing.Image)(resources.GetObject("dashBTN.Image")));
            this.dashBTN.Location = new System.Drawing.Point(14, 158);
            this.dashBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashBTN.Name = "dashBTN";
            this.dashBTN.Size = new System.Drawing.Size(69, 71);
            this.dashBTN.TabIndex = 3;
            this.dashBTN.TextColor = System.Drawing.Color.White;
            this.dashBTN.UseVisualStyleBackColor = false;
            this.dashBTN.Click += new System.EventHandler(this.dashBTN_Click);
            // 
            // basePanel
            // 
            this.basePanel.AutoScroll = true;
            this.basePanel.Controls.Add(this.main_dash1);
            this.basePanel.Controls.Add(this.nclib1);
            this.basePanel.Controls.Add(this.book_request1);
            this.basePanel.Location = new System.Drawing.Point(103, 81);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1325, 935);
            this.basePanel.TabIndex = 3;
            // 
            // main_dash1
            // 
            this.main_dash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.main_dash1.Location = new System.Drawing.Point(0, 0);
            this.main_dash1.Name = "main_dash1";
            this.main_dash1.Size = new System.Drawing.Size(1325, 935);
            this.main_dash1.TabIndex = 0;
            // 
            // nclib1
            // 
            this.nclib1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.nclib1.Location = new System.Drawing.Point(0, 0);
            this.nclib1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nclib1.Name = "nclib1";
            this.nclib1.Size = new System.Drawing.Size(1325, 935);
            this.nclib1.TabIndex = 4;
            // 
            // book_request1
            // 
            this.book_request1.AutoScroll = true;
            this.book_request1.Location = new System.Drawing.Point(0, 0);
            this.book_request1.Name = "book_request1";
            this.book_request1.Size = new System.Drawing.Size(1325, 935);
            this.book_request1.TabIndex = 5;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1440, 1028);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.basePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel nav;
        private Panel menu;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel basePanel;
        private custom_button.customBTN outBTN;
        private custom_button.customBTN libBTN;
        private custom_button.customBTN dashBTN;
        private custom_button.customBTN accBTN;
        private custom_button.customBTN closeBtn;
        private custom_button.customBTN minBtn;
        private nclib nclib1;
        private custom_button.customBTN borrowBTN;
        private main_dash main_dash1;
        private book_request book_request1;
    }
}