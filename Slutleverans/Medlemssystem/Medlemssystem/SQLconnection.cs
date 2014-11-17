using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Medlemssystem
{

    class SQLconnection
    {
        public void AddUserAndEditBoatSQL(string sqlQuery)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "boatclub");
            connBuilder.Add("Data Source", "127.0.0.1");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = sqlQuery; 
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public void ShowUserSQL(string sqlQuery)
        {
            Program program = new Program();
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "boatclub");
            connBuilder.Add("Data Source", "127.0.0.1");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> completeUsersList = new List<string>();

            while (reader.Read())
            {
                completeUsersList.Add(reader.GetInt32(0).ToString());
                completeUsersList.Add(reader.GetString(1));
                completeUsersList.Add(reader.GetString(2));
                completeUsersList.Add(reader.GetString(3));
                completeUsersList.Add(reader.GetString(4));
                completeUsersList.Add(reader.GetString(5));
            }
            reader.Close();
            program.readQuery(completeUsersList);
        }

        public void DeleteBoatSQL(string sqlQuery)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "boatclub");
            connBuilder.Add("Data Source", "127.0.0.1");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            Program program = new Program();
            List<string> boatList = new List<string>();
            
            while (reader.Read())
            {
                boatList.Add(reader.GetInt32(0).ToString());
                boatList.Add(reader.GetString(1));
                boatList.Add(reader.GetString(2));
            }
            reader.Close();
            program.readQuery(boatList);
        }

        public void AddBoatSQL(string sqlQuery)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "boatclub");
            connBuilder.Add("Data Source", "127.0.0.1");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();

        }

        public void ShowCompressedListSQL(string sqlQuery)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "boatclub");
            connBuilder.Add("Data Source", "127.0.0.1");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;


            MySqlDataReader reader = cmd.ExecuteReader();
            Program program = new Program();
            List<string> shortList = new List<string>();

            while (reader.Read())
            {
                shortList.Add(reader.GetInt32(0).ToString());
                shortList.Add(reader.GetString(1));
                shortList.Add(reader.GetString(2));
                shortList.Add(reader.GetString(3));
                shortList.Add(reader.GetInt32(4).ToString());
            }
            reader.Close();
            program.readQuery(shortList);
        }
    }
}
