using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace HonoursApp
{
    //Class to control connecting and disconnecting to and from database
    //Static class so methods can be called from anywhere
    public static class ConnectionClass
    {
        //variable holds database information
        static public string ConnectionString = "Server=silva.computing.dundee.ac.uk;Uid=ckingproject;Pwd=9743.ck.3479;Database=ckingprojectdb;";
        //variable holds the SQL connection
        static public MySqlConnection con;

        //function that connects to the database
        public static void OpenConnection()
        {
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
            }
            catch (MySqlException e)
            {
                
            }
        }

        //function that disconnects to the database
        public static void CloseConnection()
        {
            con.Close();
        }
    }
}
