using ConcertBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Services.Interfaces
{
    public interface IBookingService
    {
        Task AddBooking(Booking booking);
        IEnumerable<Booking> GetAllBooking(int concertId);
    }
}
