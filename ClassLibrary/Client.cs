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
        public Client(string _name) : base(_name)
        {

        }

        public void ReadFromDBase()
        {
            DBase db = new DBase();
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT drives FROM clients WHERE login = @username", db.getConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Name;
            string str = command.ExecuteScalar().ToString();
            rides = Convert.ToInt32(str);

            db.CloseConnection();
        }

        public void checkForAge(int _age)
        {
            if (_age > 100 || _age < 16)
            {
                throw new PersonException("Unacceptable age");
            }
            else
            {
                Age = _age;
            }
        }

        public override void AmountOfRides()
        {
            rides++;
            DBase db = new DBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("UPDATE clients SET drives = @rides WHERE login = @userlogin", db.getConnection());

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@rides", MySqlDbType.VarChar).Value = rides;
            command.ExecuteNonQuery();
            db.CloseConnection();
        }


    }
}
