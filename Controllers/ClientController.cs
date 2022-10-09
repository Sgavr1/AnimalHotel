using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHotel.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
