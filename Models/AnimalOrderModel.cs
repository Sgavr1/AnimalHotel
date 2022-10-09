using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHotel.Models
{
    public class AnimalOrderModel
    {
        public int id;
        public RoomModel room;
        public AnimalModel animal;
        public int sale;
        public float price;
        public OrdersModel orders;
    }
}
