using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalHotel.Models;

namespace AnimalHotel.Controllers
{
    public class OwnerController : Controller
    {
        DBConect db = new DBConect("Owner");
        MessageModel message = null;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToLogin(int accountId)
        {
            db.OpenConnection();
            return Redirect("/Owner");
        }

        public ActionResult Branch()
        {
            ViewBag.Branches = BranchModel.GetAllBranch(db);
            ViewBag.Message = message;
            message = null;
            return View();
        }

        public ActionResult AddBranch(string city, string street, int number_house, string tel)
        {
            BranchModel branch = new BranchModel();

            if(branch.CheckBranch(city,street,number_house,tel,db))
            {
                message = new MessageModel("Неверные данные", true);
                return Redirect("/Owner/Branch");
            }

            branch.AddBranch(city, street, number_house, tel, db);

            return Redirect("/Owner/Branch");
        }

        public ActionResult RemoveBranch(int id)
        {


            return Redirect("/Owner/Branch");
        }

        public ActionResult Staff()
        {
            return View();
        }

        public ActionResult Report()
        {
            return View();
        }

        public ActionResult Out()
        {
            db.CloseConnection();
            return Redirect("/Login");
        }
    }
}
