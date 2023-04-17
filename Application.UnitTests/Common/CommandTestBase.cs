
using Booking.Persistance;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        protected readonly ReservationDbContext _context;
        protected readonly Mock<ReservationDbContext> _contextMock;
        public CommandTestBase()
        {
            _contextMock = ReservationDbContextFactory.Create();
            _context = _contextMock.Object;
        }
        public void Dispose()
        {
            ReservationDbContextFactory.Destroy(_context);
        }
    }
}
