using JPVN.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.DataAccess
{
    class DataConnect
    {

        //infor load from config
        private string _port;
        private string _server;
        private string _database;
        private string _uid;
        private string _pwd;
        private string _sqlServer;

        //connect
        private SqlConnection _conn = null;
        SqlCommand command;
        SqlDataReader reader;

        public DataConnect()
        {
            _port = ConfigurationManager.AppSettings["Port"];
            _server = ConfigurationManager.AppSettings["Server"];
            _database = ConfigurationManager.AppSettings["Database"];
            _uid = ConfigurationManager.AppSettings["Uid"];
            _pwd = ConfigurationManager.AppSettings["Pwd"];
            _sqlServer = ConfigurationManager.AppSettings["connectSqlServer"];
        }

        /// <summary>
        /// connect to the connection
        /// </summary>
        /// <returns></returns>
        public bool connect()
        {
            try
            {
                //_conn = new MySqlConnection("Server=" + _server + ";Port=" + _port + ";Database=" + _database + ";Uid=" + _uid + ";Pwd=" + _pwd);
                _conn = new SqlConnection(_sqlServer);
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
            try
            {

               connect();

                //1 is hiragana   , 2 is katakana
                command = _conn.CreateCommand();
                command.CommandText = "SELECT ID, symbol, Romanj, Image, Audio FROM letter where Type = " + typeLetter;
                reader = command.ExecuteReader();
                

                while (reader.Read())
                {
                    string idString = reader["ID"].ToString();
                    int id = int.Parse(idString);
                    string romanj = reader["Romanj"].ToString();
                    string symbol = reader["symbol"].ToString();
                    string urlImage = reader["Image"].ToString();
                    string urlAudio = reader["Audio"].ToString();

                    Letter letter = new Letter(id, symbol, romanj, urlImage, urlAudio, typeLetter);
                    lst.Add(letter);
                }


                //end if
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           _conn.Close();
            return lst;
        }

        public void close()
        {
            _conn.Close();
        }

        /// <summary>
        /// getAll word by lession
        /// </summary>
        /// <param name="typeLetter"></param>
        /// <returns>ArrayList Word</returns>
        public ArrayList getAllWordByLession(int lessionId)
        {
            ArrayList lst = new ArrayList();
            //get query
            try
            {

                connect();


                
                command = _conn.CreateCommand();
               
                command.CommandText = "SELECT ID, Symbol, Romanj, Image, Meaning FROM Vocabulary where IdLession = " + lessionId;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idString = reader["ID"].ToString();
                    int id = int.Parse(idString);
                    string romanj = reader["Romanj"].ToString();
                    string symbol = reader["Symbol"].ToString();
                    string urlImage = reader["Image"].ToString();
                    string meaning = reader["Meaning"].ToString();
                    Console.WriteLine(romanj);
                    NewWord nWord = new NewWord(idString, symbol, romanj, urlImage, meaning, lessionId + "");
                    lst.Add(nWord);
                }


                //end if
            }
            catch
            {

            }
            _conn.Close();
            return lst;
        }

        /// <summary>
        /// get Listening by lession
        /// </summary>
        /// <param name="lessionId"></param>
        /// <returns></returns>
        public ArrayList getDataListeningByLession(int lessionId)
        {
            ArrayList lst = new ArrayList();
            //get query
            try
            {

                connect();



                command = _conn.CreateCommand();

                command.CommandText = "SELECT ID , Title , Link , Text , idLession FROM Listen where IdLession = " + lessionId;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idString = reader["ID"].ToString();
                    int id = int.Parse(idString);
                    string title = reader["Title"].ToString();
                    string link = reader["Link"].ToString();
                    string text = reader["Text"].ToString();
                    string idLessionString = reader["idLession"].ToString();
                    int idLession = int.Parse(idLessionString);

                    Listening lis = new Listening(id, title, link, text, idLession);
                    lst.Add(lis);
                }


                //end if
            }
            catch
            {

            }
            _conn.Close();
            return lst;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lessionId"></param>
        /// <returns></returns>
        public ArrayList getQuestListeningByLession(int lessionId)
        {
            ArrayList lst = new ArrayList();
            //get query
            try
            {

                connect();



                command = _conn.CreateCommand();

                command.CommandText = "SELECT ID , Text , Answer , IdType , IdAudio FROM QFillBlank where IdAudio  = " + lessionId ;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idString = reader["ID"].ToString();
                    int id = int.Parse(idString);
                    string text = reader["Text"].ToString();
                    string answer = reader["Answer"].ToString();
                    int idType = int.Parse(reader["IdType"].ToString());
                    int idAudio = int.Parse(reader["IdAudio"].ToString());
                    QFillBlank quest = new QFillBlank(id, text, answer, idType, idAudio);
                    lst.Add(quest);
                }


                //end if
            }
            catch
            {

            }
            _conn.Close();
            return lst;
        }

        /// <summary>
        /// get all lession
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllLession(){
            ArrayList lst = new ArrayList();
            //get query
            try
            {

                connect();



                command = _conn.CreateCommand();
                
                command.CommandText = "SELECT ID, Lession,Image FROM Lession";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    string idString = reader["ID"].ToString();
                    int id = int.Parse(idString);
                  
                    string lession = reader["Lession"].ToString();
                    string urlImage = reader["Image"].ToString();
                    Lession less = new Lession(id, lession,urlImage);
                    lst.Add(less);
                
                }


                //end if
            }
            catch(Exception e)
            {
                Console.WriteLine("----------"+e);
            }
            _conn.Close();
            return lst;
        }

    }
}
