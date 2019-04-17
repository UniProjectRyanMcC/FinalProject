//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using MySql.Data.MySqlClient;

//namespace Snakes_and_Ladders
//{
//    class CallingDB
//    {
//        public void loadWords()
//        {
//            string myConnectionString = "Server=localhost;Database=words;Uid=root;Pwd=password";
//            MySqlConnection connection = new MySqlConnection(myConnectionString);
//            connection.Open();

//            try
//            {
//                MySqlCommand cmd = connection.CreateCommand();
//                cmd.CommandText = "SELECT * FROM recognise";
//                MySqlDataReader dr = cmd.ExecuteReader();
//                while (dr.Read())
//                {
//                    string[] words = { dr["spokeWord"].ToString() };
//                }
//            }
//            catch (Exception)
//            {
                
//            }
//        }
//    }
//}
