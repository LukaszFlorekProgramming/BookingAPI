using AutoMapper;
using Booking.Application.Mappings;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Queries.GetImages
{
    public class ImageDto : IMapFrom<Image>
    {
        public int Id { get; set; }
        public byte[] PhotoResource { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Image, ImageDto>()
                .ForMember(d => d.Id, map => map.MapFrom(src => src.Id));
        }
    }
}
