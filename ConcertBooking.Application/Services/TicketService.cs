using ConcertBooking.Application.Common;
using ConcertBooking.Application.Services.Interfaces;
using ConcertBooking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Services
{
    public class TicketService : ITicketService
    {
        private IUnitOfWork _unitOfWork;
        public TicketService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<int> GetBookedTickets(int concertId)
        {
            var bookedSeatNumber = _unitOfWork.TicketRepository
                .GetAll(include:x=>x.Include(b=>b.Booking))
                .Where(x=>x.Booking.ConcertId == concertId && x.IsBooked)
                .Select(t=>t.SeatNumber).ToList();
            return bookedSeatNumber;
        }

        public IEnumerable<Booking> GetBookings(string userId)
        {
           var bookings = _unitOfWork.BookingRepository.GetAll(include: x=> x.Include( a=>a.Concert).Include(t => t.Ticket))
                .Where(x=>x.ApplicationUserId == userId).ToList();
            return bookings;
        }
    }
}
