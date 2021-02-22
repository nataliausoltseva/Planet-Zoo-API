using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetZooApi.Models
{
    public class Habitat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int habitatId { get; set; }
        public string land_area { get; set; }
        public string land_area_for_additional_animal { get; set; }
        public string water_area { get; set; }
        public string water_area_for_additional_animal { get; set; }
        public string climbing_area { get; set; }
        public string climbing_area_for_additional_animal { get; set; }
        public string temperature { get; set; }
        public string humidity { get; set; }
        public ICollection<Biomes> biomes { get; set; }
    }
}
