namespace Library_Management_System
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Siticone.Desktop.UI.AnimatorNS.Animation animation1 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            incorText = new Label();
            loginBTN = new custom_button.customBTN();
            signUpBTN = new Button();
            panel3 = new Panel();
            hidePass = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            PassText = new CustomControls.RJControls.RJTextBox();
            UNText = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            title = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            exitBTN = new Label();
            siticoneTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(incorText);
            panel1.Controls.Add(loginBTN);
            panel1.Controls.Add(signUpBTN);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            siticoneTransition1.SetDecoration(panel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel1.Location = new Point(41, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 419);
            panel1.TabIndex = 0;
            // 
            // incorText
            // 
            incorText.AutoSize = true;
            siticoneTransition1.SetDecoration(incorText, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            incorText.Font = new Font("Inter Black", 5F, FontStyle.Regular, GraphicsUnit.Point);
            incorText.ForeColor = Color.FromArgb(157, 11, 11);
            incorText.Location = new Point(57, 335);
            incorText.Name = "incorText";
            incorText.Size = new Size(290, 12);
            incorText.TabIndex = 2;
            incorText.Text = "* U S E R N A M E  O R  P A S S W O R D  I S  I N C O R R E C T *";
            incorText.Visible = false;
            // 
            // loginBTN
            // 
            loginBTN.BackColor = Color.FromArgb(8, 31, 58);
            loginBTN.BackgroundColor = Color.FromArgb(8, 31, 58);
            loginBTN.BorderColor = Color.Transparent;
            loginBTN.BorderRadius = 10;
            loginBTN.BorderSize = 0;
            siticoneTransition1.SetDecoration(loginBTN, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            loginBTN.Dock = DockStyle.Bottom;
            loginBTN.FlatAppearance.BorderSize = 0;
            loginBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 72, 139);
            loginBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 72, 139);
            loginBTN.FlatStyle = FlatStyle.Flat;
            loginBTN.Font = new Font("Inter Black", 7F, FontStyle.Regular, GraphicsUnit.Point);
            loginBTN.ForeColor = Color.White;
            loginBTN.Location = new Point(0, 350);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(350, 45);
            loginBTN.TabIndex = 3;
            loginBTN.Text = "L O G I N";
            loginBTN.TextColor = Color.White;
            loginBTN.UseVisualStyleBackColor = false;
            loginBTN.Click += custombtn1_Click;
            // 
            // signUpBTN
            // 
            signUpBTN.Cursor = Cursors.Hand;
            siticoneTransition1.SetDecoration(signUpBTN, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            signUpBTN.Dock = DockStyle.Bottom;
            signUpBTN.FlatAppearance.BorderSize = 0;
            signUpBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signUpBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            signUpBTN.FlatStyle = FlatStyle.Flat;
            signUpBTN.Font = new Font("Inter Black", 4F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBTN.ForeColor = Color.FromArgb(255, 253, 130);
            signUpBTN.Location = new Point(0, 395);
            signUpBTN.Margin = new Padding(0);
            signUpBTN.Name = "signUpBTN";
            signUpBTN.Size = new Size(350, 24);
            signUpBTN.TabIndex = 2;
            signUpBTN.Text = "D O N ' T  H A V E  A N  A C C O U N T ?  S I G N  U P";
            signUpBTN.UseVisualStyleBackColor = true;
            signUpBTN.Click += signUpBTN_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(hidePass);
            panel3.Controls.Add(PassText);
            panel3.Controls.Add(UNText);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            siticoneTransition1.SetDecoration(panel3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel3.Location = new Point(3, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 211);
            panel3.TabIndex = 1;
            // 
            // hidePass
            // 
            hidePass.Animated = true;
            hidePass.AutoSize = true;
            hidePass.BackColor = Color.Transparent;
            hidePass.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            hidePass.CheckedState.BorderRadius = 0;
            hidePass.CheckedState.BorderThickness = 0;
            hidePass.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            hidePass.Cursor = Cursors.Hand;
            siticoneTransition1.SetDecoration(hidePass, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            hidePass.Font = new Font("Inter Black", 4F, FontStyle.Regular, GraphicsUnit.Point);
            hidePass.ForeColor = Color.FromArgb(255, 253, 130);
            hidePass.Location = new Point(203, 187);
            hidePass.Margin = new Padding(0);
            hidePass.Name = "hidePass";
            hidePass.Size = new Size(139, 21);
            hidePass.TabIndex = 2;
            hidePass.Text = "  S H O W  P A S S W O R D ?";
            hidePass.UncheckedState.BorderColor = Color.Transparent;
            hidePass.UncheckedState.BorderRadius = 0;
            hidePass.UncheckedState.BorderThickness = 0;
            hidePass.UncheckedState.FillColor = Color.Transparent;
            hidePass.UseVisualStyleBackColor = false;
            hidePass.CheckedChanged += hidePass_CheckedChanged;
            // 
            // PassText
            // 
            PassText.BackColor = Color.FromArgb(0, 166, 251);
            PassText.BackgroundImageLayout = ImageLayout.None;
            PassText.BorderColor = Color.Transparent;
            PassText.BorderFocusColor = Color.Transparent;
            PassText.BorderRadius = 10;
            PassText.BorderSize = 2;
            PassText.Cursor = Cursors.IBeam;
            siticoneTransition1.SetDecoration(PassText, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            PassText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            PassText.ForeColor = Color.Black;
            PassText.Location = new Point(0, 136);
            PassText.Margin = new Padding(4);
            PassText.Multiline = false;
            PassText.Name = "PassText";
            PassText.Padding = new Padding(10, 7, 10, 7);
            PassText.PasswordChar = true;
            PassText.PlaceholderColor = Color.Black;
            PassText.PlaceholderText = "";
            PassText.Size = new Size(344, 39);
            PassText.TabIndex = 4;
            PassText.Texts = "";
            PassText.UnderlinedStyle = false;
            // 
            // UNText
            // 
            UNText.BackColor = Color.FromArgb(0, 166, 251);
            UNText.BackgroundImageLayout = ImageLayout.None;
            UNText.BorderColor = Color.Transparent;
            UNText.BorderFocusColor = Color.Transparent;
            UNText.BorderRadius = 10;
            UNText.BorderSize = 2;
            UNText.Cursor = Cursors.IBeam;
            siticoneTransition1.SetDecoration(UNText, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            UNText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            UNText.ForeColor = Color.Black;
            UNText.Location = new Point(0, 25);
            UNText.Margin = new Padding(4);
            UNText.Multiline = false;
            UNText.Name = "UNText";
            UNText.Padding = new Padding(10, 7, 10, 7);
            UNText.PasswordChar = false;
            UNText.PlaceholderColor = Color.Black;
            UNText.PlaceholderText = "";
            UNText.Size = new Size(344, 39);
            UNText.TabIndex = 4;
            UNText.Texts = "";
            UNText.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            siticoneTransition1.SetDecoration(label3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            label3.Font = new Font("Inter Black", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 111);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "P A S S W O R D";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            siticoneTransition1.SetDecoration(label2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Inter Black", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 0;
            label2.Text = "U S E R N A M E";
            // 
            // panel2
            // 
            panel2.Controls.Add(title);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            siticoneTransition1.SetDecoration(panel2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 65);
            panel2.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSize = true;
            siticoneTransition1.SetDecoration(title, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            title.FlatStyle = FlatStyle.Flat;
            title.Font = new Font("Inter Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(73, 0);
            title.Margin = new Padding(0);
            title.Name = "title";
            title.Size = new Size(167, 44);
            title.TabIndex = 0;
            title.Text = "H E L L O";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            siticoneTransition1.SetDecoration(pictureBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            siticoneTransition1.SetDecoration(label1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Inter Black", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(79, 45);
            label1.Name = "label1";
            label1.Size = new Size(247, 17);
            label1.TabIndex = 0;
            label1.Text = "W E L C O M E  T O  N C  L I B R A R Y";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitBTN
            // 
            exitBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitBTN.AutoSize = true;
            exitBTN.BackColor = Color.Transparent;
            exitBTN.Cursor = Cursors.Hand;
            siticoneTransition1.SetDecoration(exitBTN, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            exitBTN.Font = new Font("Inter Black", 7F, FontStyle.Regular, GraphicsUnit.Point);
            exitBTN.ForeColor = Color.FromArgb(8, 31, 58);
            exitBTN.Location = new Point(890, 11);
            exitBTN.Name = "exitBTN";
            exitBTN.Size = new Size(51, 17);
            exitBTN.TabIndex = 1;
            exitBTN.Text = "E X I T";
            exitBTN.Click += exitBTN_Click;
            exitBTN.MouseEnter += exitBTN_MouseEnter;
            exitBTN.MouseLeave += exitBTN_MouseLeave;
            // 
            // siticoneTransition1
            // 
            siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            siticoneTransition1.DefaultAnimation = animation1;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(953, 678);
            Controls.Add(exitBTN);
            Controls.Add(panel1);
            siticoneTransition1.SetDecoration(this, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label title;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button signUpBTN;
        private custom_button.customBTN loginBTN;
        private CustomControls.RJControls.RJTextBox PassText;
        private Label exitBTN;
        private CustomControls.RJControls.RJTextBox UNText;
        private Label incorText;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox hidePass;
        private Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition1;
    }
}