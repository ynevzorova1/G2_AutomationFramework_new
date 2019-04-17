﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DB
{
    public class DbConnect
    {
        private MySqlConnection connection;
        private string server = "185.25.118.54";
        private string database = "old_qa";
        private string uid = "old_qa";
        private string password = "PB3Q2F6tdSD9cL3z";

        // Constructor
        public DbConnect()
        {
            Initialize();
        }

        // Initialize values
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            Console.WriteLine("Test");
        }

        // Open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        //Close connection
        private void CloseConnection()
        {
            connection.Close();
        }

        // Select statement
        public void SelectList()
        {
            string query = "SELECT idNumber FROM seleniumTable";
            List<int> resultSet = new List<int>();

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultSet.Add(Convert.ToInt32(reader["idNumber"]));
                }

                foreach (var id in resultSet)
                {
                    Console.WriteLine(id);
                }

                // Сlose Connection
                CloseConnection();
            }
            else
            {
                throw new Exception("No connection to Db");
            }
        }

        // Count statement
        public void Count()
        {
            string query = "SELECT Count(*) FROM seleniumTable";
            int count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                count = int.Parse(cmd.ExecuteScalar() + "");

                Console.WriteLine(count);

                //close Connection
                CloseConnection();
            }
            else
            {
                throw new Exception("No connection to Db");
            }
        }

    }
}
