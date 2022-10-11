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
        string postgreas = "owner";
        MessageModel message = null;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToLogin(int accountId)
        {
            return Redirect("/Owner/ControlType");
        }

        public ActionResult Branch()
        {
            ViewBag.Branches = BranchModel.GetAllBranch(postgreas);
            ViewBag.Message = message;
            message = null;
            return View();
        }

        public ActionResult AddBranch(string city, string street, int number_house, string tel)
        {
            BranchModel branch = new BranchModel();

            if(branch.CheckBranch(city,street,number_house,tel,postgreas))
            {
                message = new MessageModel("Неверные данные", true);
                return Redirect("/Owner/Branch");
            }

            branch.AddBranch(city, street, number_house, tel, postgreas);

            return Redirect("/Owner/Branch");
        }

        public ActionResult RemoveBranch(int id)
        {
            return Redirect("/Owner/Branch");
        }

        public ActionResult Staff()
        {
            ViewBag.Staffs = StaffModel.GetAllStaff(postgreas);
            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult AddStaff(string login, string password, int role, string tel, string first_name, string last_name, DateTime day_of_birth, string city, string street, int number_house, int branch, int salary)
        {
            AccountModel account = new AccountModel();
            if(account.CheckAccount(login, postgreas))
            {
                message = new MessageModel("Этот логин уже занят", true);
                return Redirect("/Owner/Staff");
            }
            account.AddAccount(login, password, role, postgreas);
            account.getAccount(login, password, postgreas);

            InfoPersoneModel infoPersone = new InfoPersoneModel();
            if (infoPersone.CheckInfoPersone(tel, postgreas))
            {
                message = new MessageModel("Пользователь с таким номером уже существует", true);
                return Redirect("/Owner/Staff");
            }

            infoPersone.AddInfoPersone(tel,first_name,last_name,day_of_birth,city,street,number_house,postgreas);
            infoPersone.CheckInfoPersone(tel,postgreas);

            StaffModel staff = new StaffModel();
            staff.AddStaff(account.id, infoPersone.id, branch, salary, postgreas);

            return Redirect("/Owner/Staff");
        }

        public ActionResult Report()
        {
            return View();
        }

        public ActionResult ControlType()
        {
            ViewBag.RoomType = RoomTypeModel.GetAllRoomType(postgreas);
            ViewBag.AnimalType = AnimalTypeMode.GetAllAnimalType(postgreas);
            ViewBag.Service = ServiceModel.GetAllService(postgreas);
            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult AddRoomType(string nameType)
        {
            if(RoomTypeModel.CheckRoomType(nameType, postgreas))
            {
                message = new MessageModel("Такой тип комнат существует", true);
                return Redirect("/Owner/ControlType");
            }

            RoomTypeModel.AddRoomType(nameType, postgreas);

            return Redirect("/Owner/ControlType");
        }

        public ActionResult AddAnimalType(string nameType)
        {
            if (AnimalTypeMode.CheckAnimalType(nameType, postgreas))
            {
                message = new MessageModel("Такой тип животных существует", true);
                return Redirect("/Owner/ControlType");
            }

            AnimalTypeMode.AddAnimalType(nameType, postgreas);

            return Redirect("/Owner/ControlType");
        }

        public ActionResult AddService(string name, int branch, int animalType, int price)
        {
            ServiceModel service = new ServiceModel();
            if (service.CheckService(name, branch, animalType, postgreas))
            {
                message = new MessageModel("Такая услуга уже существует", true);
                return Redirect("/Owner/ControlType");
            }

            service.AddService(name,branch,animalType,price,postgreas);

            return Redirect("/Owner/ControlType");
        }

        public ActionResult Room()
        {
            ViewBag.Rooms = RoomModel.GetAllRoom(postgreas);
            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult AddRoom(int animalType, int number, int price, int roomType, int branch)
        {
            RoomModel room = new RoomModel();
            if(room.CheckRoom(number, branch, postgreas))
            {
                message = new MessageModel("Комната с таким номером существует", true);
                return Redirect("/Owner/Room");
            }

            room.AddRoom(animalType,number,price,roomType,branch,postgreas);

            return Redirect("/Owner/Room");
        }
        public ActionResult Out()
        {
            return Redirect("/Login");
        }
    }
}
