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
        public MySqlConnection DatabaseSettings()
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            connBuilder.Add("Database", "boatclub");
            connBuilder.Add("Data Source", "127.0.0.1");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");
            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);
            return connection;
        }

        public void AddUserAndEditBoatSQL(string sqlQuery)
        {
            MySqlConnection connection = DatabaseSettings();
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = sqlQuery; 
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public List<Member> ShowUserSQL(string sqlQuery)
        {
            MySqlConnection connection = DatabaseSettings();
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            List<Member> members = new List<Member>();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string fn = reader.GetString(1);
                string ln = reader.GetString(2);
                string ssn = reader.GetString(3);
                int bc = reader.GetInt32(4);

                Member m = new Member(id, fn, ln, ssn, bc);
                members.Add(m);
            }
            reader.Close();
            return members;
        }

        public List<Boat> ShowUserBoatsSQL(string sqlQuery)
        {
            MySqlConnection connection = DatabaseSettings();
            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            List<Member> members = new List<Member>();
            List<Boat> boats = new List<Boat>();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int bid = reader.GetInt32(4);
                string l = reader.GetString(5);
                string bt = reader.GetString(6);

                Boat b = new Boat(bid, id, bt, l);
                boats.Add(b);
            }
            reader.Close();
            return boats;
        }

      public void DeleteBoatSQL(string sqlQuery)
        {
            MySqlConnection connection = DatabaseSettings();
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            List<Boat> boatList = new List<Boat>();
            
            while (reader.Read())
            {
                int bid = reader.GetInt32(0);
                int mid = reader.GetInt32(1);
                string btid = reader.GetString(2);
                string l = reader.GetString(3);
                Boat m = new Boat(bid, mid, btid, l);
            }
            reader.Close();
        }

        public void AddBoatSQL(string sqlQuery)
        {
            MySqlConnection connection = DatabaseSettings();
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
        }
        
        public List<Member> ShowCompressedListSQL(string sqlQuery)
        {
            MySqlConnection connection = DatabaseSettings();
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();

            List<Member> members = new List<Member>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string fn = reader.GetString(1);
                string ln = reader.GetString(2);
                string ssn = reader.GetString(3);
                int bc = reader.GetInt32(4);
                Member m = new Member(id, fn, ln, ssn, bc);
                members.Add(m);
            }
            reader.Close();
            return members;
        }
    }
}