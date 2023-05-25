using Booking.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Images.Commands.DeleteImage
{
    public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand,int>
    {
        private readonly IReservationDbContext _context;
        public DeleteImageCommandHandler(IReservationDbContext reservationDbContext)
        {
            _context = reservationDbContext;
        }

        public async Task<int> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
        {
            var image = await _context.Images.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            _context.Images.Remove(image);
            await _context.SaveChangesAsync(cancellationToken);
            return image.Id;
        }

        
    }
}
