using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class LoginForm : Form
    {
        MainMenuForm menu;
        public LoginForm()
        {
            InitializeComponent();
            LoginText.Text = "Enter your login";
            LoginText.ForeColor = Color.Gray;
            PasswordText.Text = "Enter password";
            PasswordText.ForeColor = Color.Gray;
        }

        //public string Login
        //{
        //    get
        //    {
        //        string loginUser = LoginText.Text;
        //        DBase db = new DBase();
        //        db.OpenConnection();

        //        DataTable table = new DataTable();

        //        MySqlDataAdapter adapter = new MySqlDataAdapter();

        //        string com = $"SELECT * FROM clients WHERE login = '{LoginText.Text}'";

        //        MySqlCommand command = new MySqlCommand(com, db.getConnection());

        //        //command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = LoginText.Text;

        //        string login = command.ExecuteScalar().ToString();
        //        db.CloseConnection();
        //        return login;
        //    }
        //}

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
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

        private void LogButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginText.Text;          // getting the value from forms
            String passwordUser = PasswordText.Text;    //

            DBase db = new DBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM clients WHERE login = @userlogin AND password = @userpassword", db.getConnection()); // make MySQL request

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)    // check if the user with such login and password exists
            {
                this.Hide();
                if(LoginText.Text == "Admin") // if it's admin account
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else // if it's user's account
                {
                    menu = new MainMenuForm(LoginText.Text.Trim()); // transfer the login to another form
                    menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong login or password. Please, try again");
            }

        }
    }

}
