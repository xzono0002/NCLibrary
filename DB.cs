using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class DB
    {

        private MySqlConnection connection = new MySqlConnection("server = localhost; port= 3308; username=root; password =; convert zero datetime=True; database= csharp_users_db");

        //open connection

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //return connection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
