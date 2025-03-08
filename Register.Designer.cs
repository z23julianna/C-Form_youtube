namespace LoginForm
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            nameuser = new TextBox();
            surnameuser = new TextBox();
            Registerbutton = new Button();
            loginBox = new TextBox();
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
            panel1.Controls.Add(nameuser);
            panel1.Controls.Add(surnameuser);
            panel1.Controls.Add(Registerbutton);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(password);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(login);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 657);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // nameuser
            // 
            nameuser.Anchor = AnchorStyles.None;
            nameuser.Font = new Font("Times New Roman", 14F);
            nameuser.Location = new Point(9, 208);
            nameuser.Multiline = true;
            nameuser.Name = "nameuser";
            nameuser.Size = new Size(237, 52);
            nameuser.TabIndex = 10;
            nameuser.TextAlign = HorizontalAlignment.Center;
            nameuser.Enter += nameuser_Enter;
            nameuser.Leave += nameuser_Leave;
            // 
            // surnameuser
            // 
            surnameuser.Anchor = AnchorStyles.None;
            surnameuser.Font = new Font("Times New Roman", 14F);
            surnameuser.Location = new Point(275, 208);
            surnameuser.Multiline = true;
            surnameuser.Name = "surnameuser";
            surnameuser.Size = new Size(225, 52);
            surnameuser.TabIndex = 9;
            surnameuser.TextAlign = HorizontalAlignment.Center;
            surnameuser.TextChanged += surnameuser_TextChanged;
            surnameuser.Enter += surnameuser_Enter;
            surnameuser.Leave += surnameuser_Leave;
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = Color.FromArgb(64, 219, 69);
            Registerbutton.FlatAppearance.BorderSize = 0;
            Registerbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 219, 64);
            Registerbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 219, 64);
            Registerbutton.FlatStyle = FlatStyle.Flat;
            Registerbutton.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Registerbutton.ForeColor = Color.Transparent;
            Registerbutton.Location = new Point(102, 455);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(313, 54);
            Registerbutton.TabIndex = 8;
            Registerbutton.Text = "Зарегистрироваться";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.None;
            loginBox.Font = new Font("Times New Roman", 14F);
            loginBox.Location = new Point(76, 331);
            loginBox.Multiline = true;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(185, 52);
            loginBox.TabIndex = 7;
            loginBox.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.Font = new Font("Times New Roman", 14F);
            password.Location = new Point(349, 331);
            password.Name = "password";
            password.Size = new Size(151, 34);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(287, 313);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.Font = new Font("Times New Roman", 14F);
            login.Location = new Point(130, 455);
            login.Multiline = true;
            login.Name = "login";
            login.Size = new Size(233, 54);
            login.TabIndex = 2;
            login.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(3, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 86);
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
            panel2.Size = new Size(503, 125);
            panel2.TabIndex = 0;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Font = new Font("Segoe UI", 18F);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(471, 0);
            Close.Name = "Close";
            Close.Size = new Size(32, 41);
            Close.TabIndex = 2;
            Close.Text = "x";
            Close.Click += Close_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 125);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerlabel
            // 
            registerlabel.AutoSize = true;
            registerlabel.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            registerlabel.ForeColor = SystemColors.ControlLightLight;
            registerlabel.Location = new Point(102, 512);
            registerlabel.Name = "registerlabel";
            registerlabel.Size = new Size(321, 29);
            registerlabel.TabIndex = 11;
            registerlabel.Text = "Авторизация пользователя";
            registerlabel.Click += registerlabel_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 548);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
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
        private TextBox password;
        private PictureBox pictureBox2;
        private TextBox login;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label Close;
        private Label label1;
        private TextBox loginBox;
        private Button Registerbutton;
        private TextBox nameuser;
        private TextBox surnameuser;
        private Label registerlabel;
    }
}