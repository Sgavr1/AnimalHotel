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
        MessageModel message = null;
        public ActionResult Index()
        {


            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult Register(string tel, string password, string first_name, string last_name, DateTime day_of_birdth, string city, string street, int number_house)
        {
            

            return Redirect("/Login");
        }
    }
}
