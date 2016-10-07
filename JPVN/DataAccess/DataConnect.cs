using JPVN.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.DataAccess
{
    class DataConnect
    {
        private MySqlConnection _conn;
        private string _port;
        private string _server;
        private string _database;
        private string _uid;
        private string _pwd;
        public DataConnect()
        {
            _port = ConfigurationManager.AppSettings["Port"];
            _server = ConfigurationManager.AppSettings["Server"];
            _database = ConfigurationManager.AppSettings["Database"];
            _uid = ConfigurationManager.AppSettings["Uid"];
            _pwd = ConfigurationManager.AppSettings["Pwd"];

        }

        /// <summary>
        /// connect to the connection
        /// </summary>
        /// <returns></returns>
        public bool connect()
        {
            try
            {
                _conn = new MySqlConnection("Server=" + _server + ";Port=" + _port + ";Database=" + _database + ";Uid=" + _uid + ";Pwd=" + _pwd);
                _conn.Open();
            }
            catch
            {
                Console.WriteLine("connect failed !!");
                return false;
            }
            return true;
        }

        /// <summary>
        /// get all letter by type hiragana or katakana then finaly will be close connection
        /// </summary>
        /// <param name="typeLetter"></param>
        /// <returns>ArrayList Letter</returns>
        public ArrayList getAllLeter(int typeLetter)
        {   
           ArrayList lst = new ArrayList();
            //get query
            try{

            if (_conn == null)
                connect();
           

            //1 is hiragana   , 2 is katakana
            
                MySqlCommand command = _conn.CreateCommand();
                command.CommandText = "SELECT ID, symbol, Romanj, Image, Audio FROM letter WHERE Type = "+typeLetter;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idString = reader["ID"].ToString();
                    int id = int.Parse(idString);
                    string romanj = reader["Romanj"].ToString();
                    string symbol = reader["symbol"].ToString();
                    string urlImage = reader["Image"].ToString();
                    string urlAudio = reader["Audio"].ToString();
                    Letter letter = new Letter(id, symbol, romanj, urlImage, urlAudio, 1);
                    lst.Add(letter);
                }
            
           
                //end if
            }catch{

            }
            _conn.Close();
            return lst;
        }

    }
}
