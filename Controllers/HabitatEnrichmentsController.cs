using System;
using System.Collections.Generic;
using System.Linq;
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
    public class HabitatEnrichmentsController : ControllerBase
    {
        private readonly AnimalContext _context;

        public HabitatEnrichmentsController(AnimalContext context)
        {
            _context = context;
        }

        // GET: api/HabitatEnrichments
        [HttpGet]
        public async Task<object> GetHabitatEnrichments()
        {
            string allText = System.IO.File.ReadAllText(@"C:\Users\usoln\source\repos\PlanetZooApi\Habitat.json");

            object jsonObject = JsonConvert.DeserializeObject(allText);

            return await Task.Run(() => JsonConvert.DeserializeObject<HabitatEnrichment[]>(allText));
        }

    }
}
