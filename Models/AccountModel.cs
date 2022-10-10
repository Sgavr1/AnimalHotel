using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AnimalHotel.Models
{
    public class AccountModel
    {
        public int id;
        public RoleModel role;
        public string login;
        public string password;

        public AccountModel()
        {
            role = new RoleModel();
        }

        public MessageModel AddAccount(string login, string password, int role, DBConect db)
        {
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Account(Role_id,login,password) Values('{role}', '{login}','{password}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }

            return new MessageModel("Акаунт добавлен", false);
        }

        public bool CheckAccount(string login, DBConect db)
        {
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Account Where login = '{login}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.login = login;
                return true;
            }

            return false;
        }

        public bool getAccount(string login, string password, DBConect db)
        {
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Account Where login = '{login}' And password = '{password}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
                this.role.id = int.Parse(npgsqlDataReader[1].ToString());
                this.login = login;
                this.password = password;
                return true;
            }
            return false;
        }
    }
}