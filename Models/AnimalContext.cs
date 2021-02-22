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

            modelBuilder.Entity<Biomes>()
               .Property(p => p.biomesId)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Habitat>()
               .Property(p => p.habitatId)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Reproduction>()
               .Property(p => p.reproductionId)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<SharedHabitat>()
               .Property(p => p.sharedHabitatId)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Social>()
                .Property(p => p.socialId)
                .ValueGeneratedOnAdd();
        }
    }
}
