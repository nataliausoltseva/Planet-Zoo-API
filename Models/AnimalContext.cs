using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetZooApi.Models
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options) { }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Biomes> Biomes{get;set;}
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<Reproduction> Reproductions { get; set; }
        public DbSet<SharedHabitat> SharedHabitats { get; set; }
        public DbSet<Social> Socials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(p => p.id)
                .ValueGeneratedOnAdd();

        }
    }
}
