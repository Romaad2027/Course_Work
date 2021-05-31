using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoginText.Text = "Enter your login";
            LoginText.ForeColor = Color.Gray;
            PasswordText.Text = "Enter password";
            PasswordText.ForeColor = Color.Gray;
            NameText.Text = "Enter your name";
            NameText.ForeColor = Color.Gray;
            AgeText.Text = "Enter your age";
            AgeText.ForeColor = Color.Gray;
        }

        private void Regbutton(object sender, EventArgs e)
        {

            if (LoginText.Text == "Enter your login")
            {
                MessageBox.Show("Enter your login");
                return;
            }

            if (NameText.Text == "Enter your name")
            {
                MessageBox.Show("Enter your name");
                return;
            }

            if (PasswordText.Text == "Enter password")
            {
                MessageBox.Show("Enter your password");
                return;
            }

            if (AgeText.Text == "Enter your age")
            {
                MessageBox.Show("Enter your age");
                return;
            }

            if(isUserExists())
            {
                return;
            }

            try
            {
                Client client = new Client(NameText.Text);
                client.checkForAge(Convert.ToInt32(AgeText.Text));
            }
            catch (PersonException)
            {
                MessageBox.Show("Wrong age");
                return;
            }

            DBase db = new DBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO clients (name, login, password, age) VALUES (@name, @login, @password, @age)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameText.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginText.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordText.Text;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = Convert.ToInt32(AgeText.Text);

            db.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account has been created");
            }
            else
            {
                MessageBox.Show("Account hasn't been created");
            }
            db.CloseConnection();
        }

        public Boolean isUserExists()
        {
            DBase db = new DBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM clients WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginText.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (LoginText.Text == "Enter your login")
            {
                LoginText.Text = "";
                LoginText.ForeColor = Color.Black;
            }
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (LoginText.Text == "")
            {
                LoginText.Text = "Enter your login";
                LoginText.ForeColor = Color.Gray;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Enter password")
            {
                PasswordText.Text = "";
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Enter password";
                PasswordText.ForeColor = Color.Gray;
            }
        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            if (NameText.Text == "Enter your name")
            {
                NameText.Text = "";
                NameText.ForeColor = Color.Black;
            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                NameText.Text = "Enter your name";
                NameText.ForeColor = Color.Gray;
            }
        }

        private void AgeText_Enter(object sender, EventArgs e)
        {
            if (AgeText.Text == "Enter your age")
            {
                AgeText.Text = "";
                AgeText.ForeColor = Color.Black;
            }
        }
        private void AgeText_Leave(object sender, EventArgs e)
        {
            if (AgeText.Text == "")
            {
                AgeText.Text = "Enter your age";
                AgeText.ForeColor = Color.Gray;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
