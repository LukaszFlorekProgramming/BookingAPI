using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Commands.CreateImage
{
    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, int>
    {
        private readonly IReservationDbContext _context;
        public CreateImageCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }
        public async Task<int> Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            Image image = new()
            {
                PhotoResource = request.PhotoResource,
            };

            _context.Images.Add(image);
            await _context.SaveChangesAsync(cancellationToken);
            return image.Id;


        }
    }
}
