using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;

namespace ClassLibrary
{
    public class Worker : Person
    {
        private static int Commission = 8;  // static field of the commission that company takes from driver for one ride
        public string CarNumber { get; private set; }   // number of the car
        public string CarModel { get; private set; }    // model of the car
        public int Salary { get; private set; }     // salary for one ride
        public Worker(string _name, int _age, string _carNumber, string _carModel) : base(_name)    // calling the constructor of the base class
        {
            Age = _age;
            CarNumber = _carNumber;
            CarModel = _carModel;

            DBase db = new DBase();
            db.OpenConnection();    // open connection with Data Base

            MySqlCommand command = new MySqlCommand("SELECT drives, salary FROM drivers WHERE name = @username", db.getConnection()); // making MySQL request for get the value from the table
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;


            MySqlDataReader reader = command.ExecuteReader();   
            reader.Read();
            string str = reader[0].ToString();      // assign the value from DBase 
            rides = Convert.ToInt32(str);
            string salary = reader[1].ToString();   // assign the value from DBase 
            Salary = Convert.ToInt32(salary);

            db.CloseConnection();   // close connection with Data Base
        }

        public override void AmountOfRides()    // overriding the method of counting for amount of rides
        {
            rides++;
            DBase db = new DBase();
            db.OpenConnection();    // open connection with Data Base
            MySqlCommand command = new MySqlCommand("UPDATE drivers SET drives = @rides WHERE name = @username", db.getConnection());   // making MySql request to set the amount of rides

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@rides", MySqlDbType.VarChar).Value = rides;
            command.ExecuteNonQuery();  // changing the value in data base
            db.CloseConnection();   // close connection with Data Base
        }
        public void CountSalary(int fare)   // method of counting the salary of the driver
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
