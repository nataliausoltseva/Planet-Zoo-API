using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlanetZooApi.Models
{
    public class HabitatEnrichment
    {
        [Key]
        public string name { get; set; }
        public string cost { get; set; }
        public string type { get; set; }
        public ICollection<Animals> animals { get; set; }
    }
}
