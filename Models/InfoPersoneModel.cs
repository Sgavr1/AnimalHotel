using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
namespace AnimalHotel.Models
{
    public class InfoPersoneModel
    {
        public int id;
        public string tel;
        public string first_name;
        public string last_name;
        public DateTime day_of_birth;
        public string city;
        public string street;
        public int number_house;

        public void AddInfoPersone(string tel, string first_name, string last_name, DateTime day_of_birdth, string city, string street, int number_house, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into InfoPersone(tel, firstname, lastname, day_of_birth, city, street, number_house) Values('{tel}','{first_name}','{last_name}','{day_of_birdth.ToString("dd.MM.yyyy")}', '{city}', '{street}', '{number_house}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }
            db.CloseConnection();
        }

        public bool CheckInfoPersone(string tel, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From InfoPersone Where tel = '{tel}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
                this.tel = npgsqlDataReader[1].ToString();
                this.first_name = npgsqlDataReader[2].ToString();
                this.last_name = npgsqlDataReader[3].ToString();
                this.day_of_birth = DateTime.Parse(npgsqlDataReader[4].ToString());
                this.city = npgsqlDataReader[5].ToString();
                this.street = npgsqlDataReader[6].ToString();
                this.number_house = int.Parse(npgsqlDataReader[7].ToString());
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public bool GetInfoPersoneById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From InfoPersone Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.tel = npgsqlDataReader[1].ToString();
                this.first_name = npgsqlDataReader[2].ToString();
                this.last_name = npgsqlDataReader[3].ToString();
                this.day_of_birth = DateTime.Parse(npgsqlDataReader[4].ToString());
                this.city = npgsqlDataReader[5].ToString();
                this.street = npgsqlDataReader[6].ToString();
                this.number_house = int.Parse(npgsqlDataReader[7].ToString());

                return true;
            }
            db.CloseConnection();
            return false;
        }
    }
}
