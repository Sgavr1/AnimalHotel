using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalHotel.Models;

namespace AnimalHotel.Controllers
{
    public class StaffController : Controller
    {
        string postgreas = "staff";
        MessageModel message = null;
        List<int> number_room = new List<int>();
        static AccountModel StaffAccount;
        static StaffModel Staff;

        static List<RoomModel> rooms;
        static OrdersModel Orders;
        static List<AnimalModel> animals;
        static AnimalModel Animal;
        static List<RoomModel> RoomAnimalOrder;
        static List<ServiceModel> ServeceAnimalOrder;

        static RoomModel SelectedRoom;
        static List<ServiceModel> SelectedServices;

        static InfoPersoneModel Client;
        public ActionResult Index()
        {
            ViewBag.Client = Client;
            ViewBag.Animal = Animal;
            ViewBag.SelectedRoom = SelectedRoom;
            ViewBag.SelectedServices = SelectedServices;
            List<ServiceModel> services = new List<ServiceModel>();
            foreach(ServiceModel service in ServeceAnimalOrder)
            {
                if(service.animalType.id == Animal.animalType.id)
                {
                    services.Add(service);
                }
            }
            ViewBag.ServiceAnimals = services;
            if(Client.id != 0)
            {
                animals = AnimalModel.GetAllAnimalByPersone(Client.id, postgreas);
            }
            ViewBag.Animals = animals;
            ViewBag.RoomAnimalOrder = RoomAnimalOrder;
            ViewBag.AnimalType = AnimalTypeMode.GetAllAnimalType(postgreas);
            ViewBag.RoomType = RoomTypeModel.GetAllRoomType(postgreas);

            ViewBag.Orders = Orders;

            int price = 0;

            foreach(AnimalOrderModel animalOrder in Orders.animalOrders)
            {
                price += (int)(animalOrder.price - (animalOrder.price / 100) * animalOrder.sale);
                foreach (ServiceOrderModel serviceOrder in animalOrder.serviceOrders)
                {
                    price += (int)(animalOrder.price - (animalOrder.price / 100) * animalOrder.sale);
                }
            }

            ViewBag.numberRoom = number_room;
            ViewBag.Price = price;
            return View();
        }

        public ActionResult ToLogin(int id)
        {
            Client = new InfoPersoneModel();
            Orders = new OrdersModel();
            Orders.animalOrders = new List<AnimalOrderModel>();
            rooms = new List<RoomModel>();
            animals = new List<AnimalModel>();
            Animal = new AnimalModel();
            RoomAnimalOrder = new List<RoomModel>();
            ServeceAnimalOrder = new List<ServiceModel>();
            SelectedRoom = new RoomModel();
            SelectedServices = new List<ServiceModel>();

            StaffAccount = new AccountModel();
            Staff = new StaffModel();
            StaffAccount.GetAccountById(id, postgreas);
            Staff.CheckStaffbyAccount(StaffAccount.id, postgreas);


            return Redirect("/Staff");
        }

        public ActionResult AddClient(string tel, string first_name, string last_name, DateTime day_of_birth, string city, string street, int number_house)
        {
            InfoPersoneModel infoPersone = new InfoPersoneModel();
            if (infoPersone.CheckInfoPersone(tel, postgreas))
            {
                message = new MessageModel("Пользователь с таким номером уже существует", true);
                return Redirect("/Staff");
            }

            infoPersone.AddInfoPersone(tel, first_name, last_name, day_of_birth, city, street, number_house, postgreas);

            return Redirect("/Staff");
        }
        public ActionResult CheckClient(string tel)
        {
            if (Client.CheckInfoPersone(tel, postgreas))
            {
                return Redirect("/Staff");
            }

            message = new MessageModel("такого клиента нет", true);
            Client = new InfoPersoneModel();

            return Redirect("/Staff");
        }

        public ActionResult AddAnimal(int animalType, string name)
        {
            AnimalModel animal = new AnimalModel();
            if (animal.CheckAnimal(Client.id, animalType, name, postgreas))
            {
                message = new MessageModel("Такое животое уже есть", true);
            }

            animal.AddAnimal(Client.id, animalType, name, postgreas);

            return Redirect("/Staff");
        }

        public ActionResult CheckRoomByRoomType(int Type)
        {
            rooms = new List<RoomModel>();
            List<RoomModel> r = RoomModel.GetAllRoomByBranch(Staff.branch.id,postgreas);
            foreach(RoomModel room in r)
            {
                if(room.roomType.id == Type && room.animal == null)
                {
                    rooms.Add(room);
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult CheckRoomByAnimalType(int Type)
        {
            rooms = new List<RoomModel>();
            List<RoomModel> r = RoomModel.GetAllRoomByBranch(Staff.branch.id, postgreas);
            foreach (RoomModel room in r)
            {
                if (room.animalType.id == Type && room.animal == null)
                {
                    rooms.Add(room);
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult CloseOrder()
        {
            rooms = new List<RoomModel>();
            Orders = new OrdersModel();
            Orders.animalOrders = new List<AnimalOrderModel>();
            animals = new List<AnimalModel>();
            Animal = new AnimalModel();
            RoomAnimalOrder = new List<RoomModel>();
            ServeceAnimalOrder = new List<ServiceModel>();

            SelectedRoom = new RoomModel();
            SelectedServices = new List<ServiceModel>();

            Client = new InfoPersoneModel();

            return Redirect("/Staff");
        }

        public ActionResult AnimalToOrder(int id)
        {
            AnimalModel animal = new AnimalModel();
            animal.GetAnimalById(id, postgreas);
            Animal = animal;

            return Redirect("/Staff");
        }

        public ActionResult RoomToOrderAnimal(int type)
        {
            List<RoomModel> r = RoomModel.GetAllRoomByBranch(Staff.branch.id, postgreas);

            RoomAnimalOrder = new List<RoomModel>();

            foreach(RoomModel room in r)
            {
                if (room.roomType.id == type && room.animalType.id == Animal.animalType.id && room.animal == null)
                {
                    RoomAnimalOrder.Add(room);
                }
                foreach (AnimalOrderModel animalOrder in Orders.animalOrders)
                {
                    if (animalOrder.room.id == room.id)
                    {
                        RoomAnimalOrder.Remove(room);
                    }
                }
                
            }

            return Redirect("/Staff");
        }

        public ActionResult fillSelectRoom(int id)
        {
            foreach(RoomModel room in RoomAnimalOrder)
            {
                if(room.id == id)
                {
                    SelectedRoom = room;
                }
            }

            ServeceAnimalOrder = ServiceModel.GetAllServiceByBranch(Staff.branch.id, postgreas);

            return Redirect("/Staff");
        }

        public ActionResult fillSelectedService(int id)
        {
            List<ServiceModel> s = ServiceModel.GetAllServiceByBranch(Staff.branch.id, postgreas);
            foreach(ServiceModel service in ServeceAnimalOrder)
            {
                if(service.id == id)
                {
                    SelectedServices.Add(service);
                    ServeceAnimalOrder.Remove(service);
                    return Redirect("/Staff");
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult RemoveServiceAnimalOrder(int id)
        {
            foreach(ServiceModel service in SelectedServices)
            {
                if(id == service.id)
                {
                    ServeceAnimalOrder.Add(service);
                    SelectedServices.Remove(service);
                    return Redirect("/Staff");
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult RemoveRoomAnimalOrder(int id)
        {
            SelectedRoom = new RoomModel();
            SelectedServices = new List<ServiceModel>();
            ServeceAnimalOrder = new List<ServiceModel>();

            return Redirect("/Staff");
        }

        public ActionResult AddAnimalToOrder(int sale, int countDay)
        {
            AnimalOrderModel animalOrder = new AnimalOrderModel();
            animalOrder.id = Orders.animalOrders.Count + 1;
            animalOrder.animal = Animal;
            SelectedRoom.roomType.GetRoomTypeById(SelectedRoom.roomType.id, postgreas);
            animalOrder.room = SelectedRoom;
            animalOrder.sale = sale;
            animalOrder.begin_date = DateTime.Now;
            animalOrder.end_date = DateTime.Now;
            animalOrder.end_date.AddDays(countDay);
            animalOrder.price = countDay * SelectedRoom.Price;
            animalOrder.serviceOrders = new List<ServiceOrderModel>();
            foreach(ServiceModel service in SelectedServices)
            {
                ServiceOrderModel s = new ServiceOrderModel();
                s.id = animalOrder.serviceOrders.Count + 1;
                s.animalOrder = animalOrder;
                s.service = service;
                s.price = service.Price;
                animalOrder.serviceOrders.Add(s);
            }
            Orders.animalOrders.Add(animalOrder);

            SelectedRoom = new RoomModel();
            SelectedServices = new List<ServiceModel>();
            ServeceAnimalOrder = new List<ServiceModel>();
            Animal = new AnimalModel();

            return Redirect("/Staff");
        }

        public ActionResult InputSaleService(int animalId, int serviceId, int sale)
        {
            foreach(AnimalOrderModel animalOrder in Orders.animalOrders)
            {
                if(animalOrder.id == animalId)
                {
                    foreach(ServiceOrderModel serviceOrder in animalOrder.serviceOrders)
                    {
                        if(serviceOrder.id == serviceId)
                        {
                            serviceOrder.sale = sale;
                            return Redirect("/Staff");
                        }
                    }
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult RemoveAnimarOrder(int id)
        {
            foreach(AnimalOrderModel animalOrder in Orders.animalOrders)
            {
                if(id == animalOrder.id)
                {
                    Orders.animalOrders.Remove(animalOrder);
                    return Redirect("/Staff");
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult InsertOrder()
        {
            OrdersModel order = new OrdersModel();
            order.AddOrder(Staff.id, Client.id, postgreas);
            foreach(AnimalOrderModel animalOrder in Orders.animalOrders)
            {
                animalOrder.AddAnimalOrder(order.id, postgreas);
                foreach(ServiceOrderModel serviceOrder in animalOrder.serviceOrders)
                {
                    serviceOrder.AddServiceOrder(animalOrder.id, postgreas);
                }
            }

            return CloseOrder();
        }

        public ActionResult RealseRoom(string tel)
        {
            InfoPersoneModel client = new InfoPersoneModel();
            client.CheckInfoPersone(tel, postgreas);

            List<AnimalModel> animals = AnimalModel.GetAllAnimalByPersone(client.id, postgreas);
            List<RoomModel> r = RoomModel.GetAllRoomByBranch(Staff.branch.id, postgreas);
            foreach(RoomModel room in r)
            {
                foreach(AnimalModel animal in animals)
                {
                    if (animal.id == room.animal.id)
                    {
                        room.ReleaseRoom(room.id, postgreas);
                        number_room.Add(room.number);
                    }
                }
            }

            return Redirect("/Staff");
        }

        public ActionResult Out()
        {
            return Redirect("/Login");
        }
    }
}
