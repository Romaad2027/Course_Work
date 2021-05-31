using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;

namespace ClassLibrary
{
    public class Worker : Person
    {
        private static int Commission = 8;
        public string CarNumber { get; private set; }
        public string CarModel { get; private set; }
        public int Salary { get; private set; }
        public Worker(string _name, int _age, string _carNumber, string _carModel) : base(_name) 
        {
            Age = _age;
            CarNumber = _carNumber;
            CarModel = _carModel;

            DBase db = new DBase();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand("SELECT drives, salary FROM drivers WHERE name = @username", db.getConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;


            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string str = reader[0].ToString();
            rides = Convert.ToInt32(str);
            string salary = reader[1].ToString();
            Salary = Convert.ToInt32(salary);

            db.CloseConnection();
        }

        public override void AmountOfRides()
        {
            rides++;
            DBase db = new DBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("UPDATE drivers SET drives = @rides WHERE name = @username", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@rides", MySqlDbType.VarChar).Value = rides;
            command.ExecuteNonQuery();
            db.CloseConnection();
        }
        public void CountSalary(int fare)
        {
            Salary += fare - Commission;

            DBase db = new DBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("UPDATE drivers SET salary = @salary WHERE name = @username", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@salary", MySqlDbType.VarChar).Value = Salary;
            command.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}
