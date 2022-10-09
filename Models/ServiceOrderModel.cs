using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHotel.Models
{
    public class ServiceOrderModel
    {
        public int id;
        public ServiceModel service;
        public int sale;
        public float price;
        public AnimalOrderModel animalOrder;
    }
}
