using FurryFriendsAdoption.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurryFriendsAdoption.Configurations.Entities
{
    public class PetSeed : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Bella",
                    Species = "Dog",
                    Breed = "Golden Retriever",
                    Age = 3,
                    Gender = "Female",
                    IsAdopted = false,
                    PetCategoryId = 1
                },
                new Pet
                {
                    Id = 2,
                    Name = "Milo",
                    Species = "Cat",
                    Breed = "Siamese",
                    Age = 2,
                    Gender = "Male",
                    IsAdopted = false,
                    PetCategoryId = 2
                },
                new Pet
                {
                    Id = 3,
                    Name = "Nibbles",
                    Species = "Hamster",
                    Breed = "Syrian",
                    Age = 1,
                    Gender = "Female",
                    IsAdopted = false,
                    PetCategoryId = 3
                }
            );
        }
    }
}
