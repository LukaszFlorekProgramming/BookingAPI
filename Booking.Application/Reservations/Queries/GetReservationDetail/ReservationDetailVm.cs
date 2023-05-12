using AutoMapper;
using Booking.Application.Mappings;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Reservations.Queries.GetReservationDetail
{
    public class ReservationDetailVm : IMapFrom<Reservation>
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Reservation, ReservationDetailVm>().ForMember(x => x.RoomId, map => map.MapFrom(src => src.RoomId.Value));
        }

    }
}
