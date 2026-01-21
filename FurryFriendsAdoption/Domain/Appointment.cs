namespace FurryFriendsAdoption.Domain
{
    public class Appointment : BaseDomainModel
    {
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;

        public int PetId { get; set; }
        public Pet? Pet { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string? RejectionReason { get; set; }
    }
}
