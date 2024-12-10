using ConcertBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Services.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<int> GetBookedTickets(int concertId);
        IEnumerable<Booking> GetBookings(string userId);
    }
}
