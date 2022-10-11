using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class AnimalTypeMode
    {
        public int id;
        public string name;

        public static void AddAnimalType(string name, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into AnimalType(name) Values('{name}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }

        public static bool CheckAnimalType(string name, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From AnimalType Where name = '{name}';", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                db.CloseConnection();
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public static List<AnimalTypeMode> GetAllAnimalType(string postgreas)
        {
            List<AnimalTypeMode> animalTypes = new List<AnimalTypeMode>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From AnimalType;", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                AnimalTypeMode animalType = new AnimalTypeMode();
                animalType.id = int.Parse(npgsqlDataReader[0].ToString());
                animalType.name = npgsqlDataReader[1].ToString();

                animalTypes.Add(animalType);
            }
            db.CloseConnection();

            return animalTypes;
        }

        public bool GetAnimalTypeById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From AnimalType Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.name = npgsqlDataReader[1].ToString();

                db.CloseConnection();
                return true;
            }
            db.CloseConnection();
            return false;
        }
    }
}
