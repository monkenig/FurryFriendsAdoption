using FurryFriendsAdoption.Configurations.Entities;
using FurryFriendsAdoption.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FurryFriendsAdoption.Data
{
    public class FurryFriendsAdoptionContext(DbContextOptions<FurryFriendsAdoptionContext> options) : IdentityDbContext<FurryFriendsAdoptionUser>(options)
    {
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
