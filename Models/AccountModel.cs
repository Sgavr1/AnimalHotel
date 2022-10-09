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
        public string tel;
        public string password;

        public MessageModel AddAccount(string tel, string password, int role, string name_role)
        {
            if(CheckAccount(tel, name_role))
            {
                return new MessageModel("Пользователь с таким номером существует", true);
            }

            DBConect db = new DBConect(name_role);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Account(Role_id,tel,password) Values('{role}', '{tel}','{password}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }
            db.CloseConnection();

            return new MessageModel("Акаунт добавлен", false);
        }

        public bool CheckAccount(string tel, string role)
        {
            DBConect db = new DBConect(role);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Account Where tel = '{tel}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                return true;
            }
            db.CloseConnection();

            return false;
        }
    }
}
