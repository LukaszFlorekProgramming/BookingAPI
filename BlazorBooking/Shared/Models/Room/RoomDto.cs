using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models.Room
{
    public class RoomDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;
        [Required, Range(1, int.MaxValue, ErrorMessage = "The Capacity can't be smaller than 1.")]
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "The Price per night can't be smaller than 1.")]
        public double PricePerNight { get; set; }
        [Required(ErrorMessage = "Please enter a street.")]
        public string Street { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "The building number can't be smaller than 1.")]
        public int BuildingNumber { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "The room number can't be smaller than 1.")]
        public int RoomNumber { get; set; }
        [Required(ErrorMessage = "Please enter a postal code.")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter a image")]
        public int? ImageId { get; set; }
    }
}
