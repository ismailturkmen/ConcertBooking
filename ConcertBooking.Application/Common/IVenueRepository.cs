using ConcertBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Common
{
    public interface IVenueRepository : IGenericRepository<Venue>
    {
        void UpdateVenue (Venue venue);
    }
}
