using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalHotel.Models;

namespace AnimalHotel.Controllers
{
    public class AdminController : Controller
    {
        string postgreas = "admin";
        MessageModel message = null;
        AccountModel account = new AccountModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToLogin(int id)
        {
            account.GetAccountById(id, postgreas);

            return Redirect("/Admin");
        }
    }
}
