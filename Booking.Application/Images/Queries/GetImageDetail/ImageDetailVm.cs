using AutoMapper;
using Booking.Application.Mappings;
using Booking.Application.Reservations.Queries.GetReservationDetail;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Queries.GetImageDetail
{
    public class ImageDetailVm : IMapFrom<Image>
    {
        public int Id { get; set; }
        public byte[] PhotoResource { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Image, ImageDetailVm>().ForMember(x => x.Id, map => map.MapFrom(src => src.Id));
        }

    }
}
