using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetZooApi.Models
{
    public class SharedHabitat
    {
        [Key]
        public string animal { get; set; }
    }
}
