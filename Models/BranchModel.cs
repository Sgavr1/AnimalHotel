using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class BranchModel
    {
        public int id;
        public string city;
        public string street;
        public int number_house;
        public string tel;

        public static List<BranchModel> GetAllBranch(string postgreas)
        {
            List<BranchModel> branches = new List<BranchModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Branch", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                BranchModel branch = new BranchModel();
                branch.id = int.Parse(npgsqlDataReader[0].ToString());
                branch.city = npgsqlDataReader[1].ToString();
                branch.street = npgsqlDataReader[2].ToString();
                branch.number_house = int.Parse(npgsqlDataReader[3].ToString());
                branch.tel = npgsqlDataReader[4].ToString();
                branches.Add(branch);
            }
            db.CloseConnection();
            return branches;
        }

        public bool CheckBranch(string city, string street, int number_house, string tel, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Branch", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                if (npgsqlDataReader[4].ToString() == tel) return true;
                if (npgsqlDataReader[1].ToString() == city && npgsqlDataReader[2].ToString() == street && int.Parse(npgsqlDataReader[3].ToString()) == number_house) return true;
            }
            db.CloseConnection();
            return false;
        }

        public void AddBranch(string city, string street, int number_house, string tel, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Branch(city,street,number_house,tel) Values('{city}', '{street}','{number_house}','{tel}')", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }
            db.CloseConnection();
        }

        public bool GetBranchById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Branch Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.city = npgsqlDataReader[1].ToString();
                this.street = npgsqlDataReader[2].ToString();
                this.number_house = int.Parse(npgsqlDataReader[3].ToString());
                this.tel = npgsqlDataReader[4].ToString();

                return true;
            }
            db.CloseConnection();
            return false;
        }
    }
}