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

        public ActionResult Login(string tel, string password)
        {
            AccountModel account = new AccountModel();
            if(account.getAccount(tel, password, db))
            {
                if(account.role.id == 1)
                {
                    db.CloseConnection();
                    return Redirect("/Owner/ToLogin/"+account.id);
                }
                else if(account.role.id == 2)
                {
                    db.CloseConnection();
                    return Redirect("/Admin/ToLogin/"+account.id);
                }
                else if(account.role.id == 3)
                {
                    db.CloseConnection();
                    return Redirect("/Staff/ToLogin/"+account.id);
                }
            }

            message = new MessageModel("Неверный логин или пароль", false);
            return Redirect("/Login");
        }
    }
}
