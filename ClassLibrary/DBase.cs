using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    class DBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=admin;database=people"); // connect with our DB

        public void OpenConnection()    // method of opening connection with our DB
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()   // method of closing connection with our DB
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()  // get our connection
        {
            return connection;
        }
    }
}
