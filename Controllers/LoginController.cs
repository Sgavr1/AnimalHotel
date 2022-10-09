using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalHotel.Models;

namespace AnimalHotel.Controllers
{
    public class LoginController : Controller
    {
        DBConect db = new DBConect("Login");
        MessageModel message = null;
        public ActionResult Index()
        {
            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult Register(string tel, string password, string first_name, string last_name, DateTime day_of_birdth, string city, string street, int number_house)
        {
            AccountModel account = new AccountModel();
            if (account.CheckAccount(tel, db))
            {
                message = new MessageModel("Пользователь с таким номером телефона уже есть", true);
                return Redirect("/Login");
            }
            account.AddAccount(tel, password, 4, db);
            account.getAccount(tel, password, db);

            return Redirect("/Login/Login");
        }

        public ActionResult Login(string tel, string password)
        {
            AccountModel account = new AccountModel();
            if(account.getAccount(tel, password, db))
            {
                if(account.role.id == 1)
                {
                    db.CloseConnection();
                    return Redirect("");
                }
                else if(account.role.id == 2)
                {
                    db.CloseConnection();
                    return Redirect("");
                }
                else if(account.role.id == 3)
                {
                    db.CloseConnection();
                    return Redirect("");
                }
                else if(account.role.id == 4)
                {
                    db.CloseConnection();
                    return Redirect("");
                }
            }

            message = new MessageModel("Неверный логин или пароль", false);
            return Redirect("/Login");
        }
    }
}
