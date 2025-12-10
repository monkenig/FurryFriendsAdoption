namespace FurryFriendsAdoption.Domain
{
    public class AdoptionApplication : BaseDomainModel
    {
        public int PetId { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
