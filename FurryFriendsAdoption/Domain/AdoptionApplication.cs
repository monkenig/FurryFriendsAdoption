namespace FurryFriendsAdoption.Domain
{
    public class AdoptionApplication : BaseDomainModel
    {
        public int PetId { get; set; }
        public Pet? Pet { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public AdoptionApplicationStatus Status { get; set; } = AdoptionApplicationStatus.Pending;
        public DateTime ApplicationDate { get; set; }
        public string? RejectionReason { get; set; }
    }
}
