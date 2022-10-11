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
        static AccountModel AdminAccount;
        static StaffModel AdminStaff;
        static List<OrdersModel> orders;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToLogin(int id)
        {
            AdminAccount = new AccountModel();
            AdminStaff = new StaffModel();
            orders = new List<OrdersModel>();
            AdminAccount.GetAccountById(id, postgreas);
            AdminStaff.CheckStaffbyAccount(AdminAccount.id, postgreas);

            return Redirect("/Admin");
        }

        public ActionResult Service()
        {
            BranchModel branch = new BranchModel();
            branch.GetBranchById(AdminStaff.branch.id, postgreas);
            ViewBag.Branch = branch;
            ViewBag.Service = ServiceModel.GetAllServiceByBranch(AdminStaff.branch.id, postgreas);
            ViewBag.RoomType = RoomTypeModel.GetAllRoomType(postgreas);
            ViewBag.AnimalType = AnimalTypeMode.GetAllAnimalType(postgreas);
            ViewBag.Message = message;
            message = null;
            return View();
        }

        public ActionResult AddService(string name, int animalType, int price)
        {
            ServiceModel service = new ServiceModel();
            if (service.CheckService(name, AdminStaff.branch.id, animalType, postgreas))
            {
                message = new MessageModel("Такая услуга уже существует", true);
                return Redirect("/Admin/Service");
            }

            service.AddService(name, AdminStaff.branch.id, animalType, price, postgreas);

            return Redirect("/Admin/Service");
        }

        public ActionResult CloseService(int id)
        {
            ServiceModel service = new ServiceModel();
            if (!service.GetServiceById(id, postgreas))
            {
                message = new MessageModel("Такой услуги нет", true);
                return Redirect("/Admin/Service");
            }

            service.CloseService(id, postgreas);

            return Redirect("/Admin/Service");
        }

        public ActionResult OpenService(int id)
        {
            ServiceModel service = new ServiceModel();
            if (!service.GetServiceById(id, postgreas))
            {
                message = new MessageModel("Такой услуги нет", true);
                return Redirect("/Admin/Service");
            }

            service.OpenService(id, postgreas);

            return Redirect("/Admin/Service");
        }

        public ActionResult Staff()
        {
            BranchModel branch = new BranchModel();
            branch.GetBranchById(AdminStaff.branch.id, postgreas);
            ViewBag.Branch = branch;
            ViewBag.Staffs = StaffModel.GetAllStaffByBranch(branch.id, postgreas);
            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult AddStaff(string login, string password, string tel, string first_name, string last_name, DateTime day_of_birth, string city, string street, int number_house, int salary)
        {
            AccountModel account = new AccountModel();
            if (account.CheckAccount(login, postgreas))
            {
                message = new MessageModel("Этот логин уже занят", true);
                return Redirect("/Admin/Staff");
            }
            account.AddAccount(login, password, 3, postgreas);
            account.getAccount(login, password, postgreas);

            InfoPersoneModel infoPersone = new InfoPersoneModel();
            if (infoPersone.CheckInfoPersone(tel, postgreas))
            {
                message = new MessageModel("Пользователь с таким номером уже существует", true);
                return Redirect("/Admin/Staff");
            }

            infoPersone.AddInfoPersone(tel, first_name, last_name, day_of_birth, city, street, number_house, postgreas);
            infoPersone.CheckInfoPersone(tel, postgreas);

            StaffModel staff = new StaffModel();
            staff.AddStaff(account.id, infoPersone.id, AdminStaff.branch.id, salary, postgreas);

            return Redirect("/Admin/Staff");
        }

        public ActionResult FireStaff(int id)
        {
            StaffModel staff = new StaffModel();
            if (!staff.GetStaffById(id, postgreas))
            {
                message = new MessageModel("Такого сотрудника нет", true);
                return Redirect("/Admin/Staff");
            }
            staff.FireStaff(id, postgreas);

            return Redirect("/Admin/Staff");
        }

        public ActionResult UpdateSalaryStaff(int id, int salsry)
        {
            StaffModel staff = new StaffModel();
            if (!staff.GetStaffById(id, postgreas))
            {
                message = new MessageModel("Такого сотрудника нет", true);
                return Redirect("/Admin/Staff");
            }
            staff.UpdateSalaryStaff(id, salsry, postgreas);

            return Redirect("/Admin/Staff");
        }

        public ActionResult Room()
        {
            BranchModel branch = new BranchModel();
            branch.GetBranchById(AdminStaff.branch.id, postgreas);
            ViewBag.Branch = branch;
            ViewBag.RoomType = RoomTypeModel.GetAllRoomType(postgreas);
            ViewBag.AnimalType = AnimalTypeMode.GetAllAnimalType(postgreas);
            ViewBag.Rooms = RoomModel.GetAllRoom(postgreas);
            ViewBag.Message = message;
            message = null;

            return View();
        }

        public ActionResult AddRoom(int animalType, int number, int price, int roomType)
        {
            RoomModel room = new RoomModel();
            if (room.CheckRoom(number, AdminStaff.branch.id, postgreas))
            {
                message = new MessageModel("Комната с таким номером существует", true);
                return Redirect("/Admin/Room");
            }

            room.AddRoom(animalType, number, price, roomType, AdminStaff.branch.id, postgreas);

            return Redirect("/Admin/Room");
        }

        public ActionResult CloseRoom(int id)
        {
            RoomModel room = new RoomModel();
            if (!room.GetRoomById(id, postgreas))
            {
                message = new MessageModel("Такой комнаты нет", true);
                return Redirect("/Admin/Room");
            }

            room.CloseRoom(id, postgreas);

            return Redirect("/Admin/Room");
        }

        public ActionResult OpenRoom(int id)
        {
            RoomModel room = new RoomModel();
            if (!room.GetRoomById(id, postgreas))
            {
                message = new MessageModel("Такой комнаты нет", true);
                return Redirect("/Admin/Room");
            }

            room.OpenRoom(id, postgreas);

            return Redirect("/Admin/Room");
        }

        public ActionResult Report()
        {
            orders = OrdersModel.GetAllOrderByBranch(AdminStaff.branch.id, postgreas);
            foreach (OrdersModel order in orders)
            {
                order.animalOrders = AnimalOrderModel.GetAllAnimalOrderById(order, postgreas);
                foreach (AnimalOrderModel animalOrder in order.animalOrders)
                {
                    animalOrder.serviceOrders = ServiceOrderModel.GetServiceOrderModelById(animalOrder, postgreas);
                }
            }

            BranchModel branch = new BranchModel();
            branch.GetBranchById(AdminStaff.branch.id, postgreas);
            ViewBag.Branch = branch;
            ViewBag.Orders = orders;
            int sum = 0;
            int countAnimal = 0;
            int countService = 0;

            foreach (OrdersModel order in orders)
            {
                foreach (AnimalOrderModel animalOrder in order.animalOrders)
                {
                    countAnimal++;
                    sum = (int)(animalOrder.price - (animalOrder.price / 100) * animalOrder.sale);
                    foreach (ServiceOrderModel serviceOrder in animalOrder.serviceOrders)
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

        public ActionResult AllReportByYear(int year)
        {
            orders = new List<OrdersModel>();
            List<OrdersModel> orderModels = OrdersModel.GetAllOrder(postgreas);
            foreach (OrdersModel order in orderModels)
            {
                order.animalOrders = AnimalOrderModel.GetAllAnimalOrderById(order, postgreas);
                if (order.animalOrders.Count > 0)
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

            return Redirect("/Admin/Report");
        }

        public ActionResult AllReportByBranch()
        {
            orders = OrdersModel.GetAllOrderByBranch(AdminStaff.branch.id, postgreas);
            foreach (OrdersModel order in orders)
            {
                order.animalOrders = AnimalOrderModel.GetAllAnimalOrderById(order, postgreas);
                foreach (AnimalOrderModel animalOrder in order.animalOrders)
                {
                    animalOrder.serviceOrders = ServiceOrderModel.GetServiceOrderModelById(animalOrder, postgreas);
                }
            }

            return Redirect("/Admin/Report");
        }

        public ActionResult Out()
        {
            return Redirect("/Login");
        }
    }
}
