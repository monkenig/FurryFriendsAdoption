using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FurryFriendsAdoption.Domain;
using FurryFriendsAdoption.Configurations.Entities;

namespace FurryFriendsAdoption.Data
{
    public class FurryFriendsAdoptionContext : DbContext
    {
        public FurryFriendsAdoptionContext (DbContextOptions<FurryFriendsAdoptionContext> options)
            : base(options)
        {
        }
        public DbSet<FurryFriendsAdoption.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<FurryFriendsAdoption.Domain.Appointment> Appointment { get; set; } = default!;
        public DbSet<FurryFriendsAdoption.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<FurryFriendsAdoption.Domain.AdoptionApplication> AdoptionApplication { get; set; } = default!;
        public DbSet<FurryFriendsAdoption.Domain.PetCategory> PetCategory { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new PetCategorySeed());
            builder.ApplyConfiguration(new PetSeed());
        }
    }
}
