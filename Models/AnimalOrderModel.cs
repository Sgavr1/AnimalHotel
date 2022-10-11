using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class AnimalOrderModel
    {
        public int id;
        public RoomModel room;
        public AnimalModel animal;
        public int sale;
        public float price;
        public OrdersModel orders;
        public DateTime begin_date;
        public DateTime end_date;
        public List<ServiceOrderModel> serviceOrders;

        public AnimalOrderModel()
        {
            room = new RoomModel();
            animal = new AnimalModel();
            orders = new OrdersModel();
        }

        public static List<AnimalOrderModel> GetAllAnimalOrderById(OrdersModel order, string postgreas)
        {
            List<AnimalOrderModel> animalorders = new List<AnimalOrderModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From AnimalOrder Where order_id = '{order.id};", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                AnimalOrderModel animalorder = new AnimalOrderModel();
                animalorder.id = int.Parse(npgsqlDataReader[0].ToString());
                animalorder.room.id = int.Parse(npgsqlDataReader[1].ToString());
                animalorder.animal.id = int.Parse(npgsqlDataReader[2].ToString());
                animalorder.sale = int.Parse(npgsqlDataReader[3].ToString());
                animalorder.price = int.Parse(npgsqlDataReader[4].ToString());
                animalorder.orders = order;
                animalorder.begin_date = DateTime.Parse(npgsqlDataReader[6].ToString());
                animalorder.end_date = DateTime.Parse(npgsqlDataReader[7].ToString());

                animalorders.Add(animalorder);
            }
            db.CloseConnection();

            foreach (AnimalOrderModel animalOrder in animalorders)
            {
                animalOrder.room.GetRoomById(animalOrder.room.id, postgreas);
                animalOrder.animal.GetAnimalById(animalOrder.id, postgreas);
            }

            return animalorders;
        }
    }
}
