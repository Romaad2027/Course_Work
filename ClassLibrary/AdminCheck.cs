using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ClassLibrary
{
    public class AdminCheck : IAdmin
    {
        public List<int> ListOfId { get; private set; } // list of all Id of our drivers

        public AdminCheck()
        {
            ListOfId = new List<int>();
            DBase db = new DBase();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand("SELECT id FROM drivers", db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())    // while there are rows in our table, we fill our list with the id
            {
                string str = reader[0].ToString();
                ListOfId.Add(Convert.ToInt32(str));
            }

            db.CloseConnection();
        }

        public bool isIdExist(string id)    // check if there are id, which admin enter in form
        {
            foreach(var item in id)
            {
                if(item < '0' || item > '9') // admin entered not digit
                {
                    throw new OutOfIdException("Id contains only digits");
                }
            }

            foreach(var item in ListOfId)   // admin entered wrong id
            {
                if(Convert.ToInt32(id) == item)
                {
                    return true;
                }
            }
            throw new OutOfIdException("There is no worker with this id");
        }
    }
}
