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

        public void AddAccount(string login, string password, int role, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Account(Role_id,login,password) Values('{role}', '{login}','{password}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                
            }
            db.CloseConnection();

            this.role.id = role;
            this.login = login;
            this.password = password;
        }

        public bool CheckAccount(string login, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
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
            db.CloseConnection();

            return false;
        }

        public bool getAccount(string login, string password, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
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
            db.CloseConnection();

            return false;
        }

        public bool GetAccountById(int id, string postgreas)
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
                this.role.id = int.Parse(npgsqlDataReader[1].ToString());
                this.login = npgsqlDataReader[2].ToString();
                this.password = npgsqlDataReader[3].ToString();

                return true;
            }
            db.CloseConnection();
            return false;
        }
    }
}