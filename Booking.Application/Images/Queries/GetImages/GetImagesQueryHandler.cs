using AutoMapper;
using AutoMapper.QueryableExtensions;
using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Queries.GetImages
{
    public class GetImagesQueryHandler : IRequestHandler<GetImagesQuery, ImagesVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;
        public GetImagesQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }
        public async Task<ImagesVm> Handle(GetImagesQuery request, CancellationToken cancellationToken)
        {
            var images = await _context.Images.AsNoTracking().ProjectTo<ImageDto>(_mapper.ConfigurationProvider).ToListAsync();
            return new ImagesVm() { Images = images };
        }
    }
}
