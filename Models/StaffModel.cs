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
        public float Salary;
        public DateTime beginDate;
        public DateTime endDate;
    }
}
