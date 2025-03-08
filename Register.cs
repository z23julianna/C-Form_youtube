using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            nameuser.Text = "Введите имя";
            nameuser.ForeColor = Color.Blue;

            surnameuser.Text = "Введите фамилию";
            surnameuser.ForeColor = Color.Blue;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void nameuser_Enter(object sender, EventArgs e)
        {
            if (nameuser.Text == "Введите имя")
                nameuser.Text = "";
            nameuser.ForeColor = Color.Black;
        }

        private void nameuser_Leave(object sender, EventArgs e)
        {
            if (nameuser.Text == "")
            {
                nameuser.Text = "Введите имя";
                nameuser.ForeColor = Color.Black;
            }
        }

        private void surnameuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameuser_Enter(object sender, EventArgs e)
        {
            if (surnameuser.Text == "Введите фамилию")
                surnameuser.Text = "";
            surnameuser.ForeColor = Color.Black;
        }

        private void surnameuser_Leave(object sender, EventArgs e)
        {
            if (surnameuser.Text == "")
            {
                surnameuser.Text = "Введите фамилию";
                surnameuser.ForeColor = Color.Black;
            }
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            if (nameuser.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (surnameuser.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (checkUserexist())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `password`, `name`, `surname`) VALUES (@login,@password,@name,@surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameuser.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameuser.Text;

            db.openConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт создан");
                else
                    MessageBox.Show("Аккаунт не создан");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
        public Boolean checkUserexist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь существует. Введите другой");
                return true;
            }

            else
                return false;
        }

        private void registerlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}
