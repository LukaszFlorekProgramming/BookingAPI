using AutoMapper;
using Booking.Application.Mappings;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Queries.GetReservations
{
    public class ReservationDto : IMapFrom<Reservation>
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserName { get; set; }
        public int? RoomId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Reservation, ReservationDto>()
                .ForMember(d => d.Id, map => map.MapFrom(src => src.Id));
        }
    }
}
