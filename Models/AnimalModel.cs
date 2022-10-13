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
        public string name;

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
                this.name = npgsqlDataReader[3].ToString();

                db.CloseConnection();
                return true;
            }
            db.CloseConnection();
            return false;
        }

        public bool CheckAnimal(int infoPersone, int animalType, string name, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Animal Where animalType_id = '{animalType}' and infopersone_id = '{infoPersone}' and name = '{name}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
                this.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                this.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                this.name = npgsqlDataReader[3].ToString();

                db.CloseConnection();
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public static List<AnimalModel> GetAllAnimalByPersone(int infopersone, string postgreas)
        {
            List<AnimalModel> animals = new List<AnimalModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Animal Where infopersone_id = '{infopersone}';", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                AnimalModel animal = new AnimalModel();

                animal.id = int.Parse(npgsqlDataReader[0].ToString());
                animal.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                animal.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                animal.name = npgsqlDataReader[3].ToString();

                animals.Add(animal);
            }
            db.CloseConnection();

            foreach(AnimalModel animal in animals)
            {
                animal.animalType.GetAnimalTypeById(animal.animalType.id, postgreas);
                animal.infoPersone.GetInfoPersoneById(animal.infoPersone.id, postgreas);
            }

            return animals;
        }

        public void AddAnimal(int infoPersone, int animalType, string name, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Animal(animalType_id, infopersone_id,name) Values('{animalType}','{infoPersone}','{name}')", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }
    }
}
