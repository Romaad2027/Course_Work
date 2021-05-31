using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ClassLibrary
{
    public class AdminCheck
    {
        public List<int> ListOfId { get; private set; }

        public AdminCheck()
        {
            ListOfId = new List<int>();
            DBase db = new DBase();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand("SELECT id FROM drivers", db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                string str = reader[0].ToString();
                ListOfId.Add(Convert.ToInt32(str));
            }

            db.CloseConnection();
        }

        public bool isIdExist(string id)
        {
            foreach(var item in id)
            {
                if(item < '0' || item > '9')
                {
                    throw new OutOfIdException("Id contains only digits");
                }
            }

            foreach(var item in ListOfId)
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
