using AutoMapper;
using Booking.Application.Interfaces;
using Booking.Application.Rooms.Queries.GetRoomDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Queries.GetImageDetail
{
    public class GetImageDetailQueryHandler : IRequestHandler<GetImageDetailQuery, ImageDetailVm>
    {
        private readonly IReservationDbContext _context;
        private IMapper _mapper;
        public GetImageDetailQueryHandler(IReservationDbContext reservationDbContext, IMapper mapper)
        {
            _context = reservationDbContext;
            _mapper = mapper;
        }

        public async Task<ImageDetailVm> Handle(GetImageDetailQuery request, CancellationToken cancellationToken)
        {
            var image = await _context.Images.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            var imageVm = _mapper.Map<ImageDetailVm>(image);
            return imageVm;
        }
    }
}
