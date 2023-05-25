namespace BookingManagementBlazor.Models.Room
{
    public class RoomDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
        public double PricePerNight { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int RoomNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? ImageId { get; set; }

    }
}
