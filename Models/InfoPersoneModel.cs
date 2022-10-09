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
        public AccountModel account;
        public string first_name;
        public string last_name;
        public DateTime day_of_birth;
        public string city;
        public string street;
        public int number_house;

        public MessageModel AddInfoPersone(int account_id,string first_name, string last_name, DateTime day_of_birdth, string city, string street, int number_house, string role)
        {
            DBConect db = new DBConect(role);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into InfoPersone(account_id, first_name, last_name, day_of_birdth, city, street, number_house) Values('{account_id}','{first_name}','{last_name}','{day_of_birdth.ToString("dd.mm.yyyy")}', '{city}', '{street}', '{number_house}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }
            db.CloseConnection();

            return new MessageModel("Акаунт создан", false);
        }
    }
}
