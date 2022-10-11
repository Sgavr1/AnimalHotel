using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class RoomModel
    {
        public int id;
        public AnimalTypeMode animalType;
        public int number;
        public AnimalModel animal;
        public float Price;
        public RoomTypeModel roomType;
        public BranchModel branch;
        public bool status;

        public RoomModel()
        {
            animalType = new AnimalTypeMode();
            animal = new AnimalModel();
            roomType = new RoomTypeModel();
            branch = new BranchModel();
        }

        public void AddRoom(int animalType, int number, int price, int roomtype, int branch, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            DateTime nowDate = DateTime.Now;
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Room(animaltype_id, number, animal_id, price, roomtype_id, branch_id, status) Values('{animalType}', '{number}', '{animal}', '{price}', '{roomtype}', '{branch}', 'true');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }

        public bool CheckRoom(int number, int branch, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            DateTime nowDate = DateTime.Now;
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Room Where number = '{number}' and branch_id = '{branch}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public static List<RoomModel> GetAllRoom(string postgreas)
        {
            List<RoomModel> rooms = new List<RoomModel>();

            DBConect db = new DBConect(postgreas);
            DateTime nowDate = DateTime.Now;
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Room", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                RoomModel room = new RoomModel();
                room.id = int.Parse(npgsqlDataReader[0].ToString());
                room.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                room.number = int.Parse(npgsqlDataReader[2].ToString());
                room.animal.id = int.Parse(npgsqlDataReader[3].ToString());
                room.Price = int.Parse(npgsqlDataReader[4].ToString());
                room.roomType.id = int.Parse(npgsqlDataReader[5].ToString());
                room.branch.id = int.Parse(npgsqlDataReader[6].ToString());
                room.status = bool.Parse(npgsqlDataReader[7].ToString());

                rooms.Add(room);
            }
            db.CloseConnection();

            foreach(RoomModel room in rooms)
            {
                room.animalType.GetAnimalTypeById(room.animalType.id, postgreas);
                room.animal.GetAnimalById(room.animal.id, postgreas);
                room.roomType.GetRoomTypeById(room.roomType.id, postgreas);
                room.branch.GetBranchById(room.branch.id, postgreas);
            }

            return rooms;
        }

        public static List<RoomModel> GetAllRoomByBranch(int branch, string postgreas)
        {
            List<RoomModel> rooms = new List<RoomModel>();

            DBConect db = new DBConect(postgreas);
            DateTime nowDate = DateTime.Now;
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Room Where branch_id = '{branch}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                RoomModel room = new RoomModel();
                room.id = int.Parse(npgsqlDataReader[0].ToString());
                room.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                room.number = int.Parse(npgsqlDataReader[2].ToString());
                room.animal.id = int.Parse(npgsqlDataReader[3].ToString());
                room.Price = int.Parse(npgsqlDataReader[4].ToString());
                room.roomType.id = int.Parse(npgsqlDataReader[5].ToString());
                room.branch.id = int.Parse(npgsqlDataReader[6].ToString());
                room.status = bool.Parse(npgsqlDataReader[7].ToString());

                rooms.Add(room);
            }
            db.CloseConnection();

            foreach (RoomModel room in rooms)
            {
                room.animalType.GetAnimalTypeById(room.animalType.id, postgreas);
                room.animal.GetAnimalById(room.animal.id, postgreas);
                room.roomType.GetRoomTypeById(room.roomType.id, postgreas);
                room.branch.GetBranchById(room.branch.id, postgreas);
            }

            return rooms;
        }

        public bool GetRoomById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Account Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                this.number = int.Parse(npgsqlDataReader[2].ToString());
                this.animal.id = int.Parse(npgsqlDataReader[3].ToString());
                this.Price = int.Parse(npgsqlDataReader[4].ToString());
                this.roomType.id = int.Parse(npgsqlDataReader[5].ToString());
                this.branch.id = int.Parse(npgsqlDataReader[6].ToString());
                this.status = bool.Parse(npgsqlDataReader[7].ToString());

                return true;
            }
            db.CloseConnection();
            return false;
        }

        public bool GetRoomByNumber(int number, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Account Where number = '{number}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
                this.animalType.id = int.Parse(npgsqlDataReader[1].ToString());
                this.number = number;
                this.animal.id = int.Parse(npgsqlDataReader[3].ToString());
                this.Price = int.Parse(npgsqlDataReader[4].ToString());
                this.roomType.id = int.Parse(npgsqlDataReader[5].ToString());
                this.branch.id = int.Parse(npgsqlDataReader[6].ToString());
                this.status = bool.Parse(npgsqlDataReader[7].ToString());

                return true;
            }
            db.CloseConnection();
            return false;
        }

        public void CloseRoom(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Update Room Set status = 'false' Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }

        public void OpenRoom(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Update Room Set status = 'true' Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }
    }
}
