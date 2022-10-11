using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class AnimalModel
    {
        public int id;
        public AnimalTypeMode animalType;
        public InfoPersoneModel infoPersone;

        public AnimalModel()
        {
            animalType = new AnimalTypeMode();
            infoPersone = new InfoPersoneModel();
        }

        public bool GetAnimalById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Animal Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                this.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());

                return true;
            }
            db.CloseConnection();
            return false;
        }
    }
}
