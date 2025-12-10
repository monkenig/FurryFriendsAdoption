namespace FurryFriendsAdoption.Domain
{
    public class PetCategory : BaseDomainModel
    {
        public string Name { get; set; }
        public ICollection<Pet>? Pets { get; set; }
    }
}
