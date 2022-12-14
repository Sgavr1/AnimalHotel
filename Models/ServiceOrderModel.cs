using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class ServiceOrderModel
    {
        public int id;
        public ServiceModel service;
        public int sale;
        public float price;
        public AnimalOrderModel animalOrder;

        public ServiceOrderModel()
        {
            service = new ServiceModel();
            animalOrder = new AnimalOrderModel();
        }

        public static List<ServiceOrderModel> GetServiceOrderModelById(AnimalOrderModel animalOrder, string postgreas)
        {
            List<ServiceOrderModel> serviceOrders = new List<ServiceOrderModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From SeviceOrder Where animalorder_id = '{animalOrder.id};", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                ServiceOrderModel serviceOrder = new ServiceOrderModel();
                serviceOrder.id = int.Parse(npgsqlDataReader[0].ToString());
                serviceOrder.service.id = int.Parse(npgsqlDataReader[1].ToString());
                serviceOrder.sale = int.Parse(npgsqlDataReader[2].ToString());
                serviceOrder.animalOrder = animalOrder;
                serviceOrder.price = int.Parse(npgsqlDataReader[4].ToString());

                serviceOrders.Add(serviceOrder);
            }
            db.CloseConnection();

            foreach (ServiceOrderModel serviceOrder in serviceOrders)
            {
                serviceOrder.service.GetServiceById(animalOrder.room.id, postgreas);
            }

            return serviceOrders;
        }

        public void AddServiceOrder(int animalOrder, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into ServiceOrder(service_id, sale, animalOrder_id, price) Values('{this.service.id}', '{this.sale}', '{animalOrder}', '{this.price}') Returning id;", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
            }
            db.CloseConnection();
        }
    }
}
