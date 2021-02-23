using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetZooApi.Models
{
    public class Animals
    {
        [Key]
        public string species { get; set; }
    }
}
