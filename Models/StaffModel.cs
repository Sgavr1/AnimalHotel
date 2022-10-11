using Npgsql;
using System;
using System.Collections.Generic;

namespace AnimalHotel.Models
{
    public class StaffModel
    {
        public int id;
        public AccountModel account;
        public InfoPersoneModel infoPersone;
        public BranchModel branch;
        public float salary;
        public DateTime beginDate;
        public DateTime endDate;

        public StaffModel()
        {
            account = new AccountModel();
            infoPersone = new InfoPersoneModel();
            branch = new BranchModel();
        }

        public bool CheckStaffbyAccount(int idAccount, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Staff Where account_id = '{idAccount}' And end_date IS NULL", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
                this.account.id = int.Parse(npgsqlDataReader[1].ToString());
                this.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                this.beginDate = DateTime.Parse(npgsqlDataReader[3].ToString());
                this.branch.id = int.Parse(npgsqlDataReader[5].ToString());
                this.salary = int.Parse(npgsqlDataReader[6].ToString());

                db.CloseConnection();
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public bool CheckStaffbyInfoPersone(int idInfoPersone, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Staff Where info_id = '{idInfoPersone}' And end_date IS NULL", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = int.Parse(npgsqlDataReader[0].ToString());
                this.account.id = int.Parse(npgsqlDataReader[1].ToString());
                this.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                this.beginDate = DateTime.Parse(npgsqlDataReader[3].ToString());
                this.branch.id = int.Parse(npgsqlDataReader[5].ToString());
                this.salary = int.Parse(npgsqlDataReader[6].ToString());

                db.CloseConnection();
                return true;
            }
            db.CloseConnection();

            return false;
        }

        public void AddStaff(int account_id, int infoPersone_id, int branch_id, int salary, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            DateTime nowDate = DateTime.Now;
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Insert Into Staff(account_id, info_id, begin_date, branch_id, salary) Values('{account_id}', '{infoPersone_id}', '{nowDate.ToString("dd.MM.yyyy")}', '{branch_id}', '{salary}');", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }

        public static List<StaffModel> GetAllStaff(string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            List<StaffModel> staffs = new List<StaffModel>();

            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Staff Where end_date IS NULL", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                StaffModel staff = new StaffModel();
                staff.id = int.Parse(npgsqlDataReader[0].ToString());
                staff.account.id = int.Parse(npgsqlDataReader[1].ToString());
                staff.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                staff.beginDate = DateTime.Parse(npgsqlDataReader[3].ToString());
                staff.branch.id = int.Parse(npgsqlDataReader[5].ToString());
                staff.salary = int.Parse(npgsqlDataReader[6].ToString());

                staffs.Add(staff);
            }
            db.CloseConnection();

            foreach (StaffModel staff in staffs)
            {
                staff.account.GetAccountById(staff.account.id, postgreas);
                staff.infoPersone.GetInfoPersoneById(staff.infoPersone.id, postgreas);
                staff.branch.GetBranchById(staff.branch.id, postgreas);
            }

            return staffs;
        }

        public static List<StaffModel> GetAllStaffByBranch(int branch_id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            List<StaffModel> staffs = new List<StaffModel>();

            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Staff Where end_date IS NULL And branch_id = '{branch_id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                StaffModel staff = new StaffModel();
                staff.id = int.Parse(npgsqlDataReader[0].ToString());
                staff.account.id = int.Parse(npgsqlDataReader[1].ToString());
                staff.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                staff.beginDate = DateTime.Parse(npgsqlDataReader[3].ToString());
                staff.branch.id = int.Parse(npgsqlDataReader[5].ToString());
                staff.salary = int.Parse(npgsqlDataReader[6].ToString());

                staffs.Add(staff);
            }
            db.CloseConnection();

            foreach (StaffModel staff in staffs)
            {
                staff.account.GetAccountById(staff.account.id, postgreas);
                staff.infoPersone.GetInfoPersoneById(staff.infoPersone.id, postgreas);
                staff.branch.GetBranchById(staff.branch.id, postgreas);
            }

            return staffs;
        }
        public bool GetStaffById(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Select * From Staff Where id = '{id}'", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {
                this.id = id;
                this.account.id = int.Parse(npgsqlDataReader[1].ToString());
                this.infoPersone.id = int.Parse(npgsqlDataReader[2].ToString());
                this.beginDate = DateTime.Parse(npgsqlDataReader[3].ToString());
                this.branch.id = int.Parse(npgsqlDataReader[5].ToString());
                this.salary = int.Parse(npgsqlDataReader[6].ToString());

                db.CloseConnection();
                return true;
            }
            db.CloseConnection();
            return false;
        }

        public void FireStaff(int id, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Update Staff Set end_date = '{DateTime.Now.ToString("dd.MM.yyyy")}' Where id = '{id}';", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }

        public void UpdateSalaryStaff(int id, int salsry, string postgreas)
        {
            DBConect db = new DBConect(postgreas);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand($"Update Staff Set salary = '{salsry}' Where id = '{id}';", db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader npgsqlDataReader = command.ExecuteReader();
            while (npgsqlDataReader.Read())
            {

            }
            db.CloseConnection();
        }
    }
}
