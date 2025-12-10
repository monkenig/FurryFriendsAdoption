namespace FurryFriendsAdoption.Domain
{
    public class Appointment : BaseDomainModel
    {
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public int PetId { get; set; }
        public int CustomerId { get; set; }
    }
}
