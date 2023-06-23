using AutoMapper;
using Booking.Application.Mappings;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Hotels.Queries.GetHotelDetail
{
    public class HotelDetailVm : IMapFrom<Hotel>
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; }
        public string Country { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Hotel, HotelDetailVm>()
                .ForMember(d => d.HotelId, map => map.MapFrom(src => src.HotelId));
        }
    }
}
