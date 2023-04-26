namespace BookingManagementBlazor.Models.Reservation
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? RoomId { get; set; }
    }
}
