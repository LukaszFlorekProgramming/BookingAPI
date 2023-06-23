using AutoMapper;
using Booking.Application.Hotels.Queries.GetHotelDetail;
using Booking.Application.Mappings;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Queries.GetHotels
{
    public class HotelDto : IMapFrom<Hotel>
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; }
        public string Country { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Hotel, HotelDto>()
            .ForMember(x => x.HotelId, map => map.MapFrom(src => src.HotelId));
        }
    }
}
