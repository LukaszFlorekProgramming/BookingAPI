namespace BookingManagement.Client.Models
{
    public class ReservationDetailVm
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomId { get; set; }
    }
}
