using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetZooApi.Models
{
    public class Reproduction
    {
        [Key]
        public int maturity { get; set; }
        public float incubation { get; set; }
        public int interbirth { get; set; }
    }
}
