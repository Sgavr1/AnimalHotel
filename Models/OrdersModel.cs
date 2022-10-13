using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class OrdersModel
    {
        public int id;
        public StaffModel staff;
        public InfoPersoneModel personeModel;
        public int Price;
        public List<AnimalOrderModel> animalOrders;

        public OrdersModel()
        {
            this.staff = new StaffModel();
            this.personeModel = new InfoPersoneModel();
        }

        public static List<OrdersModel> GetAllOrder(string postgreas)
        {
            List<OrdersModel> orders = new List<OrdersModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Orders", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                OrdersModel order = new OrdersModel();
                order.id = int.Parse(npgsqlDataReader[0].ToString());
                order.staff.id = int.Parse(npgsqlDataReader[1].ToString());
                order.personeModel.id = int.Parse(npgsqlDataReader[2].ToString());

                orders.Add(order);
            }
            db.CloseConnection();

            foreach (OrdersModel order in orders)
            {
                order.staff.GetStaffById(order.staff.id, postgreas);
                order.personeModel.GetInfoPersoneById(order.personeModel.id, postgreas);
            }

            return orders;
        }

        public static List<OrdersModel> GetAllOrderByBranch(int branch, string postgreas)
        {
            List<OrdersModel> orders = new List<OrdersModel>();

            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Orders", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                OrdersModel order = new OrdersModel();
                order.id = int.Parse(npgsqlDataReader[0].ToString());
                order.staff.id = int.Parse(npgsqlDataReader[1].ToString());
                order.personeModel.id = int.Parse(npgsqlDataReader[2].ToString());

                orders.Add(order);
            }
            db.CloseConnection();

            foreach (OrdersModel order in orders)
            {
                order.staff.GetStaffById(order.staff.id, postgreas);
                order.personeModel.GetInfoPersoneById(order.personeModel.id, postgreas);
            }

            List<OrdersModel> Orders = new List<OrdersModel>();

            foreach (OrdersModel order in orders)
            {
                if(order.staff.branch.id == branch)
                {
                    Orders.Add(order);
                }
            }

            return Orders;
        }

        public void AddOrder(int staff, int infoPersone, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Orders(staff_id, person_id) Values('{staff}', '{infoPersone}') Returning id;", db.getConnection());
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
