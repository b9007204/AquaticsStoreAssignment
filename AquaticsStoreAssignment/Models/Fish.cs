using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AquaticsStoreAssignment.Models
{
    public class Fish
    {
        public string ID { get; set; }
        [DisplayName("Fish Name")]
        public string FishName { get; set; }
        [DisplayName("Habitat Type")]
        public string HabitatType { get; set; }
        public string Temperament { get; set; }
        [DisplayName("Average Size")]
        public string AverageSize { get; set; }
        [DisplayName("Minimum Tank Size")]
        public string MinimumTankSize { get; set; }
        public string Diet { get; set; }
        public string Lifespan { get; set; }
        public string Availability { get; set; }
        [DisplayName("Fish Birthday")]
        public DateTime FishBirthday { get; set; }
        public Fish()
        {

        }
    }
}
