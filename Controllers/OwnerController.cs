using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHotel.Controllers
{
    public class OwnerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
