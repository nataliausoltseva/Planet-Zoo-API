using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetZooApi.Models
{
    public class Animal
    {
        [Key]
        public int id { get; set; }
        public string species { get; set; }
        public string species_ID { get; set; }
        public string interactivity { get; set; }
        public Social social { get; set; }
        public Reproduction reproduction { get; set; }
        public string continents { get; set; }
        public string conservation_status { get; set; }
        public Habitat habitat { get; set; }
        public string population { get; set; }
        public string edition { get; set; }
        public ICollection<SharedHabitat> shared_habitat { get; set; }
    }
}
