using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ClassLibrary;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                AdminCheck check = new AdminCheck();

                DBase db = new DBase();
                db.OpenConnection();
                DataTable table = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT name, drives, salary FROM drivers WHERE id = @workerId", db.getConnection());
                command.Parameters.Add("@workerId", MySqlDbType.VarChar).Value = IdLabel.Text;

                check.isIdExist(IdLabel.Text); // check for Id
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                NameLabel.Text = $"Name: {reader[0]}";
                RidesLabel.Text = $"Rides: {reader[1]}";
                SalaryLabel.Text = $"Salary: {reader[2]}";
                db.CloseConnection();
            }
            catch (OutOfIdException arg)    // no such id
            {
                MessageBox.Show(arg.Message);
                return;
            }

        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();        // close form
            LoginForm logForm = new LoginForm();    // open login form
            logForm.Show();
        }
    }
}
