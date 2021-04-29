using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaticsStoreAssignment.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string TankName { get; set; }
        public string Volume { get; set; }
        public string Filter { get; set; }
        public string Heater { get; set; }
        public string Lighting { get; set; }
        public string Dimensions { get; set; }

        public Tank()
        {
               
        }
    }
}
