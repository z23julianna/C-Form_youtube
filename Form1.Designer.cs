namespace LoginForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            closebutton1 = new Button();
            password = new TextBox();
            pictureBox2 = new PictureBox();
            login = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Close = new Label();
            label1 = new Label();
            registerlabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 219, 138);
            panel1.Controls.Add(registerlabel);
            panel1.Controls.Add(closebutton1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(login);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 555);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // closebutton1
            // 
            closebutton1.BackColor = Color.FromArgb(64, 219, 69);
            closebutton1.FlatAppearance.BorderSize = 0;
            closebutton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 219, 64);
            closebutton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 219, 64);
            closebutton1.FlatStyle = FlatStyle.Flat;
            closebutton1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closebutton1.ForeColor = Color.Transparent;
            closebutton1.Location = new Point(95, 415);
            closebutton1.Name = "closebutton1";
            closebutton1.Size = new Size(230, 54);
            closebutton1.TabIndex = 5;
            closebutton1.Text = "Войти";
            closebutton1.UseVisualStyleBackColor = false;
            closebutton1.Click += closeButton;
            closebutton1.MouseEnter += closebutton1_MouseEnter;
            closebutton1.MouseLeave += closebutton1_MouseLeave;
            // 
            // password
            // 
            password.Font = new Font("Times New Roman", 14F);
            password.Location = new Point(122, 243);
            password.Name = "password";
            password.Size = new Size(241, 34);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.Font = new Font("Times New Roman", 14F);
            login.Location = new Point(122, 143);
            login.Multiline = true;
            login.Name = "login";
            login.Size = new Size(241, 64);
            login.TabIndex = 2;
            login.TextAlign = HorizontalAlignment.Center;
            login.TextChanged += login_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(28, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 219, 211);
            panel2.Controls.Add(Close);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 125);
            panel2.TabIndex = 0;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Font = new Font("Segoe UI", 18F);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(382, 0);
            Close.Name = "Close";
            Close.Size = new Size(32, 41);
            Close.TabIndex = 2;
            Close.Text = "x";
            Close.Click += Close_Click;
            Close.MouseEnter += Close_MouseEnter;
            Close.MouseLeave += Close_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(417, 125);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // registerlabel
            // 
            registerlabel.AutoSize = true;
            registerlabel.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            registerlabel.ForeColor = SystemColors.ControlLightLight;
            registerlabel.Location = new Point(122, 488);
            registerlabel.Name = "registerlabel";
            registerlabel.Size = new Size(171, 29);
            registerlabel.TabIndex = 6;
            registerlabel.Text = "Нет аккаунта?";
            registerlabel.Click += registerlabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(417, 555);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "LoginForm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox password;
        private PictureBox pictureBox2;
        private TextBox login;
        private Button closebutton1;
        private Label Close;
        private Label registerlabel;
    }
}
