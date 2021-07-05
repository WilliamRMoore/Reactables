using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Activities
{
    public class List
    {
        public class Query : IRequest<Result<List<Activity>>> { }

        public class handler : IRequestHandler<Query, Result<List<Activity>>>
        {
            private readonly DataContext _context;
            public handler(DataContext context)
            {
                _context = context;

            }

            public async Task<Result<List<Activity>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.Activities.ToListAsync(cancellationToken);

                return Result<List<Activity>>.Success(activities);
            }
        }
    }
}