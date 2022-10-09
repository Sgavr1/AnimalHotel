using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHotel.Models
{
    public class ServiceModel
    {
        public int id;
        public string name;
        public BranchModel branch;
        public AnimalTypeMode animalType;
        public bool status;
        public int Price;
    }
}
