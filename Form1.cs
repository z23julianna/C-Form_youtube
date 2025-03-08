using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 64);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginUser = login.Text;
            string passwordUser = password.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            using (MySqlConnection connection = db.getConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP", connection);
                    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                    command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login or password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebutton1_MouseEnter(object sender, EventArgs e)
        {
            closebutton1.ForeColor = Color.Green;
        }

        private void closebutton1_MouseLeave(object sender, EventArgs e)
        {
            closebutton1.ForeColor = Color.White;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Green;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void login_TextChanged(object sender, EventArgs e) { }

        private void registerlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}