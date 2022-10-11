using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class ServiceModel
    {
        public int id;
        public string name;
        public BranchModel branch;
        public AnimalTypeMode animalType;
        public bool status;
        public int Price;

        public ServiceModel()
        {
            branch = new BranchModel();
            animalType = new AnimalTypeMode();
        }

        public bool CheckService(string name, int branch, int animalType, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Service Where name = '{name}' and branch_id = '{branch}' and animalType = '{animalType}';", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public void AddService(string name, int branch, int animalType, int price, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Service(name, branch_id,price,status,animalType) Values('{name}','{branch}', '{price}', 'true', '{animalType}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }
            db.CloseConnection();
        }

        public static List<ServiceModel> GetAllService(string postgreas)
        {
            List<ServiceModel> services = new List<ServiceModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Service;", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                ServiceModel service = new ServiceModel();
                service.id = int.Parse(npgsqlDataReader[0].ToString());
                service.name = npgsqlDataReader[1].ToString();
                service.branch.id = int.Parse(npgsqlDataReader[2].ToString());
                service.Price = int.Parse(npgsqlDataReader[3].ToString());
                service.status = bool.Parse(npgsqlDataReader[4].ToString());
                service.animalType.id = int.Parse(npgsqlDataReader[5].ToString());

                services.Add(service);
            }
            db.CloseConnection();

            foreach(ServiceModel service in services)
            {
                service.branch.GetBranchById(service.branch.id, postgreas);
                service.animalType.GetAnimalTypeById(service.animalType.id, postgreas);
            }

            return services;
        }

        public static List<ServiceModel> GetAllServiceByBranch(int branch, string postgreas)
        {
            List<ServiceModel> services = new List<ServiceModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Service Where branch_id = '{branch}';", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                ServiceModel service = new ServiceModel();
                service.id = int.Parse(npgsqlDataReader[0].ToString());
                service.name = npgsqlDataReader[1].ToString();
                service.branch.id = int.Parse(npgsqlDataReader[2].ToString());
                service.Price = int.Parse(npgsqlDataReader[3].ToString());
                service.status = bool.Parse(npgsqlDataReader[4].ToString());
                service.animalType.id = int.Parse(npgsqlDataReader[5].ToString());

                services.Add(service);
            }
            db.CloseConnection();

            foreach (ServiceModel service in services)
            {
                service.branch.GetBranchById(service.branch.id, postgreas);
                service.animalType.GetAnimalTypeById(service.animalType.id, postgreas);
            }

            return services;
        }

        public bool GetServiceById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Service Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.name = npgsqlDataReader[1].ToString();
                this.branch.id = int.Parse(npgsqlDataReader[2].ToString());
                this.Price = int.Parse(npgsqlDataReader[3].ToString());
                this.status = bool.Parse(npgsqlDataReader[4].ToString());
                this.animalType.id = int.Parse(npgsqlDataReader[5].ToString());

                return true;
            }
            db.CloseConnection();
            return false;
        }
    }
}
