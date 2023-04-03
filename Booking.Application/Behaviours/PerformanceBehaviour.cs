using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Behaviours
{
    public class PerformanceBehaviour<TRequest, TResposne> : IPipelineBehavior<TRequest, TResposne>
    {
        private readonly ILogger _logger;
        private readonly Stopwatch _timer;
        public PerformanceBehaviour(ILogger<TRequest> logger)
        {
            _timer = new Stopwatch();
            _logger = logger;
        }
        public async Task<TResposne> Handle(TRequest request, RequestHandlerDelegate<TResposne> next, CancellationToken cancellationToken)
        {
            _timer.Start();
            var response = await next();

            _timer.Stop();

            var elapsed = _timer.ElapsedMilliseconds;

            if(elapsed > 500)
            {
                var requestName = typeof(TRequest).Name;
                _logger.LogInformation("Booking Long Running Request: {Name} ({elapsed} millisecond {@Request})",
                    requestName,elapsed,request);
            }
            return response;
        }
    }
}
