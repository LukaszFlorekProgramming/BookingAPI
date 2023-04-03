using FluentValidation;
using MediatR;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Behaviours
{
    public class ValidationBehaviour<TReauest, TResponse> : IPipelineBehavior<TReauest, TResponse>
    {
        private readonly IEnumerable<IValidator<TReauest>> _validators;
        public ValidationBehaviour(IEnumerable<IValidator<TReauest>> validators)
        {
            _validators = validators;
        }
        public async Task<TResponse> Handle(TReauest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if(_validators.Any()) 
            {
                var context = new ValidationContext<TReauest>(request);

                var failures = _validators.Select(x => x.Validate(context)).SelectMany(result => result.Errors).Where(x => x != null).ToList();
                if(failures.Count != 0)
                {
                    throw new Exception();
                }
            }
            return await next();
        }
    }
}
