namespace FurryFriendsAdoption.Domain
{
    public class Pet : BaseDomainModel
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool IsAdopted { get; set; }
        public int PetCategoryId { get; set; }
        public PetCategory? PetCategory { get; set; }
    }
}
