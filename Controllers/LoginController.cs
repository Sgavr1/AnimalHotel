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
        string postgreas = "tologin";
        MessageModel message = null;
        public ActionResult Index()
        {
            ViewBag.Message = message;
            message = null;

            return Login("OdessaAdmin", "odessaAdmin");
            return Login("Owner", "Boss");

            return View();
        }

        public ActionResult Login(string login, string password)
        {
            AccountModel account = new AccountModel();
            if(account.getAccount(login, password, postgreas))
            {
                if(account.role.id == 1)
                {
                    return Redirect("/Owner/ToLogin/"+account.id);
                }
                else if(account.role.id == 2)
                {
                    return Redirect("/Admin/ToLogin/"+account.id);
                }
                else if(account.role.id == 3)
                {
                    return Redirect("/Staff/ToLogin/"+account.id);
                }
            }

            message = new MessageModel("Неверный логин или пароль", false);
            return Redirect("/Login");
        }
    }
}
