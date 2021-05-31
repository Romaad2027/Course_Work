using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Ride
    {
        public int fare { get; private set; }
        public int distance { get; private set; }
        //private Worker driver;
        //private Client client;
        public bool isVip { get; private set; }
        private static int rate = 8; // rate for 1 km
        private static int startPrice = 25;

        protected internal event RideStateHandler MakeOrder;

        public Ride(Client _client)
        {
            DBase db = new DBase();
            db.OpenConnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT isVip FROM clients WHERE login = @userlogin", db.getConnection());
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = _client.Name;

            string check1 = command.ExecuteScalar().ToString();
            int check = Convert.ToInt32(check1);
            db.CloseConnection();

            if (check == 1)
                isVip = true;
            else
                isVip = false;
        }
        
        public void GetDistanceOfRide()
        {
            Random rnd = new Random();
            distance = rnd.Next(500, 10000);
        }

        public void CountFare()
        {
            if(isVip == true)
            {
                double cost = rate * (distance / 1000);
                double discount = cost * 0.05;
                cost -= discount;
                fare = (int)cost + startPrice;
            }
            else
            {
                fare = rate * (distance / 1000) + startPrice;
            }
        }
        
        public void CheckVip(Client _client)
        {
            int count = _client.rides;

            if(isVip == false)
            {
                if (count > 5)
                {
                    DBase db = new DBase();
                    db.OpenConnection();
                    MySqlCommand command = new MySqlCommand("UPDATE clients SET isVip = @isVip WHERE login = @userlogin", db.getConnection());

                    command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = _client.Name;
                    command.Parameters.Add("@isVip", MySqlDbType.VarChar).Value = 1;
                    command.ExecuteNonQuery();
                    db.CloseConnection();
                }
            }
            else
            {
                return;
            }
        }

        public Worker GetDriver(Worker driver)
        {
            int count = getAmountOfWorkers();

            Random rnd = new Random();
            int id = rnd.Next(1, count+1);

            DBase db = new DBase();
            db.OpenConnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name, age, carNumber, carModel FROM drivers WHERE id = @workerId", db.getConnection());
            command.Parameters.Add("@workerId", MySqlDbType.VarChar).Value = id;

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string name = reader[0].ToString();
            int age = Convert.ToInt32(reader[1]);
            string carNumber = reader[2].ToString();
            string carModel = reader[3].ToString();

            db.CloseConnection();

            driver = new Worker(name, age, carNumber, carModel);
            return driver;
        }

        public int getAmountOfWorkers()
        {
            string str = "SELECT * FROM drivers";
            int count = 0;

            DBase db = new DBase();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(str, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                count++;
            }
            return count;
        }
    }
}
