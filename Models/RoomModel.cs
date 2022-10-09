using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHotel.Models
{
    public class RoomModel
    {
        public int id;
        public AnimalTypeMode animalType;
        public int number;
        public AnimalModel animal;
        public float Price;
        public RoomTypeModel roomType;
    }
}
