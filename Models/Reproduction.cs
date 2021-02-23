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
        public string maturity { get; set; }
        public string incubation { get; set; }
        public float interbirth { get; set; }
    }
}
