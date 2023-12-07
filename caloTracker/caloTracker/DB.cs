﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caloTracker
{
    class DB
    {
       private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=calotracker");

        //function to open the connection
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //function to close the connection
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    
        // function to return the conncection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}

