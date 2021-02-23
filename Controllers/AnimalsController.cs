using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PlanetZooApi.Models;

namespace PlanetZooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalContext _context;

        public AnimalsController(AnimalContext context)
        {
            _context = context;
        }

        // GET: api/Animals
        [HttpGet]
        public async Task<object> GetAnimals()
        {
            /**
             var animalItems = await _context.Animals
                .Include(d => d.social)
                .Include(d => d.reproduction)
                .Include(d => d.habitat)
                .Include(d => d.habitat.biomes)
                .Include(d => d.shared_habitat).ToListAsync();
             */

            string allText = System.IO.File.ReadAllText(@"C:\Users\usoln\source\repos\PlanetZooApi\Animals.json");

            object jsonObject = JsonConvert.DeserializeObject(allText);

            return await Task.Run(() => JsonConvert.DeserializeObject<Animal[]>(allText));

        }
    }
}
