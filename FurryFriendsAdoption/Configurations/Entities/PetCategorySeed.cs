using FurryFriendsAdoption.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurryFriendsAdoption.Configurations.Entities
{
    public class PetCategorySeed : IEntityTypeConfiguration<PetCategory>
    {
        public void Configure(EntityTypeBuilder<PetCategory> builder)
        {
            builder.HasData(
                new PetCategory
                {
                    Id = 1,
                    Name = "Dog"
                },
                new PetCategory
                {
                    Id = 2,
                    Name = "Cat"
                },
                new PetCategory
                {
                    Id = 3,
                    Name = "Small Mammal"
                },
                new PetCategory
                {
                    Id = 4,
                    Name = "Bird"
                },
                new PetCategory
                {
                    Id = 5,
                    Name = "Reptile"
                }
            );
        }
    }
}
