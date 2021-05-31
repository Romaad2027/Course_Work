using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Ride : IRide
    {
        public int fare { get; private set; }   // fare of ride
        public int distance { get; private set; }   // distance of ride
        //private Worker driver;
        //private Client client;
        public bool isVip { get; private set; }     // is our client is Vip or not
        private static int rate = 8;    // static field of the rate for 1 km
        private static int startPrice = 25;     // static field of the startprice for the ride

        protected internal event RideStateHandler MakeOrder;

        public Ride(Client _client)     
        {
            DBase db = new DBase();
            db.OpenConnection(); // open connection

            MySqlCommand command = new MySqlCommand("SELECT isVip FROM clients WHERE login = @userlogin", db.getConnection()); // make a request
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = _client.Name;

            string check1 = command.ExecuteScalar().ToString();
            int check = Convert.ToInt32(check1);    // assing the value from DB
            db.CloseConnection();

            if (check == 1)     // if the value is 1 that means that our client is already Vip
                isVip = true;
            else
                isVip = false;
        }
        
        public void GetDistanceOfRide()     // method of generating the distance of the ride
        {
            Random rnd = new Random();
            distance = rnd.Next(500, 10000);
        }

        public void CountFare()     // method of counting еру the fare of ride
        {
            if(isVip == true)      // if client is Vip, he has a discount for 5%;
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
        
        public void CheckVip(Client _client)    // method of updating the Vip row in DB 
        {
            int count = _client.rides;

            if(isVip == false)
            {
                if (count > 5)  // if the client has more than 5 rides for the whole time, he become a vip
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

        public Worker GetDriver(Worker driver)  // method of get the driver for the ride
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
            string name = reader[0].ToString();     // get name
            int age = Convert.ToInt32(reader[1]);   // get age
            string carNumber = reader[2].ToString();    // get car number
            string carModel = reader[3].ToString();     // get car model

            db.CloseConnection();

            driver = new Worker(name, age, carNumber, carModel);
            return driver;
        }

        public int getAmountOfWorkers() // method of getting the amount of drivers
        {
            string str = "SELECT * FROM drivers";   // request
            int count = 0;

            DBase db = new DBase();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(str, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read()) // while there are rows in our table, we increment counter
            {
                count++;
            }
            return count;
        }
    }
}
