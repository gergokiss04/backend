﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace mysqlDBConnect
{
    internal class Connect
    {
        public MySqlConnection connect;
        private string server;
        private string database;
        private string user;
        private string password;
        private string connectionstring;

        public Connect()
        {
            server = "localhost";
            database = "backenddb";
            user = "root";
            password = "";


            connectionstring = "SERVER= " + server + " ;" + " DATABASE=" + database + " ;" + " USER= " + user + " ;" + "PASSWORD=" + password + " ;"+"SslMode=None;";



            connect = new MySqlConnection(connectionstring);

            try
            {
                connect.Open();
                Console.WriteLine("Sikeres csatlakozás");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }




        }
        
        

    }
}
