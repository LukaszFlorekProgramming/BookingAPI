using AutoMapper;
using Booking.Application.Mappings;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Booking.Application.Rooms.Queries.GetRoomsAndImages
{
    public class RoomAndImageDto : IMapFrom<Room>
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
        public int? HotelId { get; set; }
        public byte[] PhotoResource { get; set; }
        public string NameHotel { get; set; } = string.Empty;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Room, RoomAndImageDto>()
                .ForMember(d => d.PhotoResource, map => map.MapFrom(src => src.Image.PhotoResource))
                .ForMember(x => x.NameHotel, map => map.MapFrom(src => src.Hotel.Name));
        }
         
    }
}
