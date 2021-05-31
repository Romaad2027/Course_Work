using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ClassLibrary
{
    public class Client : Person
    {
        public Client(string _name) : base(_name)   // calling the constructor of the base class
        {

        }

        public void ReadFromDBase()     // method of getting amount of rides from Data Base
        {
            DBase db = new DBase();
            db.OpenConnection();    // open connection with Data Base

            MySqlCommand command = new MySqlCommand("SELECT drives FROM clients WHERE login = @username", db.getConnection()); // making MySql request to get the amount of rides
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;  
            string str = command.ExecuteScalar().ToString();    // assigning the value fom Dbase 
            rides = Convert.ToInt32(str);

            db.CloseConnection();   // closing connection with Data Base
        }

        public void checkForAge(int _age)   // method of checking the user for age
        {
            if (_age > 100 || _age < 16)    // if the age is unacceptable we throw our exception
            {
                throw new PersonException("Unacceptable age");
            }
            else
            {
                Age = _age;
            }
        }

        public override void AmountOfRides()    // overriding the method of counting for amount of rides
        {
            rides++;    // add a ride
            DBase db = new DBase();     
            db.OpenConnection();    // open connection with Data Base
            MySqlCommand command = new MySqlCommand("UPDATE clients SET drives = @rides WHERE login = @userlogin", db.getConnection()); // making MySql request to set the amount of rides

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@rides", MySqlDbType.VarChar).Value = rides;
            command.ExecuteNonQuery();  // changing the value in data base
            db.CloseConnection();   // close connection with Data Base
        }


    }
}
