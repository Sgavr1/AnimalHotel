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

        List<OrdersModel> orders = new List<OrdersModel>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToLogin(int accountId)
        {
            return Redirect("/Owner");
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

        public ActionResult CloseBranch(int id)
        {
            BranchModel branch = new BranchModel();
            if(!branch.GetBranchById(id, postgreas))
            {
                message = new MessageModel("Такого отделения нет", true);
                return Redirect("/Owner/Branch");
            }
            branch.CloseBranch(id, postgreas);

            return Redirect("/Owner/Branch");
        }

        public ActionResult OpenBranch(int id)
        {
            BranchModel branch = new BranchModel();
            if (!branch.GetBranchById(id, postgreas))
            {
                message = new MessageModel("Такого отделения нет", true);
                return Redirect("/Owner/Branch");
            }
            branch.OpenBranch(id, postgreas);

            return Redirect("/Owner/Branch");
        }

        public ActionResult Staff()
        {
            ViewBag.Staffs = StaffModel.GetAllStaff(postgreas);
            List<BranchModel> branches = BranchModel.GetAllBranch(postgreas);
            List<BranchModel> Branches = new List<BranchModel>();
            foreach(BranchModel branch in branches)
            {
                if (branch.status)
                {
                    Branches.Add(branch);
                }
            }
            ViewBag.Branches = Branches;
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

        public ActionResult FireStaff(int id)
        {
            StaffModel staff = new StaffModel();
            if (!staff.GetStaffById(id, postgreas))
            {
                message = new MessageModel("Такого сотрудника нет", true);
                return Redirect("/Owner/Staff");
            }
            staff.FireStaff(id, postgreas);

            return Redirect("/Owner/Staff");
        }

        public ActionResult UpdateSalaryStaff(int id, int salsry)
        {
            StaffModel staff = new StaffModel();
            if (!staff.GetStaffById(id, postgreas))
            {
                message = new MessageModel("Такого сотрудника нет", true);
                return Redirect("/Owner/Staff");
            }
            staff.UpdateSalaryStaff(id, salsry, postgreas);

            return Redirect("/Owner/Staff");
        }

        public ActionResult Report()
        {
            List<BranchModel> branches = BranchModel.GetAllBranch(postgreas);
            List<BranchModel> Branches = new List<BranchModel>();
            foreach (BranchModel branch in branches)
            {
                if (branch.status)
                {
                    Branches.Add(branch);
                }
            }
            ViewBag.Branches = Branches;
            ViewBag.Orders = orders;
            int sum = 0;
            int countAnimal = 0;
            int countService = 0;

            foreach(OrdersModel order in orders)
            {
                foreach(AnimalOrderModel animalOrder in order.animalOrders)
                {
                    countAnimal++;
                    sum = (int)(animalOrder.price - (animalOrder.price/100) * animalOrder.sale);
                    foreach(ServiceOrderModel serviceOrder in animalOrder.serviceOrders)
                    {
                        countService++;
                        sum = (int)(serviceOrder.price - (serviceOrder.price / 100) * serviceOrder.sale);
                    }
                }
            }

            ViewBag.TotalPrice = sum;
            ViewBag.TotalCountOrder = orders.Count;
            ViewBag.TotalCountAnimal = countAnimal;
            ViewBag.TotalCountService = countService;

            return View();
        }

        public ActionResult AllReport()
        {
            orders = OrdersModel.GetAllOrder(postgreas);
            foreach (OrdersModel order in orders)
            {
                order.animalOrders = AnimalOrderModel.GetAllAnimalOrderById(order, postgreas);
                foreach(AnimalOrderModel animalOrder in order.animalOrders)
                {
                    animalOrder.serviceOrders = ServiceOrderModel.GetServiceOrderModelById(animalOrder, postgreas);
                }
            }

            return Redirect("/Owner/Report");
        }

        public ActionResult AllReportByBranch(int branch)
        {
            orders = OrdersModel.GetAllOrderByBranch(branch, postgreas);
            foreach (OrdersModel order in orders)
            {
                order.animalOrders = AnimalOrderModel.GetAllAnimalOrderById(order, postgreas);
                foreach (AnimalOrderModel animalOrder in order.animalOrders)
                {
                    animalOrder.serviceOrders = ServiceOrderModel.GetServiceOrderModelById(animalOrder, postgreas);
                }
            }

            return Redirect("/Owner/Report");
        }

        public ActionResult AllReportByYear(int year)
        {
            orders = new List<OrdersModel>();
            List<OrdersModel> orderModels = OrdersModel.GetAllOrder(postgreas);
            foreach (OrdersModel order in orderModels)
            {
                order.animalOrders = AnimalOrderModel.GetAllAnimalOrderById(order, postgreas);
                if(order.animalOrders.Count > 0)
                {
                    if (order.animalOrders[0].begin_date.Year == year)
                    {
                        foreach (AnimalOrderModel animalOrder in order.animalOrders)
                        {
                            animalOrder.serviceOrders = ServiceOrderModel.GetServiceOrderModelById(animalOrder, postgreas);
                        }
                        orders.Add(order);
                    }
                }
            }

            return Redirect("/Owner/Report");
        }

        public ActionResult ControlType()
        {
            List<BranchModel> branches = BranchModel.GetAllBranch(postgreas);
            List<BranchModel> Branches = new List<BranchModel>();
            foreach (BranchModel branch in branches)
            {
                if (branch.status)
                {
                    Branches.Add(branch);
                }
            }
            ViewBag.Branches = Branches;
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

        public ActionResult CloseService(int id)
        {
            ServiceModel service = new ServiceModel();
            if(!service.GetServiceById(id, postgreas))
            {
                message = new MessageModel("Такой услуги нет", true);
                return Redirect("/Owner/ControlType");
            }

            service.CloseService(id, postgreas);

            return Redirect("/Owner/ControlType");
        }

        public ActionResult OpenService(int id)
        {
            ServiceModel service = new ServiceModel();
            if (!service.GetServiceById(id, postgreas))
            {
                message = new MessageModel("Такой услуги нет", true);
                return Redirect("/Owner/ControlType");
            }

            service.OpenService(id, postgreas);

            return Redirect("/Owner/ControlType");
        }

        public ActionResult Room()
        {
            List<BranchModel> branches = BranchModel.GetAllBranch(postgreas);
            List<BranchModel> Branches = new List<BranchModel>();
            foreach (BranchModel branch in branches)
            {
                if (branch.status)
                {
                    Branches.Add(branch);
                }
            }
            ViewBag.Branches = Branches;
            ViewBag.RoomType = RoomTypeModel.GetAllRoomType(postgreas);
            ViewBag.AnimalType = AnimalTypeMode.GetAllAnimalType(postgreas);
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

        public ActionResult CloseRoom(int id)
        {
            RoomModel room = new RoomModel();
            if (!room.GetRoomById(id, postgreas))
            {
                message = new MessageModel("Такой комнаты нет",true);
                return Redirect("/Owner/Room");
            }

            room.CloseRoom(id, postgreas);

            return Redirect("/Owner/Room");
        }

        public ActionResult OpenRoom(int id)
        {
            RoomModel room = new RoomModel();
            if (!room.GetRoomById(id, postgreas))
            {
                message = new MessageModel("Такой комнаты нет", true);
                return Redirect("/Owner/Room");
            }

            room.OpenRoom(id, postgreas);

            return Redirect("/Owner/Room");
        }

        public ActionResult Out()
        {
            return Redirect("/Login");
        }
    }
}
